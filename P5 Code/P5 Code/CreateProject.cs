using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class CreateProject : Form
    {
        string newProjectName;
        public CreateProject()
        {
            InitializeComponent();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FakeProjectRepository newproject = new FakeProjectRepository();

        }

        private void projectNameText_TextChanged(object sender, EventArgs e)
        {
            newProjectName = projectNameText.Text;
            newProjectName = newProjectName.Trim();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(projectNameText.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Project name is empty or blank.");
                return;
            }
        }
    }
}
