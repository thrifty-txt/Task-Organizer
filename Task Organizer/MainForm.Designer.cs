
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
            this.label1 = new System.Windows.Forms.Label();
            this.newTaskTreeButton = new System.Windows.Forms.Button();
            this.taskTreeOutputBox = new System.Windows.Forms.ListBox();
            this.newSubTaskButton = new System.Windows.Forms.Button();
            this.outputTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a new TaskTree:";
            // 
            // newTaskTreeButton
            // 
            this.newTaskTreeButton.Location = new System.Drawing.Point(28, 25);
            this.newTaskTreeButton.Name = "newTaskTreeButton";
            this.newTaskTreeButton.Size = new System.Drawing.Size(75, 34);
            this.newTaskTreeButton.TabIndex = 1;
            this.newTaskTreeButton.Text = "New TaskTree";
            this.newTaskTreeButton.UseVisualStyleBackColor = true;
            this.newTaskTreeButton.Click += new System.EventHandler(this.NewTaskTreeButton_Click);
            // 
            // taskTreeOutputBox
            // 
            this.taskTreeOutputBox.FormattingEnabled = true;
            this.taskTreeOutputBox.Location = new System.Drawing.Point(12, 87);
            this.taskTreeOutputBox.Name = "taskTreeOutputBox";
            this.taskTreeOutputBox.Size = new System.Drawing.Size(277, 264);
            this.taskTreeOutputBox.TabIndex = 2;
            // 
            // newSubTaskButton
            // 
            this.newSubTaskButton.Location = new System.Drawing.Point(295, 196);
            this.newSubTaskButton.Name = "newSubTaskButton";
            this.newSubTaskButton.Size = new System.Drawing.Size(100, 21);
            this.newSubTaskButton.TabIndex = 3;
            this.newSubTaskButton.Text = "New Subtask";
            this.newSubTaskButton.UseVisualStyleBackColor = true;
            this.newSubTaskButton.Click += new System.EventHandler(this.NewSubTaskButton_Click);
            // 
            // outputTreeView
            // 
            this.outputTreeView.Location = new System.Drawing.Point(396, 87);
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
            this.Controls.Add(this.newSubTaskButton);
            this.Controls.Add(this.taskTreeOutputBox);
            this.Controls.Add(this.newTaskTreeButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newTaskTreeButton;
        private System.Windows.Forms.ListBox taskTreeOutputBox;
        private System.Windows.Forms.Button newSubTaskButton;
        private System.Windows.Forms.TreeView outputTreeView;
    }
}

