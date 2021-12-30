using POS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Change_Password : Form
    {
        int i = 0;
        Connection con = new Connection();
        public Change_Password()
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
           string result= mahoa.mahoaMK(tb_pass.Text);
            DataTable dt = new DataTable();
            dt = con.GetData("select * from login WHERE gmail = '"+ tb_gmaill.Text + "' and username = '" + tb_user.Text + "' and pass='" + result + "'");

            if (dt.Rows.Count > 0)
            {
                New_Password new_Password = new New_Password();
                this.Hide();
                new_Password.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai gmail,user  hoặc password");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
            
        }
        private void txtGmail_LostFocus(object sender, EventArgs e)
        {
            string str = tb_gmaill.Text;
            showMatch(str, @"\bgmail.com\S*");
        }
        private void showMatch(string text, string expr)
        {
            MatchCollection mc = Regex.Matches(text, expr);
            bool k = false;
            foreach (Match m in mc)
            {
                k = true;
            }

            if (!k)
            {
                MessageBox.Show("gmail phải có đuôi @gmail.com \n ví dụ: NguyenA123@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            tb_gmaill.LostFocus += new EventHandler(this.txtGmail_LostFocus);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            
        }
    }
}
