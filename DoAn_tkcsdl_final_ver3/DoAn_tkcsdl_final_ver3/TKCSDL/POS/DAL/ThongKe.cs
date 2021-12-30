using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace POS.DAL
{
    class ThongKe
    {
        private static ThongKe obj;
        public static ThongKe instance
        {
            get { if (obj == null) obj = new ThongKe(); return obj; }
            set { obj = value; }
        }

        public DataTable getListHD()
        {

            DataTable constain = new DataTable();
            string query = "select HOADON.MaHD AS 'Mã Hóa Đơn', HOADON.NgayHD AS 'Ngày Tạo',  NhanVien.HoTenNV AS 'Người Tạo',HOADON.TongTien AS 'Tổng Tiền'  from HOADON,NhanVien where NhanVien.IDNhanVien = HOADON.IDNhanVien";
            //     return DAL.ThongKe.Instance.ExecuteQuery(query);
            constain = dataProvider.instance.excuteQuery(query);
            constain.Columns.Add("STT");
            constain.Columns[4].SetOrdinal(0);
            constain.Columns[1].ColumnName = "Mã Hóa Đơn";
            constain.Columns[2].ColumnName = "Ngày Tạo";
            constain.Columns[3].ColumnName = "Người Tạo";
            constain.Columns[4].ColumnName = "Tổng Tiền";

            int i = 1;
            foreach (DataRow item in constain.Rows)
            {

                item[0] = i;
                i++;
            }
            return constain;

        }
    }
}
