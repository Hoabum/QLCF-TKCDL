using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace POS.DAL
{
    internal class QuanLyNhanVien
    {
        private static QuanLyNhanVien obj;
        public static QuanLyNhanVien Instance
        {
            get { if (obj == null) obj = new QuanLyNhanVien(); return obj; }
            set { obj = value; }
        }
        class dataQLNV
        {
            private static dataQLNV obj;
            public static dataQLNV instance
            {
                get { if (obj == null) obj = new dataQLNV(); return dataQLNV.obj; }
                private set { dataQLNV.instance = value; }
            }
            private string str = @"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True";

            public DataTable excuteQuery(string query, object[] parameter = null)
            {
                DataTable table = new DataTable();
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    if (parameter != null)
                    {
                        string[] listpara = query.Split(' ');
                        int i = 0;

                        foreach (var item in listpara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);

                    con.Close();
                }

                return table;
            }

            public int excuteNonquery(string query, object[] parameter = null)
            {

                int data = 0;
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    if (parameter != null)
                    {
                        string[] listpara = query.Split(' ');
                        int i = 0;
                        foreach (var item in listpara)
                        {
                            if (item.Contains('@')) command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    data = command.ExecuteNonQuery();
                    con.Close();
                }
                return data;
            }
        }

        public int addNewNV(string HoTenNV, string DiaChi, string Sdt, string GioiTinh, string Luong, DateTime NgSinh, DateTime NgVaoLam, string ChucVu, string username)
        {
            string query = $"INSERT NhanVien(HoTenNV,DiaChi,Sdt,GioiTinh,Luong,NgSinh,NgVaoLam,ChucVu,username) VALUES(N'{HoTenNV}',N'{DiaChi}','{Sdt}',N'{GioiTinh}','{Luong}','{NgSinh}','{NgVaoLam}',N'{ChucVu}',N'{username}') ";
            // int result = Connection.instance.excuteNonquery(query);
            int result = dataQLNV.instance.excuteNonquery(query);
            return result;
        }
        public bool updateNV(string HoTenNV, string DiaChi, string Sdt, string GioiTinh, string Luong, DateTime NgSinh, DateTime NgVaoLam, string ChucVu, string username, string IDNhanVien)
        {
            string query = $"  UPDATE NhanVien SET HoTenNV = N'{HoTenNV}', DiaChi = N'{DiaChi}',Sdt = '{Sdt}', GioiTinh = N'{GioiTinh}',Luong ='{Luong}',NgSinh='{NgSinh}',NgVaoLam='{NgVaoLam}',ChucVu =N'{ChucVu}',username =N'{username}' WHERE IDNhanVien = '{IDNhanVien}'";
            // int result = Connection.instance.excuteNonquery(query);
            int result = dataQLNV.instance.excuteNonquery(query);
            return result > 0;
        }
        public bool deleteNV(string IDNhanVien)
        {
            string query = $"  delete NhanVien  WHERE IDNhanVien = '{IDNhanVien}'";
            //  int result = Connection.instance.excuteNonquery(query);
            int result = dataQLNV.instance.excuteNonquery(query);
            return result > 0;
        }
        public string changeFormat(string value)
        {
            value.Trim(',');
            return value;
        }
        public DataTable loadDataNV()
        {
            DataTable constain = new DataTable();
            string query = "SELECT *from NhanVien ";
            constain = dataQLNV.instance.excuteQuery(query);
            constain.Columns.Add("STT");
            constain.Columns[10].SetOrdinal(0);
            constain.Columns[1].ColumnName = "Mã Nhân Viên";
            constain.Columns[2].ColumnName = "Tên Nhân Viên";
            constain.Columns[3].ColumnName = "Địa Chỉ";
            constain.Columns[4].ColumnName = "Số Điện Thoại";
            constain.Columns[5].ColumnName = "Giới Tính";
            constain.Columns[6].ColumnName = "Lương";
            constain.Columns[7].ColumnName = "Ngày Sinh";
            constain.Columns[8].ColumnName = "Ngày Vào Làm";
            constain.Columns[9].ColumnName = "Chức Vụ";
            constain.Columns[10].ColumnName = "User Name";
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
