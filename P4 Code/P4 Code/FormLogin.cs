using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Code
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FormMain FormMain = new FormMain();
            AppUser user = new AppUser();
            user.IsAuthenticated = false;
            while (user.IsAuthenticated == false && FormMain.ShowDialog(this) == DialogResult.OK)
            {
                user = FormMain.LoginUser;
            }
            if (FormMain.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                Text = "Must select a project";
            }
        }
    }
    
}
