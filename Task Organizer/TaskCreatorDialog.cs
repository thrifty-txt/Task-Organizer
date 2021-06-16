﻿using System;
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
        public GenericTask Task;
        public TaskCreatorDialog() {
            InitializeComponent();
        }
        public TaskCreatorDialog(TreeNode node) {
            InitializeComponent();
            Task = node.Tag as GenericTask;
            nameBox.Text = Task.Name;
            descBox.Text = Task.Description;
            Text = "Edit Task";
            createButton.Text = "Update";
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text.Trim())) {
                if (badUserPrompt.Visible == true) {
                    badUserPrompt.Text += "!";
                }
                badUserPrompt.Visible = true;
                return;
            }
            if (Task == null) {
                Task = new GenericTask(nameBox.Text.Trim(), descBox.Text.Trim());
            }
            else {
                Task.Name = nameBox.Text.Trim();
                Task.Description = descBox.Text.Trim();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
