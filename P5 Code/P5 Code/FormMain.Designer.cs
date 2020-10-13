namespace P5_Code
{
    partial class FormMain
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
            this.countAssigneeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAssigneeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countArtifactItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listArtifactItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountDateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendDateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.designMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.testMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMenu
            // 
            this.loginMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.loginMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceMenu,
            this.issueMenu,
            this.requirementMenu,
            this.designMenu,
            this.testMenu});
            this.loginMenu.Location = new System.Drawing.Point(0, 0);
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.loginMenu.Size = new System.Drawing.Size(1352, 27);
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
            this.preferenceMenu.Size = new System.Drawing.Size(91, 23);
            this.preferenceMenu.Tag = "";
            this.preferenceMenu.Text = "&Preferences";
            // 
            // selectButton
            // 
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(180, 24);
            this.selectButton.Text = "&Select Project";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // createButton
            // 
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(180, 24);
            this.createButton.Text = "&Create Project";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(180, 24);
            this.modifyButton.Text = "&Modify Project";
            // 
            // removeButton
            // 
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(180, 24);
            this.removeButton.Text = "&Remove Project";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.issueMenu.Size = new System.Drawing.Size(45, 23);
            this.issueMenu.Text = "&Issue";
            // 
            // dashboardButtn
            // 
            this.dashboardButtn.Name = "dashboardButtn";
            this.dashboardButtn.Size = new System.Drawing.Size(180, 22);
            this.dashboardButtn.Text = "&Dashboard";
            // 
            // recordButtn
            // 
            this.recordButtn.Name = "recordButtn";
            this.recordButtn.Size = new System.Drawing.Size(180, 22);
            this.recordButtn.Text = "&Record";
            // 
            // modifyButtn
            // 
            this.modifyButtn.Name = "modifyButtn";
            this.modifyButtn.Size = new System.Drawing.Size(180, 22);
            this.modifyButtn.Text = "&Modify";
            // 
            // removeButtn
            // 
            this.removeButtn.Name = "removeButtn";
            this.removeButtn.Size = new System.Drawing.Size(180, 22);
            this.removeButtn.Text = "&Remove";
            // 
            // reportButtn
            // 
            this.reportButtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countAssigneeItem,
            this.listAssigneeItem,
            this.countArtifactItem,
            this.listArtifactItem,
            this.CountDateItem,
            this.listDateItem,
            this.trendDateItem});
            this.reportButtn.Name = "reportButtn";
            this.reportButtn.Size = new System.Drawing.Size(180, 22);
            this.reportButtn.Text = "&Report";
            // 
            // countAssigneeItem
            // 
            this.countAssigneeItem.Name = "countAssigneeItem";
            this.countAssigneeItem.Size = new System.Drawing.Size(186, 22);
            this.countAssigneeItem.Text = "Count by Assignee";
            // 
            // listAssigneeItem
            // 
            this.listAssigneeItem.Name = "listAssigneeItem";
            this.listAssigneeItem.Size = new System.Drawing.Size(186, 22);
            this.listAssigneeItem.Text = "List By Assignee";
            // 
            // countArtifactItem
            // 
            this.countArtifactItem.Name = "countArtifactItem";
            this.countArtifactItem.Size = new System.Drawing.Size(186, 22);
            this.countArtifactItem.Text = "Count by Artifact";
            // 
            // listArtifactItem
            // 
            this.listArtifactItem.Name = "listArtifactItem";
            this.listArtifactItem.Size = new System.Drawing.Size(186, 22);
            this.listArtifactItem.Text = "List by Artifact";
            // 
            // CountDateItem
            // 
            this.CountDateItem.Name = "CountDateItem";
            this.CountDateItem.Size = new System.Drawing.Size(186, 22);
            this.CountDateItem.Text = "Count by Date Range";
            // 
            // listDateItem
            // 
            this.listDateItem.Name = "listDateItem";
            this.listDateItem.Size = new System.Drawing.Size(186, 22);
            this.listDateItem.Text = "List by Date Range";
            // 
            // trendDateItem
            // 
            this.trendDateItem.Name = "trendDateItem";
            this.trendDateItem.Size = new System.Drawing.Size(186, 22);
            this.trendDateItem.Text = "Trend by Date Range";
            // 
            // requirementMenu
            // 
            this.requirementMenu.Name = "requirementMenu";
            this.requirementMenu.Size = new System.Drawing.Size(87, 23);
            this.requirementMenu.Text = "&Requirement";
            // 
            // designMenu
            // 
            this.designMenu.Name = "designMenu";
            this.designMenu.Size = new System.Drawing.Size(55, 23);
            this.designMenu.Text = "&Design";
            // 
            // testMenu
            // 
            this.testMenu.Name = "testMenu";
            this.testMenu.Size = new System.Drawing.Size(39, 23);
            this.testMenu.Text = "&Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 862);
            this.Controls.Add(this.loginMenu);
            this.MainMenuStrip = this.loginMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem countAssigneeItem;
        private System.Windows.Forms.ToolStripMenuItem listAssigneeItem;
        private System.Windows.Forms.ToolStripMenuItem countArtifactItem;
        private System.Windows.Forms.ToolStripMenuItem listArtifactItem;
        private System.Windows.Forms.ToolStripMenuItem CountDateItem;
        private System.Windows.Forms.ToolStripMenuItem listDateItem;
        private System.Windows.Forms.ToolStripMenuItem trendDateItem;
    }
}