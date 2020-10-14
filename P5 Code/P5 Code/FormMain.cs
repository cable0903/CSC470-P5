using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormMain : Form
    {
        public static string newTitle = "Main";
        public static string mainTitle = "Main";
        
        public FormMain()
        {
            InitializeComponent();
            if(newTitle != mainTitle)
            {
                this.Text = mainTitle + " - " +  newTitle;
            }
            else
            {
                this.Text = mainTitle;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ShowProject showProject = new ShowProject();
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            createProject.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveList removeProject = new RemoveList();
            this.Hide();
            removeProject.ShowDialog();
            this.Show();
        }
    }
    
}
