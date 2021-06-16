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
        private bool unsaved = false;
        public MainForm() {
            InitializeComponent();
        }
        private TreeNode NewTaskNode(GenericTask task, TreeNodeCollection parent) {
            var node = new TreeNode(task.ToString()) {
                Tag = task
            };
            outputTreeView.BeginUpdate();
            parent.Add(node);
            // Nodes seem to be collapsed by default, 
            // this will make sure that the node will expand
            if (node.Parent != null) {
                node.Parent.Expand();
            }
            outputTreeView.EndUpdate();
            return node;
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
                    outputTreeView.SelectedNode = null;
                    unsaved = true;
                }
            }
        }
        private void SerializeNodes(TreeNode node, StreamWriter treeFile, int depth) {
            var task = (GenericTask) node.Tag;
            treeFile.WriteLine(depth);
            foreach(var str in task.Serialize()) {
                treeFile.WriteLine(str);
            }
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
            _ = SaveTree();
        }

        private bool SaveTree() {
            if (saveTreeFileDialog.ShowDialog() != DialogResult.OK) {
                return false;
            }
            try {
                using (var treeFile = File.CreateText(saveTreeFileDialog.FileName)) {
                    treeFile.WriteLine("v0");
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
                string[] delimiters = { Environment.NewLine };
                var stinkyTreeFile = File.ReadAllText(openTreeFileDialog.FileName);
                // I am going to lose my mind with these terrible carriage return chars...
                var treeFile = stinkyTreeFile.Split(delimiters, StringSplitOptions.None);
                if (treeFile[0] != "v0") {
                    throw new Exception("Invalid or incompatible file.");
                }
                outputTreeView.Nodes.Clear();
                TreeNode lastNode = null;
                var lastDepth = 0;
                for (var i = 1; i < treeFile.Length - 1;) {
                    var depth = int.Parse(treeFile[i++]);
                    var type = treeFile[i++];
                    var name = treeFile[i++];
                    var desc = treeFile[i++];
                    // TODO: Implement type checking here
                    var task = new GenericTask(name, desc);
                    if (depth == 0) {
                        lastNode = NewTaskNode(task, outputTreeView.Nodes);
                    }
                    else if (depth == lastDepth + 1) {
                        lastNode = NewTaskNode(task, lastNode.Nodes);
                    }
                    else {
                        for (int j = 0; j < lastDepth - depth; j++) {
                            lastNode = lastNode.Parent;
                        }
                        lastNode = NewTaskNode(task, lastNode.Parent.Nodes);
                    }
                    lastDepth = depth;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show("File loading failed. Sorry.");
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
                    e.Node.Text = e.Node.Tag.ToString();
                    unsaved = true;
                }
                
            }
        }
    }
}
