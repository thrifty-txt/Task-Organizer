using System;
using System.Windows.Forms;

namespace Task_Organizer {
    public partial class TaskCreatorDialog : Form {
        public GenericTask Task;
        public TaskCreatorDialog() {
            InitializeComponent();
        }
        // we re-use the Form for editing tasks as well
        // done by passing an already existing node on construction
        // we later check in the methods if Task is null or an existing Task
        public TaskCreatorDialog(TreeNode node) {
            InitializeComponent();
            Task = node.Tag as GenericTask;
            nameBox.Text = Task.Name;
            descBox.Text = Task.Description;
            priorityTrackBar.Value = Task.Priority;
            priorityValueDisplay.Text = Task.Priority.ToString();
            // update the form text accordingly
            Text = "Edit Task";
            createButton.Text = "Update";
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text.Trim())) {
                // tell the user they need a name
                if (badUserPrompt.Visible == true) {
                    // stack up on !s until they understand
                    badUserPrompt.Text += "!";
                }
                badUserPrompt.Visible = true;
                return;
            }
            if (Task == null) {
                Task = new GenericTask(nameBox.Text.Trim(), descBox.Text.Trim(), priorityTrackBar.Value, DateTime.Now);
            }
            else {
                Task.Name = nameBox.Text.Trim();
                Task.Description = descBox.Text.Trim();
                Task.Priority = priorityTrackBar.Value;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        // show the TrackBar value in a TextBox for visual clarity
        private void priorityTrackBar_ValueChanged(object sender, EventArgs e) {
            priorityValueDisplay.Text = priorityTrackBar.Value.ToString();
        }
    }
}
