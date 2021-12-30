using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    class dangki_nhanvien
    {
        private static dangki_nhanvien obj;
        public static dangki_nhanvien Instance
        {
            get { if (obj == null) obj = new dangki_nhanvien(); return obj; }
            set { obj = value; }
        }
        class dataDKNV
        {
            private static dataDKNV obj;
            public static dataDKNV instance
            {
                get { if (obj == null) obj = new dataDKNV(); return dataDKNV.obj; }
                private set { dataDKNV.instance = value; }
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
        public int addNewNV(string username, string pass, string gmail, string quyen)
        {
            pass = mahoa.mahoaMK(pass);
            string query = $"INSERT login(username,pass,gmail,quyen) VALUES('{username}',N'{pass}',N'{gmail}','{quyen}') ";
            // int result = Connection.instance.excuteNonquery(query);
            int result = dataDKNV.instance.excuteNonquery(query);
            return result;
        }
        public bool updateNV(string pass, string gmail, string quyen, string username)
        {
            pass = mahoa.mahoaMK(pass);
            string query = $"  UPDATE login SET pass = N'{pass}', gmail = N'{gmail}', quyen = N'{quyen}' WHERE username = '{username}'";
            // int result = Connection.instance.excuteNonquery(query);
            int result = dataDKNV.instance.excuteNonquery(query);
            return result > 0;
        }
        public bool deleteNV(string username)
        {
            string query = $"  delete login  WHERE username = '{username}'";
            //  int result = Connection.instance.excuteNonquery(query);
            int result = dataDKNV.instance.excuteNonquery(query);
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
            string query = "SELECT *from login ";
            constain = dataDKNV.instance.excuteQuery(query);
            constain.Columns.Add("STT");
            constain.Columns[4].SetOrdinal(0);
            constain.Columns[1].ColumnName = "gmail";
            constain.Columns[2].ColumnName = "username";
            constain.Columns[3].ColumnName = "pass";
            constain.Columns[4].ColumnName = "quyen";

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
