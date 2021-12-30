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
    
    public partial class NV : Form
    {
        //  SqlConnection connection;
        //  SqlCommand command;
        //  string str = @"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True";
        //  SqlDataAdapter adapter = new SqlDataAdapter();
        //  DataTable table = new DataTable(); // dữ liệu được đẩy xuống table
        Connection con = new Connection();                               //  Connection con = new Connection();
        public NV()
        {
            InitializeComponent();
        }
        // int i=0;
        void loadData()
        {


            //   command = connection.CreateCommand();  // xu ly ket noi
            //   command.CommandText = "select *from NhanVien";
            //   adapter.SelectCommand = command;
            //   table.Clear();
            //   adapter.Fill(table);

            DataTable table = DAL.QuanLyNhanVien.Instance.loadDataNV();
           
            dgvNV.DataSource = table;
        }
        private void id()
        {
            con.OpenConn();
            string mahd = "select IDNhanVien from NhanVien WHERE IDNhanVien = (SELECT max(IDNhanVien) FROM NhanVien)";
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
                txtIDNV.Text = result.ToString();
            }
            else
            {
                result = 0;
                result++;
                txtIDNV.Text = result.ToString();
            }
        }

        private void NV_Load(object sender, EventArgs e)
        {
            id();
            
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Text = cmbGioiTinh.Items[0].ToString();

            cmbChucVu.Items.Add("Admin");
            cmbChucVu.Items.Add("Nhân Viên");
            cmbChucVu.Items.Add("Bảo Vệ");
            cmbChucVu.Text = cmbChucVu.Items[0].ToString();

            txtLuongNV.Items.Add("1");
            txtLuongNV.Items.Add("15000");
            txtLuongNV.Items.Add("20000");
            txtLuongNV.Text = txtLuongNV.Items[0].ToString();
             // connection = new SqlConnection(str);
             //  connection.Open();
            loadData();
            txtIDNV.Enabled = false;
            txt_Title.Location = new Point(485, 12);
            lb_MNV.Location = new Point(180, 83);
            txtIDNV.Location = new Point(280, 73);
            lb_TenNV.Location = new Point(180, 137);
            txtTNV.Location = new Point(280, 133);
            lb_SDT.Location = new Point(180, 206);
            txtSdtNV.Location = new Point(280, 198);
            lb_Chucvu.Location = new Point(180, 275);
            cmbChucVu.Location = new Point(280, 263);
            lb_GT.Location = new Point(180, 344);
            cmbGioiTinh.Location = new Point(280, 328);

            lb_Luong.Location = new Point(700, 83);
            txtLuongNV.Location = new Point(800, 78);
            Lb_NgaySinh.Location = new Point(703, 137);
            dateNV.Location = new Point(800, 136);
            lb_Ngayvaolam.Location = new Point(700, 206);
            dateNgVaoLam.Location = new Point(800, 205);
            lb_Diachi.Location = new Point(700, 275);
            txtDiaChi.Location = new Point(800, 263);
            lb_user.Location = new Point(700, 344);
            txtUserNV.Location = new Point(800, 328);

            btnKhoiTao.Location = new Point(270, 390);
            btnThem.Location = new Point(460, 390);
            btnXoa.Location = new Point(650, 390);
            btnCapNhat.Location = new Point(830, 390);
            dgvNV.Location = new Point(130, 443);
            dgvNV.Size = new Size(979, 196);
           
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {


        }
        static bool IsNumeric(string value)
        {
            try
            {
                char[] str = value.ToCharArray();
                foreach (char c in str)
                {
                    if (!char.IsNumber(c))
                        return false;
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }

      
        public void ktrSDT()
        {
            try
            {
                if(IsNumeric(txtSdtNV.Text)== true)
                {
                    string result = txtSdtNV.Text;
                    if(int.Parse(result.Substring(0, 1)) == 0 )
                    {
                       if(result.Length <= 8 || result.Length >= 12)
                        {
                            MessageBox.Show("Nhập SDT lớn hơn 8 và nhỏ hơn 12");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Số 0 đầu tiên xin vui lòng nhập lại");
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ Nhập số");
                }
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            id();
            txtTNV.Text = "";
            cmbGioiTinh.Text = "";
            dateNV.ResetText();
            txtDiaChi.Text = "";
            txtSdtNV.Text = "";
            cmbChucVu.Text = "";
            txtLuongNV.Text = "";
            dateNgVaoLam.ResetText();
            txtUserNV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text == "" || txtDiaChi.Text == "" || txtSdtNV.Text == "" || txtUserNV.Text == "" || txtTNV.Text == "")
            {
                MessageBox.Show("không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
               // txtLuongNV.Text = DAL.QuanLyNhanVien.Instance.changeFormat(txtLuongNV.Text);
                //TxtsellPrice.Text = DAL.QuanLyNhanVien.Instance.changeFormat(TxtsellPrice.Text);
                int result = DAL.QuanLyNhanVien.Instance.addNewNV( txtTNV.Text, txtDiaChi.Text, txtSdtNV.Text, cmbGioiTinh.SelectedItem.ToString(), txtLuongNV.SelectedItem.ToString(), dateNV.Value, dateNgVaoLam.Value, cmbChucVu.SelectedItem.ToString(), txtUserNV.Text);
                if (result > 0) MessageBox.Show("Thêm nhân viên thành Công!!");
                
                loadData();
                id();
                txtTNV.Text = "";
                cmbGioiTinh.Text = "";
                dateNV.ResetText();
                txtDiaChi.Text = "";
                txtSdtNV.Text = "";
                cmbChucVu.Text = "";
                txtLuongNV.Text = "";
                dateNgVaoLam.ResetText();
                txtUserNV.Text = "";


            }
            catch (Exception) { MessageBox.Show("Mã nhân viên đã tồn tại"); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = DAL.QuanLyNhanVien.Instance.deleteNV(txtIDNV.Text);
            if (result) MessageBox.Show("Xóa nhân viên thành công!!");
            else Console.WriteLine("Xóa nhân viên thất bại!!");
            loadData();
            id();
            txtTNV.Text = "";
            cmbGioiTinh.Text = "";
            dateNV.ResetText();
            txtDiaChi.Text = "";
            txtSdtNV.Text = "";
            cmbChucVu.Text = "";
            txtLuongNV.Text = "";
            dateNgVaoLam.ResetText();
            txtUserNV.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = DAL.QuanLyNhanVien.Instance.updateNV(txtTNV.Text, txtDiaChi.Text, txtSdtNV.Text, cmbGioiTinh.SelectedItem.ToString(), txtLuongNV.SelectedItem.ToString(), dateNV.Value, dateNgVaoLam.Value, cmbChucVu.SelectedItem.ToString(), txtUserNV.Text, txtIDNV.Text);
            loadData();
            id();
            txtTNV.Text = "";
            cmbGioiTinh.Text = "";
            dateNV.ResetText();
            txtDiaChi.Text = "";
            txtSdtNV.Text = "";
            cmbChucVu.Text = "";
            txtLuongNV.Text = "";
            dateNgVaoLam.ResetText();
            txtUserNV.Text = "";
            if (result == true) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại!!");
        }

        private void dgvNV_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtIDNV.Text = dgvNV.SelectedRows[0].Cells[1].Value.ToString();
            txtTNV.Text = dgvNV.SelectedRows[0].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNV.SelectedRows[0].Cells[3].Value.ToString();
            txtSdtNV.Text = dgvNV.SelectedRows[0].Cells[4].Value.ToString();
            cmbGioiTinh.Text = dgvNV.SelectedRows[0].Cells[5].Value.ToString();
            txtLuongNV.Text = dgvNV.SelectedRows[0].Cells[6].Value.ToString();
            dateNV.Text = dgvNV.SelectedRows[0].Cells[7].Value.ToString();
            dateNgVaoLam.Text = dgvNV.SelectedRows[0].Cells[8].Value.ToString();
            cmbChucVu.Text = dgvNV.SelectedRows[0].Cells[9].Value.ToString();
            txtUserNV.Text = dgvNV.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void txtSdtNV_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbChucVu_Click(object sender, EventArgs e)
        {
            ktrSDT();
        }

        private void txtTNV_Click(object sender, EventArgs e)
        {
            ktrSDT();
        }
    }
}
