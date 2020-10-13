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
        public static string newTitle = "Main";
        public static string patternstr = "Main";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "Main";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ShowProject showProject = new ShowProject();
            this.Hide();
            showProject.ShowDialog();
            if(newTitle != "Main")
            {
                this.Text = patternstr;
                this.Text = this.Text + " - " + newTitle;
            }
            else
            {
                this.Text = patternstr;
            }
            this.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

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
