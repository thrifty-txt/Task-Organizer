
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
            this.SuspendLayout();
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(321, 206);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(100, 21);
            this.newTaskButton.TabIndex = 3;
            this.newTaskButton.Text = "New Subtask";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // outputTreeView
            // 
            this.outputTreeView.Location = new System.Drawing.Point(12, 98);
            this.outputTreeView.Name = "outputTreeView";
            this.outputTreeView.Size = new System.Drawing.Size(303, 264);
            this.outputTreeView.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTreeView);
            this.Controls.Add(this.newTaskButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newTaskButton;
        internal System.Windows.Forms.TreeView outputTreeView;
    }
}

