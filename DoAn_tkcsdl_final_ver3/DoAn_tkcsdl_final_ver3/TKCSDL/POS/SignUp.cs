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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        void loadData()
        {
            DataTable table = DAL.dangki_nhanvien.Instance.loadDataNV();
            
            dgvNV.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
        private void txtGmail_LostFocus(object sender, EventArgs e)
        {
            string str = txtGmail.Text;
            showMatch(str, @"\bgmail.com\S*");
        }


        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtGmail.Text = "";
            cmbQuyenHan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string str = txtGmail.Text;
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGmail.Text == "")
            {
                MessageBox.Show("không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            try
            {
                //txtLuongNV.Text = DAL.QuanLyNhanVien.Instance.changeFormat(txtLuongNV.Text);
                //TxtsellPrice.Text = DAL.QuanLyNhanVien.Instance.changeFormat(TxtsellPrice.Text);
                int result = DAL.dangki_nhanvien.Instance.addNewNV(txtUser.Text, txtPass.Text, txtGmail.Text, cmbQuyenHan.Text);

                if (result > 0) MessageBox.Show("Thêm tài khoản thành Công!!");
                else Console.WriteLine("Thêm tài khoản không thành công!!");
                loadData();
                txtUser.Text = "";
                txtPass.Text = "";
                txtGmail.Text = "";
                cmbQuyenHan.Text = "";

            }
            catch (Exception) { MessageBox.Show("Username đã tồn tại"); }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = DAL.dangki_nhanvien.Instance.updateNV(txtPass.Text, txtGmail.Text, cmbQuyenHan.Text, txtUser.Text);
            loadData();
            txtUser.Text = "";
            txtPass.Text = "";
            txtGmail.Text = "";
            cmbQuyenHan.Text = "";
            if (result == true) MessageBox.Show("Cập nhật tài khoản thành công");
            else MessageBox.Show("Cập nhật tài khoản thất bại!!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = DAL.dangki_nhanvien.Instance.deleteNV(txtUser.Text);
            if (result) MessageBox.Show("Xóa tài khoản thành công!!");
            else Console.WriteLine("Xóa tài khoản thất bại!!");
            loadData();
            txtUser.Text = "";
            txtPass.Text = "";
            txtGmail.Text = "";
            cmbQuyenHan.Text = "";
        }

        private void dgvNV_MouseClick(object sender, MouseEventArgs e)
        {
            txtGmail.Text = dgvNV.SelectedRows[0].Cells[1].Value.ToString();
            cmbQuyenHan.Text = dgvNV.SelectedRows[0].Cells[4].Value.ToString();
            txtUser.Text = dgvNV.SelectedRows[0].Cells[2].Value.ToString();
            txtPass.Text = dgvNV.SelectedRows[0].Cells[3].Value.ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // them lua chon cho quyen han
            cmbQuyenHan.Items.Add("");
            cmbQuyenHan.Items.Add("admin");
            cmbQuyenHan.Items.Add("Nhân Viên");
            cmbQuyenHan.Text = cmbQuyenHan.Items[0].ToString();

            txt_Title.Location = new Point(485, 12);
            groupBox1.Size = new Size(1000, 300);
            dgvNV.Size = new Size(1000,300);
            txtPass.Size = new Size(217, 35);
            txtUser.Size = new Size(217, 35);
            txtGmail.Size = new Size(217, 35);
            cmbQuyenHan.Size = new Size(217, 25);   
            txtUser.Location = new Point(683, 39);
            lb_user.Location = new Point(600, 50);
            txtGmail.Location = new Point(201, 39);
            lb_gmail.Location = new Point(120, 50);
            cmbQuyenHan.Location = new Point(201, 106);
            lb_quyen.Location = new Point(120, 114);
            txtPass.Location = new Point(683, 106);
            lb_pass.Location = new Point(600, 118);
            dgvNV.Location = new Point(53, 334);
            btnKhoiTao.Location = new Point(311, 240);
            btnThem.Location = new Point(451, 240);
            btnCapNhat.Location = new Point(591, 240);
            btnXoa.Location = new Point(731, 240);

            //ktr textbox gmail
            
            txtGmail.LostFocus += new EventHandler(this.txtGmail_LostFocus);

            loadData();
        }
    }
}
