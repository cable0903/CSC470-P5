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
    public partial class ModifyProject : Form
    {
        public FakeProjectRepository ProjectRepository;
        public Project projectModify;
        public Project currentProject;
        public List<Project> allprojects;
        public bool isModified = false; 
        public ModifyProject(FakeProjectRepository currRepository, Project current, Project tomodify)
        {
            InitializeComponent();
            currentProject = current;
            projectModify = tomodify;
            ProjectRepository = currRepository;
            allprojects = ProjectRepository.GetAll();
        }

        private void ModifyProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBox1.Select();
            textBox1.Text = projectModify.Name;
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Project updatedProject = new Project();
            string newName = textBox1.Text;
            
            newName.Trim();
            updatedProject.ID = projectModify.ID;
            updatedProject.Name = newName;
            
            if (currentProject != projectModify)
            {
                
                string result = ProjectRepository.Modify(projectModify.ID, updatedProject);
                
                if (result == FakeProjectRepository.ERROR)
                {
                    this.DialogResult = DialogResult.OK;
                    this.isModified = true;
                    this.Close();
                }

                else
                {
                    MessageBox.Show(result, "Attention");
                    this.Close();
                }
            }
            
            else
            {
                MessageBox.Show(FakeProjectRepository.MODIFIEDPROJECTID_ERROR, "Attention");
                this.Close();
            }

        }

        private void Modify_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

