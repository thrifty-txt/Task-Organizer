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
    public partial class TaskCreatorDialog : Form {
        private TreeNode Node;
        public TaskCreatorDialog(TreeNode node) {
            InitializeComponent();
            Node = node;
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text.Trim())) {
                if(badUserPrompt.Visible == true) {
                    badUserPrompt.Text += "!";
                }
                badUserPrompt.Visible = true;
                return;
            }
            Node.Tag = new GenericTask(nameBox.Text.Trim(), descBox.Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
