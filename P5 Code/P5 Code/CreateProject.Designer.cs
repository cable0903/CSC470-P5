namespace P5_Code
{
    partial class CreateProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newProjectLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newProjectLabel
            // 
            this.newProjectLabel.AutoSize = true;
            this.newProjectLabel.Location = new System.Drawing.Point(22, 31);
            this.newProjectLabel.Name = "newProjectLabel";
            this.newProjectLabel.Size = new System.Drawing.Size(74, 13);
            this.newProjectLabel.TabIndex = 0;
            this.newProjectLabel.Text = "Project Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(174, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(301, 80);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // projectNameText
            // 
            this.projectNameText.Location = new System.Drawing.Point(102, 28);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(288, 20);
            this.projectNameText.TabIndex = 3;
            this.projectNameText.TextChanged += new System.EventHandler(this.projectNameText_TextChanged);
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 143);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newProjectLabel);
            this.Name = "CreateProject";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newProjectLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox projectNameText;
    }
}