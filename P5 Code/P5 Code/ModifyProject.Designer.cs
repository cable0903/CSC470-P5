namespace P5_Code
{
    partial class ModifyProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModifyProjectName = new System.Windows.Forms.Label();
            this.Modify_Cancel = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ModifyProjectName
            // 
            this.ModifyProjectName.AutoSize = true;
            this.ModifyProjectName.Location = new System.Drawing.Point(28, 50);
            this.ModifyProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProjectName.Name = "ModifyProjectName";
            this.ModifyProjectName.Size = new System.Drawing.Size(77, 13);
            this.ModifyProjectName.TabIndex = 1;
            this.ModifyProjectName.Text = "Project Name: ";
            // 
            // Modify_Cancel
            // 
            this.Modify_Cancel.Location = new System.Drawing.Point(198, 99);
            this.Modify_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Modify_Cancel.Name = "Modify_Cancel";
            this.Modify_Cancel.Size = new System.Drawing.Size(87, 35);
            this.Modify_Cancel.TabIndex = 2;
            this.Modify_Cancel.Text = "Cancel ";
            this.Modify_Cancel.UseVisualStyleBackColor = true;
            this.Modify_Cancel.Click += new System.EventHandler(this.Modify_Cancel_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(330, 99);
            this.Modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(96, 35);
            this.Modify.TabIndex = 3;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // ModifyProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 166);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Modify_Cancel);
            this.Controls.Add(this.ModifyProjectName);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyProject";
            this.Text = "Modify Project";
            this.Load += new System.EventHandler(this.ModifyProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ModifyProjectName;
        private System.Windows.Forms.Button Modify_Cancel;
        private System.Windows.Forms.Button Modify;
    }
}