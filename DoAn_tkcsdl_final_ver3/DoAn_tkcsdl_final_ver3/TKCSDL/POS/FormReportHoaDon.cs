using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace POS
{
    public partial class FormReportHoaDon : Form
    {
        public FormReportHoaDon()
        {
          
            InitializeComponent();
        }

        private void FormReportHoaDon_Load(object sender, EventArgs e)
        {

            ReportDataSource a = new ReportDataSource("DataSetCTHD", CTHDInfo());
            ReportDataSource b = new ReportDataSource("DataSetHOADON", HoaDonInfo());
            ReportDataSource c = new ReportDataSource("DataSetNHANVIEN", NhanVienInfo());
            
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hoabu\OneDrive\Máy tính\DoAn_tkcsdl_final_ver3\DoAn_tkcsdl_final_ver3\DoAn_tkcsdl_final_ver3\TKCSDL\POS\HoaDonReport.rdlc";


            reportViewer1.LocalReport.DataSources.Add(a);
            reportViewer1.LocalReport.DataSources.Add(b);
            reportViewer1.LocalReport.DataSources.Add(c);
           
            reportViewer1.RefreshReport();
        }
        private DataTable CTHDInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from CTHD", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable HoaDonInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True");
            con.Open();
            //  SqlCommand cmd = new SqlCommand("select *from HOADON", con);
            SqlCommand cmd = new SqlCommand("select b.IDNhanVien ,a.MaHD, b.NgayHD, b.TongTien,b.Discount from CTHD as a, HOADON as b where a.MaHD = b.MaHD ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable NhanVienInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select hd.IDNhanVien,nv.HoTenNV,hd.MaHD, NgayHD,hd.Discount,hd.TongTien  from NhanVien as nv, HOADON as hd Where nv.IDNhanVien = hd.IDNhanVien", con);
            //  SqlCommand cmd = new SqlCommand("select  a.HoTenNV from NhanVien as a, HOADON as b where a.IDNhanVien = b.IDNhanVien ", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
