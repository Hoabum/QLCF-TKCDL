using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using POS.BLL;
using POS.DAL;
using POS.Properties;

namespace POS
{
    public partial class Home : Form
    {
        string gmail ="", username ="", pass ="", quyen ="";
        string ad = "admin";
        string nv = "Nhân Viên";
        
        Connection con = new Connection();
        private Form currentChildForm;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pn_body.Controls.Add(ChildForm);
            pn_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Width = 1598;
            ChildForm.Height = 660;
            gunaVScrollBar1.Visible = false;
            ChildForm.Show();

        }
        public Home()
        {
            InitializeComponent();
        }

        public Home(string gmail, string username, string pass, string quyen)
        {

            InitializeComponent();
            this.gmail = gmail;
            this.username = username;
            this.pass = pass;
            this.quyen = quyen;

        }


        public void hd(string title, string price)
        {
            UserControl2 user = new UserControl2();
            user.Title = title;
            user.Price = price;
            lb_tongtien.Text = user.Price.ToString();
            MessageBox.Show(user.Title, user.Price);
            pn_hoadon.Controls.Add(user);
        }


        private void creatControl1()
        {
            pn_menu.Controls.Clear();
           
            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetItems1();
            if (dt != null) // ktr dt có rỗng k  
            {
               
                if (dt.Rows.Count > 0)// có du lieu
                {
                     
                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for(int i=0;i<1;i++)
                    {
                        foreach(DataRow row in dt.Rows) // duyet từng row của dt
                        {
                            listItems[i] = new UserControl1();
                            MemoryStream ms = new MemoryStream((byte[])row["anh"]);
                            listItems[i].Img = new Bitmap(ms);

                            //get title vs price
                            listItems[i].Title = row["ten"].ToString();
                            listItems[i].Price = row["giamon"].ToString();
                            pn_menu.Controls.Add(listItems[i]);
                            listItems[i].Click += control_Click;
                        }    
                    }
                    
                    
                }
            }
        }
      
        public void control_Click(object sender, EventArgs e)
        {
            UserControl1 control1 = sender as UserControl1;
            UserControl2 control2 = new UserControl2();
            control2.Title = control1.Title;
            control2.Price = control1.Price;
            foreach (var item in pn_hoadon.Controls)
            {
                var wdg = (UserControl2)item;
               if(control1.Title == wdg.Title)
                {
                    
                    wdg.Soluong = 1.ToString();
                    var a = wdg.lb_soluong.Value;
                    wdg.Price =  ((a)*int.Parse(control2.Price)).ToString();
                    tintongtien();
                    return;
                }    
            }
            
            pn_hoadon.Controls.Add(control2);
            control2.btn_delete.Click += control_Click_remove;
            tintongtien();

            //hoặc button.Content
        }
        //remove usercontrol 2
        public void control_Click_remove(object sender, EventArgs e)
        {
            string a = UserControl2.Tensp;



            foreach (var item in pn_hoadon.Controls)
            {
                var wdg = (UserControl2)item;

                if (a == wdg.Title)
                {
                    pn_hoadon.Controls.Remove(wdg);
                    lb_tongtien.Text = (int.Parse(lb_tongtien.Text) - int.Parse(wdg.Price)).ToString();
                }


            }

        }
        public void tintongtien()
        {
            int tong = 0;
            foreach (var item in pn_hoadon.Controls)
            {
                var wdg = (UserControl2)item;
                tong += int.Parse( wdg.Price);
            }
                lb_tongtien.Text = tong.ToString();
            
            
        }
        private void creatControl2()
        {
            pn_menu.Controls.Clear();

            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetItems2();
            if (dt != null) // ktr dt có rỗng k  
            {

                if (dt.Rows.Count > 0)// có du lieu
                {

                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows) // duyet từng row của dt
                        {
                            listItems[i] = new UserControl1();
                            MemoryStream ms = new MemoryStream((byte[])row["anh"]);
                            listItems[i].Img = new Bitmap(ms);

                            //get title vs price
                            listItems[i].Title = row["ten"].ToString();
                            listItems[i].Price = row["giamon"].ToString();
                            pn_menu.Controls.Add(listItems[i]);
                            listItems[i].Click += control_Click;

                        }
                    }
                 

                }
            }
        }
        
        private void creatControl3()
        {
            pn_menu.Controls.Clear();

            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetItems3();
            if (dt != null) // ktr dt có rỗng k  
            {

                if (dt.Rows.Count > 0)// có du lieu
                {

                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows) // duyet từng row của dt
                        {
                            listItems[i] = new UserControl1();
                            MemoryStream ms = new MemoryStream((byte[])row["anh"]);
                            listItems[i].Img = new Bitmap(ms);

                            //get title vs price
                            listItems[i].Title = row["ten"].ToString();
                            listItems[i].Price = row["giamon"].ToString();
                            pn_menu.Controls.Add(listItems[i]);
                            listItems[i].Click += control_Click;

                        }
                    }

                }
            }
        }
        private void creatControl4()
        {
            pn_menu.Controls.Clear();

            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetItems4();
            if (dt != null) // ktr dt có rỗng k  
            {

                if (dt.Rows.Count > 0)// có du lieu
                {

                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows) // duyet từng row của dt
                        {
                            listItems[i] = new UserControl1();
                            MemoryStream ms = new MemoryStream((byte[])row["anh"]);
                            listItems[i].Img = new Bitmap(ms);

                            //get title vs price
                            listItems[i].Title = row["ten"].ToString();
                            listItems[i].Price = row["giamon"].ToString();
                            pn_menu.Controls.Add(listItems[i]);
                            listItems[i].Click += control_Click;

                        }
                    }

                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper fh = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pn_menu, gunaVScrollBar1, true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper f = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pn_hoadon, scrollbar_hoadon, true);
            gunaLabel_date.Text = DateTime.Now.ToShortDateString();
            this.WindowState = FormWindowState.Maximized;
            pn_name.Location = new Point(1082, 31);
            pn_iconname.Location = new Point(1242, 41);
            btn_history.Location = new Point(1120,10);
            btn_pay.Location = new Point(900, 10);
            btn_place.Location = new Point(1000, 10);
            pn_newOrder.Location = new Point(900,63);
            pn_thanhtoan.Location = new Point(900, 440);    
            pn_hoadon.Location = new Point(900,149);
            pn_menu.Size = new Size(800, 610);
            gunaVScrollBar1.Location = new Point(709, 67);
            guna2ControlBox1.Location = new Point(1482, 8);
            guna2ControlBox2.Location = new Point(1442, 8);
            creatControl1();
            if (pn_menu.Controls.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }
            LbQuyen();
           
            


        }
       
      
        public void LbQuyen()
        {
            if(quyen == ad)
            {
                lb_quyen.Text = ("Admin đẹp trai");
            }
            else
            {
                lb_quyen.Text = ("Nhân Viên");
            }
           
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TS_click(object sender, EventArgs e)
        {
            creatControl1();
            if (pn_menu.Controls.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }
            lb_Mon.Text = "Trà sữa ";
               

        }
     


        private void pn_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private Image byteArrToImage(byte[] byteimg)
        {
            // chuyên byte sang img
            MemoryStream ms = new MemoryStream();
            Image returnImg  =Image.FromStream(ms);
            return returnImg;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            creatControl3();
            if (pn_menu.Controls.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }
            lb_Mon.Text = "Coffee";
        }
        

        private void btn_food_Click(object sender, EventArgs e)
        {
            creatControl4();
            if (pn_menu.Controls.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }
            lb_Mon.Text = "Đồ ăn nhanh";
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            creatControl2();
            if (pn_menu.Controls.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }
            lb_Mon.Text = "Drink";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           /* search();*/
        }

        private void pn_menu_Click(object sender, EventArgs e)
        {

         


        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            foreach (var item in pn_menu.Controls)
            {
                var wdg = (UserControl1)item;
                wdg.Visible = wdg.lb_title.Text.ToLower().ToLower().Contains(tb_search.Text.Trim().ToLower());
            }
            
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_khachquenn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_khachquenn_Click(object sender, EventArgs e)
        {
            
        }
        public void kt()
        {
            if(cb_khaitruong.Checked == true && cb_khachquenn.Checked == true)
            {
                tintongtien();
                double a = int.Parse(lb_tongtien.Text) * 0.29;
                lb_tongtien.Text = (int.Parse(lb_tongtien.Text) - a).ToString();
            }
           else if(cb_khaitruong.Checked == true && cb_khachquenn.Checked == false)
            {
                tintongtien();
                double a = int.Parse(lb_tongtien.Text) * 0.10;
                lb_tongtien.Text = (int.Parse(lb_tongtien.Text) - a).ToString();
            }
            else if(cb_khaitruong.Checked == false && cb_khachquenn.Checked == true)
            {
                tintongtien();
                double a = int.Parse(lb_tongtien.Text) * 0.19;
                lb_tongtien.Text = (int.Parse(lb_tongtien.Text) - a).ToString();
            }
            else
            {
                tintongtien();
            }
        }
       
        private void cb_khaitruong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_khaitruong_Click(object sender, EventArgs e)
        {
            kt();
        }
        private void insertHD(string mhd)
        {
            string Discount;
            if (cb_khaitruong.Checked == true && cb_khachquenn.Checked == true)
            {
                Discount = 29.ToString();
            }
            else if (cb_khaitruong.Checked == true && cb_khachquenn.Checked == false)
            {
                Discount = 10.ToString();
            }
            else if (cb_khaitruong.Checked == false && cb_khachquenn.Checked == true)
            {
                Discount = 19.ToString();
            }
            else
            {
                Discount = 0.ToString();
            }
            con.OpenConn();
            string sql = "select IDNhanVien from NhanVien inner join login on NhanVien.username ='" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, con.Conn);
            string a = cmd.ExecuteScalar().ToString();
              

            string query = "Insert into HOADON(MaHD,IDNhanVien,NgayHD,TongTien,Discount)values(@MaHD,@IDNhanVien,@NgayHD,@TongTien,@Discount)";
            SqlCommand com = new SqlCommand(query, con.Conn);
            com.Parameters.AddWithValue("@MaHD", mhd);
            com.Parameters.AddWithValue("@IDNhanVien", a);
            com.Parameters.AddWithValue("@NgayHD", gunaLabel_date.Text);
            com.Parameters.AddWithValue("@TongTien", lb_tongtien.Text);
            com.Parameters.AddWithValue("@Discount", Discount);
            com.ExecuteNonQuery();
            con.CloseConn();

        }
        
        private void getIdMon()
        {
            con.OpenConn();
            
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            
        }

        private void pn_hoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
           
            if (quyen == nv)
            {
                btn_NhanVien.Enabled = false;
               
                MessageBox.Show("bạn không có quyên đăng nhập");
            }
            else
            {
                
                OpenChildForm(new NV());
                pn_LoaiMon.Visible = false;
            }
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Kho());
            pn_LoaiMon.Visible = false;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            
            if (quyen == nv)
            {
                btn_SignUp.Enabled = false;
               
                MessageBox.Show("bạn không có quyên đăng nhập");
            }
            else
            {
                OpenChildForm(new SignUp());
                pn_LoaiMon.Visible = false;
            }
            
        }

        private void pn_body_Click(object sender, EventArgs e)
        {
          /*  int a = pn_body.Width;
            int b = pn_body.Height;
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());*/



        }
        private void showMenuAll(Panel menuAll)
        {
            if (menuAll.Visible == false)
            {
                hide_pnMenuAll();
                menuAll.Visible = true;
            }
            else
            {
                menuAll.Visible = false;
            }
        }
        private void hide_pnMenuAll()
        {
            if (pn_ThongKe.Visible == true)
                pn_ThongKe.Visible = false;
        }
        private void btn_Thongke_Click(object sender, EventArgs e)
        {

            showMenuAll(pn_ThongKe);
            lb_Mon.Text = "ThongKe";
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void pn_menu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            con.OpenConn();
            string mahd = "select MaHD from HOADON  WHERE MaHD = (SELECT max(MaHD) FROM HOADON)";
            SqlCommand cmd = new SqlCommand(mahd, con.Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            string Str1;
            int result;
            if (dt.Rows.Count > 0)
            {

                string a = cmd.ExecuteScalar().ToString();
                Str1 = a.Substring(2);//hd10 
                result = int.Parse(Str1); //10
                result++; //11
            }
            else
            {
                result = 0;
                result++;
            }
            string mhd = Convert.ToString(("HD" + result));

            // lưu xuống csdl
            insertHD(mhd);



            foreach (var item in pn_hoadon.Controls)
            {
                var wdg = (UserControl2)item;
                var soluong = wdg.lb_soluong.Value;
                var gia = int.Parse(wdg.Price) / soluong;
                con.OpenConn();
                string sql = "select idMon from kho where kho.ten = N'" + wdg.Title + "'";
                SqlCommand cmd1 = new SqlCommand(sql, con.Conn);
                string b = cmd1.ExecuteScalar().ToString();
                /* MessageBox.Show(b);
                 MessageBox.Show(mhd);
                 MessageBox.Show(wdg.Title);*/
                /*MessageBox.Show(gia.ToString());
                MessageBox.Show(soluong.ToString());
                MessageBox.Show(wdg.Price);*/

                string query = "Insert into CTHD(MaHD,idMon,ten,giamon,Soluong,ThanhTien) Values(@MaHD,@idMon,@ten,@giamon,@Soluong,@ThanhTien)";
                SqlCommand com = new SqlCommand(query, con.Conn);
                com.Parameters.AddWithValue("@MaHD", mhd);
                com.Parameters.AddWithValue("@idMon", b);
                com.Parameters.AddWithValue("@ten", wdg.Title);
                com.Parameters.AddWithValue("@giamon", gia.ToString());
                com.Parameters.AddWithValue("@Soluong", soluong.ToString());
                com.Parameters.AddWithValue("@ThanhTien", wdg.Price);
                com.ExecuteNonQuery();

            }

            MessageBox.Show("Đã Lưu");
        }

        private void cb_khachquenn_Click_1(object sender, EventArgs e)
        {
            kt();
        }

        private void cb_khaitruong_Click_1(object sender, EventArgs e)
        {
            kt();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_payNow_Click(object sender, EventArgs e)
        {
            FormReportHoaDon a = new FormReportHoaDon();
            a.Show();
            pn_hoadon.Controls.Clear();
            con.OpenConn();
            string query = "DELETE from CTHD";
            SqlCommand com = new SqlCommand(query, con.Conn);
            com.ExecuteNonQuery();
            lb_tongtien.Text = 0.ToString();
            

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (quyen == nv)
            {
                btn_Thongke.Enabled = false;
              
                MessageBox.Show("bạn không có quyên đăng nhập");
            }
            else
            {
                OpenChildForm(new FormThongKeDoanhThu());
                pn_LoaiMon.Visible = false;
            }
         
            
        }

        private void btnTKHoaDon_Click(object sender, EventArgs e)
        {
            if (quyen == nv)
            {
                btn_Thongke.Enabled = false;
               
                MessageBox.Show("bạn không có quyên đăng nhập");
            }
            else
            {
                OpenChildForm(new FormThongKeHoaDon());
                pn_LoaiMon.Visible = false;
            }
           // FormThongKeHoaDon b = new FormThongKeHoaDon();
          //  b.Show();
        }

        private void control_food(object sender, EventArgs e)
        {
           
            
        }

        private void userControl13_Load(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {   
            pn_LoaiMon.Visible=true;
            if(currentChildForm !=null)
            {
                currentChildForm.Close();
            }    
        }
    }
}
