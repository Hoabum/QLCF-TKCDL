using POS.BLL;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using POS.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace POS
{
    public partial class Kho : Form
    {
        Connection con = new Connection();
        public Kho()
        {
            InitializeComponent();
        }

        void loadData()
        {
            DataTable table = DAL.KhoDAL.Instance.loadDataNV();
            //  command = connection.CreateCommand();  // xu ly ket noi
            //   command.CommandText = "select *from NhanVien";
            //   adapter.SelectCommand = command;
            //   table.Clear();
            //   adapter.Fill(table);
            dgvkho.DataSource = table;
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            cb_loai.Items.Add("");
            cb_loai.Items.Add("1");
            cb_loai.Items.Add("2");
            cb_loai.Items.Add("3");
            cb_loai.Items.Add("4");
            cb_loai.Text = cb_loai.Items[0].ToString();

            tb_idmon.Enabled = false;
            tb_anh.Enabled = false;
            tb_idloai.Enabled = false;
            id();
            loadData();

            tb_idmon.Enabled = false;
            txt_Title.Location = new Point(485, 12);
            dgvkho.Location = new Point(130, 394);
            dgvkho.Size = new Size(979, 196);
            groupBox1.Location = new Point(550, 70);
            pictureBox1.Location = new Point(250, 97);
            lbl_Sp.Location = new Point(320, 330);

        }
        private void id()
        {
            con.OpenConn();
            string mahd = "select idMon from kho WHERE idMon = (SELECT max(idMon) FROM kho)";
            SqlCommand cmd = new SqlCommand(mahd, con.Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            int result;
            if (dt.Rows.Count > 0)
            {
                string a = cmd.ExecuteScalar().ToString();

                result = int.Parse(a);
                result++;
                tb_idmon.Text = result.ToString();
            }
            else
            {
                result =0;
                result++;
                tb_idmon.Text = result.ToString();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogi = new OpenFileDialog();
            openFileDialogi.Filter = openFileDialogi.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            openFileDialogi.FilterIndex = 1;
            openFileDialogi.RestoreDirectory = true;
            if (openFileDialogi.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialogi.FileName;
                tb_anh.Text = openFileDialogi.FileName;

            }
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {


            

            ClassBLL objbll = new ClassBLL();
            if(objbll.SaveItemsKho(pictureBox1.Image,tb_ten.Text,int.Parse(tb_gia.Text),cb_loai.Text))
            {
                MessageBox.Show("Success!"); //function returns true : record saved sucessfully.
                id();
                loadData();
                tb_gia.Text = "";
                tb_idloai.Text = "";
                tb_ten.Text = "";
                tb_anh.Text = "";
                cb_loai.Text = cb_loai.Items[0].ToString();
            }
            else
            {
                MessageBox.Show("Failed!"); //function returns false : Failed to save record.
            }
        }
        private byte[] convertToBytes()
        {
            FileStream fs;
            fs = new FileStream(tb_anh.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void cb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void tb_idloai_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void update()
        {
            con.OpenConn();
            SqlCommand cmd = new SqlCommand("UPDATE kho SET anh=@anh,ten=@ten,giamon=@giamon,idloai=@idloai WHERE idMon='" + tb_idmon.Text + "' ", con.Conn);
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] anh = stream.ToArray();
            cmd.Parameters.AddWithValue("@anh", anh);
            cmd.Parameters.AddWithValue("@ten", tb_ten.Text);
            cmd.Parameters.AddWithValue("@giamon", tb_gia.Text);
            cmd.Parameters.AddWithValue("@idloai", cb_loai.Text);
            cmd.ExecuteNonQuery();
            con.CloseConn();
            MessageBox.Show("cap nhat thanh cong");
            id();
            loadData();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            update();
            tb_gia.Text = "";
            tb_idloai.Text = "";
            tb_ten.Text = "";
            tb_anh.Text = "";
            cb_loai.Text = cb_loai.Items[0].ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ten.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = DAL.KhoDAL.Instance.deleteNV(tb_idmon.Text);
            if (result) MessageBox.Show("Xóa tài khoản thành công!!");
            else Console.WriteLine("Xóa tài khoản thất bại!!");
            loadData();
            id();
            tb_gia.Text = "";
            tb_idloai.Text = "";
            tb_ten.Text = "";
            tb_anh.Text = "";
            cb_loai.Text = cb_loai.Items[0].ToString();
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            
            tb_gia.Text = "";
            tb_idloai.Text = "";
            tb_ten.Text = "";
            tb_anh.Text = "";
            cb_loai.Text = cb_loai.Items[0].ToString();
            id();
        }

        private void dgvkho_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                tb_idmon.Text = dgvkho.SelectedRows[0].Cells[1].Value.ToString();
                cb_loai.Text = dgvkho.SelectedRows[0].Cells[2].Value.ToString();
                tb_idloai.Text = dgvkho.SelectedRows[0].Cells[3].Value.ToString();
                tb_ten.Text = dgvkho.SelectedRows[0].Cells[4].Value.ToString();
                tb_gia.Text = dgvkho.SelectedRows[0].Cells[5].Value.ToString();

                Byte[] image = Encoding.ASCII.GetBytes(dgvkho.SelectedRows[0].Cells[6].Value.ToString());
                if (image == null)
                {
                    pictureBox1.Image = null;

                }

                else
                {

                    var DATA = (Byte[])(dgvkho.SelectedRows[0].Cells[6].Value);
                    var stream = new MemoryStream(DATA);
                    pictureBox1.Image = Image.FromStream(stream);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_loai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_loai.SelectedItem == "1")
            {
                tb_idloai.Text = "Trà sữa";
            }
            else if (cb_loai.SelectedItem == "2")
            {
                tb_idloai.Text = "Nước ngọt";
            }
            else if (cb_loai.SelectedItem == "3")
            {
                tb_idloai.Text = "Cafe";
            }
            else if (cb_loai.SelectedItem == "4")
            {
                tb_idloai.Text = "Đồ ăn";
            }
        }
    }
}
