using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using POS.DAL;
using System.Drawing;
using System.IO;


namespace POS.DAL
{
    class KhoDAL
    {
        private static KhoDAL obj;
        public static KhoDAL Instance
        {
            get { if (obj == null) obj = new KhoDAL(); return obj; }
            set { obj = value; }
        }
        class dataKho
        {
            private static dataKho obj;
            public static dataKho instance
            {
                get { if (obj == null) obj = new dataKho(); return dataKho.obj; }
                private set { dataKho.instance = value; }
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

        public bool updateNV(string ten, string giamon, string idloai, string idMon)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand command = new SqlCommand();
            string query = $"  UPDATE kho SET ten = N'{ten}', giamon = N'{giamon}',idloai = N'{idloai}' WHERE idMon = '{idMon}'";
            // int result = Connection.instance.excuteNonquery(query);
            int result = dataKho.instance.excuteNonquery(query);
            return result > 0;
        }
        public bool deleteNV(string idMon)
        {
            string query = $"  delete kho  WHERE idMon = '{idMon}'";
            //  int result = Connection.instance.excuteNonquery(query);
            int result = dataKho.instance.excuteNonquery(query);
            return result > 0;
        }


        public DataTable loadDataNV()
        {
            DataTable constain = new DataTable();
            string query = "select kho.idMon,kho.idloai,loai.loai,kho.ten,kho.giamon,kho.anh  from  loai, kho where kho.idloai = loai.idloai ";
            constain = dataKho.instance.excuteQuery(query);
            constain.Columns.Add("STT");
            constain.Columns[6].SetOrdinal(0);
            constain.Columns[1].ColumnName = "ID Món";
            constain.Columns[2].ColumnName = "ID Loại";
            constain.Columns[3].ColumnName = "Tên Loại";
            constain.Columns[4].ColumnName = "Tên Món";
            constain.Columns[5].ColumnName = "Giá Món";
            constain.Columns[6].ColumnName = "Ảnh";

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

