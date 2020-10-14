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
    public partial class RemoveList : Form
    {
        public RemoveList()
        {
            InitializeComponent();
            FormLogin_Load();
        }
        public void FormLogin_Load()
        {
            CenterToScreen();
            FakeProjectRepository newproject = new FakeProjectRepository();
            listBox1.ClearSelected();
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
            this.Close();
        }

        private void buttSelect_Click(object sender, EventArgs e)
        {
            Removeform removeProject = new Removeform(listBox1.SelectedItem.ToString(), listBox1.SelectedIndex);
            this.Hide();
            removeProject.ShowDialog();
            this.Close();
        }
    }
}
