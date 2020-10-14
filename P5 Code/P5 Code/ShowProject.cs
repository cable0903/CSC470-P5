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
    public partial class ShowProject : Form
    {
        public ShowProject()
        {
            InitializeComponent();
            ShowProject_Load();
        }
        public void ShowProject_Load()
        {
            CenterToScreen();
            FakeProjectRepository newproject = new FakeProjectRepository();
            //foreach (KeyValuePair<string, Project> pro in FakeProjectRepository.Projects)
            //listBox1.Items.Add(pro.Value);
            listBox1.Items.Clear();
            string arr = "0";
            int num = 0;
            foreach (KeyValuePair<string, Project> pro in FakeProjectRepository.Projects)
            {
                arr = pro.Key;
                num = pro.Value.ID;
                listBox1.Items.Add(num + " - " + arr);
            }
            listBox1.EndUpdate();
            
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            ShowProject project = new ShowProject();
            this.Hide();
            DialogResult answer = MessageBox.Show("A project must be selected.","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(answer == DialogResult.OK)
            {
                project.ShowDialog();
                this.Close();
            }
            else if(answer == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        public void buttSelect_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser();
            var usr = user.UserName;
            //var pro = FakeProjectRepository.Projects.FirstOrDefault(y => y.Value.ID == listBox1.SelectedIndex);
            FormMain.newTitle = listBox1.SelectedItem.ToString();
            FormMain selectedProject = new FormMain();
            this.Hide();
            selectedProject.ShowDialog();

            listBox1.Items.Clear();
            string arr = "0";
            int num = 0;
            foreach (KeyValuePair<string, Project> project in FakeProjectRepository.Projects)
            {
                arr = project.Key;
                num = project.Value.ID;
                listBox1.Items.Add(num + " - " + arr);
            }
            listBox1.EndUpdate();

            this.Show();
        }
    }
}
