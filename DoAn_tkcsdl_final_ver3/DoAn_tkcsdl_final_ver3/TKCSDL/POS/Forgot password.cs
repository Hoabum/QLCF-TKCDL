using POS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Forgot_password : Form
    {
        Connection con = new Connection();
        public Forgot_password()
        {
            InitializeComponent();
        }
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
   
        public string GeneratePassword()
        {
            char[] password = new char[6];
            string charSet = "";
            Random random = new Random();
            int counter;
             charSet += LOWER_CASE;
            charSet += UPPER_CASE;
            charSet += NUMBERS;

            for (counter = 0; counter < 6; counter++)
            {
                password[counter] = charSet[random.Next(charSet.Length - 1)];
            }
            // chuyển mảng thành chuỗi
            return string.Join(null, password); // trả về chuỗi
        }
        public void updatePass(string pass, string username)
        {
            
                con.OpenConn();
                SqlCommand cmd = new SqlCommand("Update login set pass=@pass where username = @username ", con.Conn);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
            
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var passwordRandom = GeneratePassword();
            DataTable dt = new DataTable();
            dt = con.GetData("select * from login WHERE gmail = '" + tb_gmail.Text + "' and username='" + tb_user.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mật khẩu mới của bạn là :"+passwordRandom);
                string pass = DAL.mahoa.mahoaMK(passwordRandom);
                updatePass(pass,tb_user.Text);
            }
            else
            {
                MessageBox.Show("Sai gmail hoặc mật khẩu");
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
            string str = tb_gmail.Text;
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
        private void Forgot_password_Load(object sender, EventArgs e)
        {
            tb_gmail.LostFocus += new EventHandler(this.txtGmail_LostFocus);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
