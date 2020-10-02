namespace P4_Code
{
    partial class FormLogin
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
            this.loginMenu = new System.Windows.Forms.MenuStrip();
            this.preferenceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardButtn = new System.Windows.Forms.ToolStripMenuItem();
            this.recordButtn = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyButtn = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reportButtn = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.designMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.testMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMenu
            // 
            this.loginMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.loginMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.loginMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceMenu,
            this.issueMenu,
            this.requirementMenu,
            this.designMenu,
            this.testMenu});
            this.loginMenu.Location = new System.Drawing.Point(0, 0);
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Size = new System.Drawing.Size(1803, 60);
            this.loginMenu.TabIndex = 0;
            this.loginMenu.Text = "menu";
            // 
            // preferenceMenu
            // 
            this.preferenceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectButton,
            this.createButton,
            this.modifyButton,
            this.removeButton});
            this.preferenceMenu.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferenceMenu.Name = "preferenceMenu";
            this.preferenceMenu.Size = new System.Drawing.Size(219, 50);
            this.preferenceMenu.Tag = "";
            this.preferenceMenu.Text = "&Preferences";
            // 
            // selectButton
            // 
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(448, 54);
            this.selectButton.Text = "&Select Project";
            // 
            // createButton
            // 
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(448, 54);
            this.createButton.Text = "&Create Project";
            // 
            // modifyButton
            // 
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(448, 54);
            this.modifyButton.Text = "&Modify Project";
            // 
            // removeButton
            // 
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(448, 54);
            this.removeButton.Text = "&Remove Project";
            // 
            // issueMenu
            // 
            this.issueMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardButtn,
            this.recordButtn,
            this.modifyButtn,
            this.removeButtn,
            this.reportButtn});
            this.issueMenu.Name = "issueMenu";
            this.issueMenu.Size = new System.Drawing.Size(109, 50);
            this.issueMenu.Text = "&Issue";
            // 
            // dashboardButtn
            // 
            this.dashboardButtn.Name = "dashboardButtn";
            this.dashboardButtn.Size = new System.Drawing.Size(329, 54);
            this.dashboardButtn.Text = "&Dashboard";
            // 
            // recordButtn
            // 
            this.recordButtn.Name = "recordButtn";
            this.recordButtn.Size = new System.Drawing.Size(329, 54);
            this.recordButtn.Text = "&Record";
            // 
            // modifyButtn
            // 
            this.modifyButtn.Name = "modifyButtn";
            this.modifyButtn.Size = new System.Drawing.Size(329, 54);
            this.modifyButtn.Text = "&Modify";
            // 
            // removeButtn
            // 
            this.removeButtn.Name = "removeButtn";
            this.removeButtn.Size = new System.Drawing.Size(329, 54);
            this.removeButtn.Text = "&Remove";
            // 
            // reportButtn
            // 
            this.reportButtn.Name = "reportButtn";
            this.reportButtn.Size = new System.Drawing.Size(329, 54);
            this.reportButtn.Text = "&Report";
            // 
            // requirementMenu
            // 
            this.requirementMenu.Name = "requirementMenu";
            this.requirementMenu.Size = new System.Drawing.Size(212, 50);
            this.requirementMenu.Text = "&Requirement";
            // 
            // designMenu
            // 
            this.designMenu.Name = "designMenu";
            this.designMenu.Size = new System.Drawing.Size(134, 50);
            this.designMenu.Text = "&Design";
            // 
            // testMenu
            // 
            this.testMenu.Name = "testMenu";
            this.testMenu.Size = new System.Drawing.Size(94, 50);
            this.testMenu.Text = "&Test";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1221);
            this.Controls.Add(this.loginMenu);
            this.MainMenuStrip = this.loginMenu;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.loginMenu.ResumeLayout(false);
            this.loginMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip loginMenu;
        private System.Windows.Forms.ToolStripMenuItem preferenceMenu;
        private System.Windows.Forms.ToolStripMenuItem selectButton;
        private System.Windows.Forms.ToolStripMenuItem createButton;
        private System.Windows.Forms.ToolStripMenuItem modifyButton;
        private System.Windows.Forms.ToolStripMenuItem removeButton;
        private System.Windows.Forms.ToolStripMenuItem issueMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardButtn;
        private System.Windows.Forms.ToolStripMenuItem recordButtn;
        private System.Windows.Forms.ToolStripMenuItem modifyButtn;
        private System.Windows.Forms.ToolStripMenuItem removeButtn;
        private System.Windows.Forms.ToolStripMenuItem reportButtn;
        private System.Windows.Forms.ToolStripMenuItem requirementMenu;
        private System.Windows.Forms.ToolStripMenuItem designMenu;
        private System.Windows.Forms.ToolStripMenuItem testMenu;
    }
}