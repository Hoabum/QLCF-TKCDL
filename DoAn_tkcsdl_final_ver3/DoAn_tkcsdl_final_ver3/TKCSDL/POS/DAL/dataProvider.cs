using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace POS.DAL
{
    class dataProvider
    {
        private static dataProvider Instance;
        //  private static dataProvider obj;

        public static dataProvider instance
        {
            get { if (Instance == null) Instance = new dataProvider(); return dataProvider.Instance; }
            private set { dataProvider.instance = value; }
        }
        private string str = @"Data Source=DESKTOP-MOJHARE;Initial Catalog=QLCF1;Integrated Security=True ";

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
}
