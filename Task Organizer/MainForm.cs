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
                }
            }
        }
        private void SerializeNodes(TreeNode node, StreamWriter treeFile, int depth) {
            var task = (GenericTask) node.Tag;
            treeFile.WriteLine($"{depth},{task.Serialize()}");
            if(node.Nodes.Count != 0) {
                foreach(TreeNode taskNode in node.Nodes) {
                    SerializeNodes(taskNode, treeFile, ++depth);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (outputTreeView.Nodes.Count == 0) {
                MessageBox.Show("This tree is empty!");
                return;
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
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
