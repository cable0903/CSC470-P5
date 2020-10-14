namespace P5_Code
{
    partial class RemoveList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttSelect = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 212);
            this.listBox1.TabIndex = 0;
            // 
            // buttSelect
            // 
            this.buttSelect.Location = new System.Drawing.Point(284, 311);
            this.buttSelect.Name = "buttSelect";
            this.buttSelect.Size = new System.Drawing.Size(134, 33);
            this.buttSelect.TabIndex = 1;
            this.buttSelect.Text = "Remove Project";
            this.buttSelect.UseVisualStyleBackColor = true;
            this.buttSelect.Click += new System.EventHandler(this.buttSelect_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.Location = new System.Drawing.Point(98, 311);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(134, 33);
            this.buttCancel.TabIndex = 2;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // RemoveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 399);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.buttSelect);
            this.Controls.Add(this.listBox1);
            this.Name = "RemoveList";
            this.Text = "Remove Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttSelect;
        private System.Windows.Forms.Button buttCancel;
    }
}