using POS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{

    public partial class Login : Form
    {
        int i = 0;
        Connection con = new Connection();
        public Login()
        {
            InitializeComponent();
        }
        
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                tb_pass.UseSystemPasswordChar = true;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = false;
            }
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string result = mahoa.mahoaMK(tb_pass.Text);
            dt = con.GetData("select * from login WHERE username = '" + tb_user.Text + "' and pass='" + result + "'");
            if(dt.Rows.Count>0)
            {
                Home home = new Home(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ");
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
           
        }

        private void lb_forgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_password qmk = new Forgot_password();
            qmk.ShowDialog();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password();
            this.Hide();
            change_Password.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
