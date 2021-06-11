
namespace Task_Organizer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.newTaskButton = new System.Windows.Forms.Button();
            this.outputTreeView = new System.Windows.Forms.TreeView();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveTreeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadButton = new System.Windows.Forms.Button();
            this.openTreeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(321, 114);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(100, 21);
            this.newTaskButton.TabIndex = 3;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // outputTreeView
            // 
            this.outputTreeView.Location = new System.Drawing.Point(12, 12);
            this.outputTreeView.Name = "outputTreeView";
            this.outputTreeView.Size = new System.Drawing.Size(303, 264);
            this.outputTreeView.TabIndex = 5;
            this.outputTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.outputTreeView_NodeMouseDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveTreeFileDialog
            // 
            this.saveTreeFileDialog.DefaultExt = "tof";
            this.saveTreeFileDialog.FileName = "taskTree.tof";
            this.saveTreeFileDialog.Title = "Save Task Organizer List";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(118, 282);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load from File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openTreeFileDialog
            // 
            this.openTreeFileDialog.DefaultExt = "tof";
            this.openTreeFileDialog.FileName = "taskTree.tof";
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(321, 141);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(100, 21);
            this.deleteTaskButton.TabIndex = 8;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outputTreeView);
            this.Controls.Add(this.newTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(450, 360);
            this.Name = "MainForm";
            this.Text = "Task Organizer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newTaskButton;
        internal System.Windows.Forms.TreeView outputTreeView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveTreeFileDialog;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openTreeFileDialog;
        private System.Windows.Forms.Button deleteTaskButton;
    }
}

