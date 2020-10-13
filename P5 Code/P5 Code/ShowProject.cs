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
            listBox1.ClearSelected();
            //foreach (KeyValuePair<string, Project> pro in FakeProjectRepository.Projects)
            //listBox1.Items.Add(pro.Value);

            string arr = "0";
            foreach (KeyValuePair<string, Project> pro in FakeProjectRepository.Projects)
            {
                arr = pro.Key;
                listBox1.Items.Add(arr);
            }
            listBox1.EndUpdate();
            
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttSelect_Click(object sender, EventArgs e)
        {
            FormMain.newTitle = listBox1.SelectedItem.ToString();
            this.Close();
        }
    }
}
