namespace Task_Organizer {
    partial class TaskCreatorDialog {
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.badUserPrompt = new System.Windows.Forms.Label();
            this.priorityTrackBar = new System.Windows.Forms.TrackBar();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityValueDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(123, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description (optional):";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(123, 42);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(100, 20);
            this.descBox.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(53, 125);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(134, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // badUserPrompt
            // 
            this.badUserPrompt.AutoSize = true;
            this.badUserPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badUserPrompt.ForeColor = System.Drawing.Color.Red;
            this.badUserPrompt.Location = new System.Drawing.Point(12, 102);
            this.badUserPrompt.Name = "badUserPrompt";
            this.badUserPrompt.Size = new System.Drawing.Size(127, 13);
            this.badUserPrompt.TabIndex = 6;
            this.badUserPrompt.Text = "A Name is Required!!";
            this.badUserPrompt.Visible = false;
            // 
            // priorityTrackBar
            // 
            this.priorityTrackBar.Location = new System.Drawing.Point(119, 68);
            this.priorityTrackBar.Name = "priorityTrackBar";
            this.priorityTrackBar.Size = new System.Drawing.Size(104, 45);
            this.priorityTrackBar.TabIndex = 7;
            this.priorityTrackBar.ValueChanged += new System.EventHandler(this.priorityTrackBar_ValueChanged);
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(26, 77);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(87, 13);
            this.priorityLabel.TabIndex = 8;
            this.priorityLabel.Text = "Priority (optional):";
            // 
            // priorityValueDisplay
            // 
            this.priorityValueDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityValueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityValueDisplay.Location = new System.Drawing.Point(158, 97);
            this.priorityValueDisplay.Name = "priorityValueDisplay";
            this.priorityValueDisplay.Size = new System.Drawing.Size(25, 23);
            this.priorityValueDisplay.TabIndex = 9;
            this.priorityValueDisplay.Text = "0";
            this.priorityValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskCreatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 160);
            this.Controls.Add(this.badUserPrompt);
            this.Controls.Add(this.priorityValueDisplay);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.priorityTrackBar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(290, 170);
            this.Name = "TaskCreatorDialog";
            this.Text = "Create a New Task";
            ((System.ComponentModel.ISupportInitialize)(this.priorityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label badUserPrompt;
        private System.Windows.Forms.TrackBar priorityTrackBar;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label priorityValueDisplay;
    }
}