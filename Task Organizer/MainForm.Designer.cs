
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTaskButton
            // 
            this.newTaskButton.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.newTaskButton.Location = new System.Drawing.Point(3, 82);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(100, 31);
            this.newTaskButton.TabIndex = 3;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // outputTreeView
            // 
            this.outputTreeView.BackColor = System.Drawing.Color.LightGray;
            this.outputTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTreeView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTreeView.Location = new System.Drawing.Point(0, 0);
            this.outputTreeView.Name = "outputTreeView";
            this.outputTreeView.Size = new System.Drawing.Size(479, 479);
            this.outputTreeView.TabIndex = 5;
            this.outputTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.outputTreeView_NodeMouseDoubleClick);
            this.outputTreeView.Click += new System.EventHandler(this.OutputTreeView_Click);
            this.outputTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputTreeView_DragDrop);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveTreeFileDialog
            // 
            this.saveTreeFileDialog.DefaultExt = "tof";
            this.saveTreeFileDialog.FileName = "taskTree.tof";
            this.saveTreeFileDialog.OverwritePrompt = false;
            this.saveTreeFileDialog.Title = "Save Task Organizer List";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.loadButton.Location = new System.Drawing.Point(117, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(108, 40);
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
            this.deleteTaskButton.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.deleteTaskButton.Location = new System.Drawing.Point(3, 119);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(100, 31);
            this.deleteTaskButton.TabIndex = 8;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.outputTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.loadButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Size = new System.Drawing.Size(479, 527);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(12, 12);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.newTaskButton);
            this.splitContainer2.Panel2.Controls.Add(this.deleteTaskButton);
            this.splitContainer2.Size = new System.Drawing.Size(602, 537);
            this.splitContainer2.SplitterDistance = 485;
            this.splitContainer2.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 561);
            this.Controls.Add(this.splitContainer2);
            this.MinimumSize = new System.Drawing.Size(450, 360);
            this.Name = "MainForm";
            this.Text = "Task Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

