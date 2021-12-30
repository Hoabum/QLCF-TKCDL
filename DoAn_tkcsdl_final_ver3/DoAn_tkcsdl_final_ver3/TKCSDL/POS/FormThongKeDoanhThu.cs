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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
            loadDatePicker();
            fillChartTheoNgay();
            fillChartTheoQuy();
            fillChartTheoNam();
            fillChartTheoThang();
        }
        private void loadDatePicker()
        {
            DateTime today = DateTime.Now;
            ngayBD.Value = new DateTime(today.Year, today.Month, 1);
            toDate.Value = ngayBD.Value.AddMonths(1).AddDays(-1);
        }

        private void fillChartTheoNgay()
        {
            chartThongKe.Titles.Clear();
            string query = "EXEC USP_ThongKeTheoNgayQLCF @ngaybd , @ngaykt";
            // DataTable data = dataProvider.instance.executeQuery(query, new object[] { ngayBD.Value, toDate.Value });
            DataTable data = DAL.dataProvider.instance.excuteQuery(query, new object[] { ngayBD.Value, toDate.Value });
            chartThongKe.DataSource = data;
            chartThongKe.Series["Doanh Thu"].XValueMember = "NGAY";
            chartThongKe.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chartThongKe.Titles.Add("BIỂU ĐỒ DOANH THU THEO NGÀY");

        }
        private void fillChartTheoQuy()
        {
            chartThongKe.Titles.Clear();
            string query = "exec USP_ThongKeTheoQuyQLCF @nam = 2021";
            // DataTable data = dataProvider.instance.executeQuery(query, new object[] { ngayBD.Value, toDate.Value });
            DataTable data = DAL.dataProvider.instance.excuteQuery(query);
            chartThongKe.DataSource = data;
            chartThongKe.Series["Doanh Thu"].XValueMember = "QUY";
            chartThongKe.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chartThongKe.Titles.Add("BIỂU ĐỒ DOANH THU THEO QUÝ");

        }
        private void fillChartTheoNam()
        {
            chartThongKe.Titles.Clear();
            string query = "SELECT SUM(HOADON.TongTien) AS 'TONGTIEN', year (HOADON.NgayHD) AS 'NAM' FROM HOADON GROUP BY year(HOADON.NgayHD)";
            // DataTable data = dataProvider.instance.executeQuery(query, new object[] { ngayBD.Value, toDate.Value });
            DataTable data = DAL.dataProvider.instance.excuteQuery(query);
            chartThongKe.DataSource = data;
            chartThongKe.Series["Doanh Thu"].XValueMember = "NAM";
            chartThongKe.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chartThongKe.Titles.Add("BIỂU ĐỒ DOANH THU THEO NĂM");

        }
        private void fillChartTheoThang()
        {
            chartThongKe.Titles.Clear();
            string query = "exec USP_ThongKeTheoThangQLCF @nam =2021";

            //DataTable data = DAL.dataProvider.instance.excuteQuery(query, new object[] {float.Parse(cmbNam.Text) });
            DataTable data = DAL.dataProvider.instance.excuteQuery(query);
            chartThongKe.DataSource = data;
            chartThongKe.DataSource = data;
            chartThongKe.Series["Doanh Thu"].XValueMember = "THANG";
            chartThongKe.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chartThongKe.Titles.Add("BIỂU ĐỒ DOANH THU THEO THÁNG");

        }
        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            txt_title_thongkeDoanhThu.Location = new Point(445, 60);
            txt_title_thongkeDoanhThu.Size = new Size(311, 39);
          chartThongKe.Location = new Point(36, 46);
           chartThongKe.Size = new Size(750, 300);
             grb_thongtinBieuDo.Location = new Point(72, 267);
            grb_thongtin.Location = new Point(230, 129);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            fillChartTheoNgay();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioBtnThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnThang.Checked)
            {
                fillChartTheoThang();
            }
        }

        private void radioBtnQuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnQuy.Checked)
            {
                fillChartTheoQuy();
            }
        }

        private void radioBtnNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNam.Checked)
            {
                fillChartTheoNam();
            }
        }
    }
}
