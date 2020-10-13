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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ShowProject showProject = new ShowProject();
            this.Hide();
            showProject.ShowDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            createProject.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
    
}
