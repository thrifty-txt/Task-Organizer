using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Organizer {
    public partial class MainForm : Form {
        private TaskTree taskTree;
        public MainForm() {
            InitializeComponent();
        }

        private void NewTaskTreeButton_Click(object sender, EventArgs e) {
            taskTree = new TaskTree();
            taskTreeOutputBox.Items.Add(taskTree.Root);
        }

        private void NewSubTaskButton_Click(object sender, EventArgs e) {
            using (var SubTaskDialog = new TaskCreatorDialog(taskTree.Root)) {
                SubTaskDialog.ShowDialog();
                taskTreeOutputBox.Items.Clear();
                taskTreeOutputBox.Items.Add(taskTree.Root);
            }
        }
    }
}
