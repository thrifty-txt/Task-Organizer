using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_Organizer {
    public partial class MainForm : Form {
        // must be updated when we modify the tree or save it
        private bool unsaved = false;
        public MainForm() {
            InitializeComponent();
        }
        private TreeNode NewTaskNode(GenericTask task, TreeNodeCollection parent) {
            var newNode = new TreeNode() {
                Tag = task,
                Text = task.ToString(),
                ToolTipText = task.GetToolTip()
            };
            outputTreeView.BeginUpdate();
            parent.Add(newNode);
            // Nodes seem to be collapsed by default, 
            // this will make sure that the node will expand
            if (newNode.Parent != null) {
                newNode.Parent.Expand();
            }
            outputTreeView.EndUpdate();
            return newNode;
        }
        private void NewTaskButton_Click(object sender, EventArgs e) {
            var parentNode = outputTreeView.Nodes;
            if (outputTreeView.SelectedNode != null) {
                parentNode = outputTreeView.SelectedNode.Nodes;
            }
            using (var TaskDialog = new TaskCreatorDialog()) {
                TaskDialog.ShowDialog();
                if (TaskDialog.DialogResult == DialogResult.Cancel)
                    return;
                else if(TaskDialog.DialogResult == DialogResult.OK) {
                    _ = NewTaskNode(TaskDialog.Task, parentNode);
                    // reset selected node for visual purposes
                    outputTreeView.SelectedNode = null;
                    unsaved = true;
                }
            }
        }
        private void SerializeNodes(TreeNode node, StreamWriter treeFile, int depth) {
            var task = node.Tag as GenericTask;
            treeFile.WriteLine(depth);
            // get data to serialize from object itself
            foreach(var str in task.Serialize()) {
                treeFile.WriteLine(str);
            }
            // recursively serialize all children of node
            if(node.Nodes.Count != 0) {
                foreach(TreeNode taskNode in node.Nodes) {
                    SerializeNodes(taskNode, treeFile, depth + 1);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (outputTreeView.Nodes.Count == 0) {
                const string caption = "This tree is empty!";
                const string text = "Are you sure you want to save an empty tree?";
                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) != DialogResult.Yes) {
                    return;
                }
            }
            // we don't care about the return value here
            _ = SaveTree();
        }

        private bool SaveTree() {
            if (saveTreeFileDialog.ShowDialog() != DialogResult.OK) {
                return false;
            }
            try {
                using (var treeFile = File.CreateText(saveTreeFileDialog.FileName)) {
                    // current version marker
                    treeFile.WriteLine("v1");
                    // serialize each top level node, which will recursively serialize their children
                    foreach (TreeNode taskNode in outputTreeView.Nodes) {
                        SerializeNodes(taskNode, treeFile, 0);
                    }
                    unsaved = false;
                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void LoadButton_Click(object sender, EventArgs e) {
            if (unsaved) {
                const string caption = "You have unsaved work!";
                const string text = "Are you sure you want to load a new file? You will lose all unsaved changes.";
                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) != DialogResult.Yes) {
                    return;
                }
            }
            LoadTree();
        }
        private void LoadTree() {
            if (openTreeFileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            try {
                // we want to split on newlines, which are different on unix and windows
                string[] delimiters = { Environment.NewLine };
                var dirtyTreeFile = File.ReadAllText(openTreeFileDialog.FileName);
                var treeFile = dirtyTreeFile.Split(delimiters, StringSplitOptions.None);
                switch (treeFile[0]) {
                    // check if correct version marker is there
                    case "v1":
                        Loadv1Tree(treeFile);
                        break;
                    default:
                        throw new Exception("Invalid or incompatible file.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show("File loading failed. Sorry.");
            }
        }

        private void Loadv1Tree(string[] treeFile) {
            outputTreeView.Nodes.Clear();
            TreeNode lastNode = null;
            var lastDepth = 0;
            for (var i = 1; i < treeFile.Length - 1;) {
                // each field of data is on a new line,
                // so we iterate through the lines inside the loop
                // after reading each variable
                var depth = int.Parse(treeFile[i++]);
                var type = treeFile[i++];
                var name = treeFile[i++];
                var desc = treeFile[i++];
                var prio = int.Parse(treeFile[i++]);
                var dateCreated = DateTime.Parse(treeFile[i++]);
                // TODO: Implement type checking here
                var task = new GenericTask(name, desc, prio, dateCreated);
                // if depth is 0 it is a top level node
                // and has to be put directly into the TreeView
                if (depth == 0) {
                    lastNode = NewTaskNode(task, outputTreeView.Nodes);
                }
                else if (depth == lastDepth + 1) {
                    lastNode = NewTaskNode(task, lastNode.Nodes);
                }
                // iterate through Parents to get the correct Parent to add to
                // if depth == lastDepth they are siblings
                else {
                    for (int j = 0; j < lastDepth - depth; j++) {
                        lastNode = lastNode.Parent;
                    }
                    lastNode = NewTaskNode(task, lastNode.Parent.Nodes);
                }
                lastDepth = depth;
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e) {
            if (outputTreeView.SelectedNode == null) {
                MessageBox.Show("You have to select a message to delete.");
                return;
            }
            if (outputTreeView.SelectedNode.Parent == null) {
                outputTreeView.Nodes.Remove(outputTreeView.SelectedNode);
            }
            else {
                outputTreeView.SelectedNode.Parent.Nodes.Remove(outputTreeView.SelectedNode);
            }
            outputTreeView.SelectedNode = null;
            unsaved = true;
        }

        private void OutputTreeView_DragDrop(object sender, DragEventArgs e) {

        }

        private void OutputTreeView_Click(object sender, EventArgs e) {
            outputTreeView.SelectedNode = null;

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (unsaved) {
                const string caption = "You have unsaved work!";
                const string text = "Do you want to save your work?";
                var savePrompt = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel);
                if (savePrompt == DialogResult.Yes) {
                    if(!SaveTree())
                        e.Cancel = true;
                }
                else if(savePrompt == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }

        private void outputTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            using(var taskEditor = new TaskCreatorDialog(e.Node)) {
                taskEditor.ShowDialog();
                if (taskEditor.DialogResult == DialogResult.Cancel)
                    return;
                else if(taskEditor.DialogResult == DialogResult.OK) {
                    GenericTask task = e.Node.Tag as GenericTask;
                    e.Node.Text = task.ToString();
                    e.Node.ToolTipText = task.GetToolTip();
                    unsaved = true;
                }
                
            }
        }
        // for each of these we switch between Ascend and Descend modes
        private void AlphaSortButton_Click(object sender, EventArgs e)
        {
            if (AlphaSortButton.Tag.ToString() == "Ascend")
            {
                outputTreeView.TreeViewNodeSorter = new AlphaTreeNodeASort();
                outputTreeView.Sort();
                unsaved = true;
                AlphaSortButton.BackgroundImage = Properties.Resources.sort_alphabetical_descending;
                AlphaSortButton.Tag = "Descend";
            }
            else
            {
                outputTreeView.TreeViewNodeSorter = new AlphaTreeNodeDSort();
                outputTreeView.Sort();
                AlphaSortButton.BackgroundImage = Properties.Resources.sort_alphabetical_ascending;
                AlphaSortButton.Tag = "Ascend";
            }
        }

        private void DateSortButton_Click(object sender, EventArgs e)
        {
            if (DateSortButton.Tag.ToString() == "Ascend")
            {
                outputTreeView.TreeViewNodeSorter = new DateTreeNodeASort();
                outputTreeView.Sort();
                DateSortButton.BackgroundImage = Properties.Resources.sort_calendar_descending;
                DateSortButton.Tag = "Descend";
            }
            else {
                outputTreeView.TreeViewNodeSorter = new DateTreeNodeDSort();
                outputTreeView.Sort();
                DateSortButton.BackgroundImage = Properties.Resources.sort_calendar_ascending;
                DateSortButton.Tag = "Ascend";
            }
        }

        private void PrioSortButton_Click(object sender, EventArgs e) {
            if(PrioSortButton.Tag.ToString() == "Ascend") {
                outputTreeView.TreeViewNodeSorter = new PriorityTreeNodeASort();
                outputTreeView.Sort();
                PrioSortButton.BackgroundImage = Properties.Resources.sort_numeric_descending;
                PrioSortButton.Tag = "Descend";
            }
            else {
                outputTreeView.TreeViewNodeSorter = new PriorityTreeNodeDSort();
                outputTreeView.Sort();
                PrioSortButton.BackgroundImage = Properties.Resources.sort_numeric_ascending;
                PrioSortButton.Tag = "Ascend";
            }
        }
    }
}
