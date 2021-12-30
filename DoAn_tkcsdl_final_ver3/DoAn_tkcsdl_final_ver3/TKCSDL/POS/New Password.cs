using POS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class New_Password : Form
    {
        int i=0;
        Connection con = new Connection();
        public New_Password()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                tb_pass.UseSystemPasswordChar = true;
                tb_comfirmPass.UseSystemPasswordChar = true;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = false;
                tb_comfirmPass.UseSystemPasswordChar = false;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(tb_pass.Text != tb_comfirmPass.Text)
            {
                MessageBox.Show(" Confirm password không trùng với password");
            }
            else
            {
                string pass = DAL.mahoa.mahoaMK(tb_pass.Text);
                con.OpenConn();
                SqlCommand cmd = new SqlCommand("Update login set pass=@pass where username = @username ", con.Conn);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar);
                cmd.Parameters["@username"].Value = tb_user.Text;
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void New_Password_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
