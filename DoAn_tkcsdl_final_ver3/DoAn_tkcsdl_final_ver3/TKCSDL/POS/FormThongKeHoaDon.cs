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
    public partial class FormThongKeHoaDon : Form
    {
        public FormThongKeHoaDon()
        {
            InitializeComponent();
            loadDatePicker();
            loadData();
        }
        private void loadDatePicker()
        {
            DateTime today = DateTime.Now;
            ngayBD.Value = new DateTime(today.Year, today.Month, 1);
            toDate.Value = ngayBD.Value.AddMonths(1).AddDays(-1);
        }
        void loadData()
        {
            dgvThongKe.DataSource = DAL.ThongKe.instance.getListHD();


        }
        private void loadDataTkHD()
        {
            string query = "EXEC USP_TKHDQLCF @ngaybd , @ngaykt";
            DataTable dt = new DataTable();
         //   dt = DAL.dataProvider.instance.executeQuery();
            dt = DAL.dataProvider.instance.excuteQuery(query, new object[] { ngayBD.Value, toDate.Value });
            dgvThongKe.DataSource = dt;
        }
        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDataTkHD();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
           /* txt_title_thongke.Location = new Point(485, 60);
            dgvThongKe.Location = new Point(130, 260);
            dgvThongKe.Size = new Size(979, 250);
            grb_thongtin.Location = new Point(330, 126);*/
          
;        }

        private void lbl_tongtien_Click(object sender, EventArgs e)
        {

        }

        private void grb_thongtin_Enter(object sender, EventArgs e)
        {

        }
    }
}
