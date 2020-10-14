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
        public static string newProjectName;
        public CreateProject()
        {
            InitializeComponent();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            projectNameText.Select();
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
            Project createProject = new Project();
            bool duplicate = FakeProjectRepository.isDuplicateName(newProjectName);
            createProject.Name = newProjectName;
            if (projectNameText.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Project name is empty or blank. Please enter a project name.");
                return;
            }

            if(duplicate == false)
            {
                string newProject = FakeProjectRepository.Add(createProject, FakeProjectRepository.Projects.Count()+1);
            }
            // add way to add new project to show project form
            this.Close();
        }
    }
}
