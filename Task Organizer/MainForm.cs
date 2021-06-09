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
        private void NewTaskButton_Click(object sender, EventArgs e) {
            var parentNode = outputTreeView.Nodes;
            if(outputTreeView.SelectedNode != null) {
                parentNode = outputTreeView.SelectedNode.Nodes;
            }
            var newTaskNode = new TreeNode();
            using (var TaskDialog = new TaskCreatorDialog(newTaskNode)) {
                TaskDialog.ShowDialog();
                if (TaskDialog.DialogResult == DialogResult.Cancel)
                    return;
                else if(TaskDialog.DialogResult == DialogResult.OK) {
                    newTaskNode.Text = newTaskNode.Tag.ToString();
                    outputTreeView.BeginUpdate();
                    parentNode.Add(newTaskNode);
                    // Nodes seem to be collapsed by default, 
                    // this will make sure that the node will expand
                    // if Parent is null then the node is a root node
                    if(newTaskNode.Parent != null)
                        newTaskNode.Parent.Expand();
                    outputTreeView.SelectedNode = null;
                    outputTreeView.EndUpdate();
                    unsaved = true;
                }
            }
        }
        private void SerializeNodes(TreeNode node, StreamWriter treeFile, int depth) {
            var task = (GenericTask) node.Tag;
            treeFile.WriteLine($"{depth} {task.Serialize()}");
            if(node.Nodes.Count != 0) {
                foreach(TreeNode taskNode in node.Nodes) {
                    SerializeNodes(taskNode, treeFile, ++depth);
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
            if (saveTreeFileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            try {
                using (var treeFile = File.CreateText(saveTreeFileDialog.FileName)) {
                    treeFile.WriteLine("v0");
                    foreach (TreeNode taskNode in outputTreeView.Nodes) {
                        SerializeNodes(taskNode, treeFile, 0);
                    }
                    unsaved = false;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
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
            if (openTreeFileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            try {
                var treeFile = File.ReadAllText(openTreeFileDialog.FileName).Split('\n');
                if (treeFile[0] != "v0") {
                    throw new Exception("Invalid or incompatible file.");
                }
                outputTreeView.Nodes.Clear();
                for (var i = 1; i < treeFile.Length; i++) {
                    var depthEndIndex = treeFile[i].IndexOf(" ");
                    var depth = int.Parse(treeFile[i].Substring(0, depthEndIndex));
                    var nameSizeIndex = treeFile[i].IndexOf(" ", depthEndIndex + 1);
                    var name = 
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show("File loading failed. Sorry.");
            }
        }
    }
}
