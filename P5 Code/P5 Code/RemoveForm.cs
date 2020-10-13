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
    public partial class Removeform : Form
    {
        public static int useid;
        public Removeform()
        {
            InitializeComponent();

        }
        public Removeform(string name, int id)
        {
            InitializeComponent();
            CenterToScreen();
            this.confirmbox.Text = "Project to remove:    ";
            this.confirmbox.Text = this.confirmbox.Text + name;
            useid = id;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to permanetly remove this project", "Attention", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string result = FakeProjectRepository.Removeproj(useid);
                this.Close();
            }
            if (res == DialogResult.No)
                this.Close();
        }
    }
}
