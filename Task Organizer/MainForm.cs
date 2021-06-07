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
        public MainForm() {
            InitializeComponent();
        }
        private void NewTaskButton_Click(object sender, EventArgs e) {
            var newTaskNode = new TreeNode();
            using (var TaskDialog = new TaskCreatorDialog(newTaskNode)) {
                TaskDialog.ShowDialog();
                
            }
        }
    }
}
