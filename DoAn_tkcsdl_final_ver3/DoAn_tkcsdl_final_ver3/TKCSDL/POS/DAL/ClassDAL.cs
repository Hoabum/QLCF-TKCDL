using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    internal class ClassDAL
    {
        public bool AddItemsToTableKho(Image anh ,string ten, float giamon,string idloai)
        {
            Connection con = new Connection();
            con.OpenConn();
            
            // truy vấn 
            string query = "Insert into kho(ten,giamon,anh,idloai)values(@ten,@giamon,@anh,@idloai)";
            try
            {
                //Tạo đối tượng cmd
                using (SqlCommand cmd = new SqlCommand(query, con.Conn))
                {
                    //trim()Phương thức này trả về bản sao của chuỗi
                    cmd.Parameters.AddWithValue("@ten", ten.Trim()); // set ten
                    cmd.Parameters.AddWithValue("@giamon", giamon.ToString().Trim()); // set giamon
                    // chuyển img sang dạng nhị phân để lưu xuông sql
                    MemoryStream ms = new MemoryStream();
                    anh.Save(ms, anh.RawFormat);
                    cmd.Parameters.AddWithValue("@anh",ms.ToArray());
                    cmd.Parameters.AddWithValue("@idloai", idloai.Trim());
              
                    cmd.ExecuteNonQuery();

                }   return true;
                
            }catch { throw; }
        }
        

        public DataTable ReadItemsTableTS()
        {
            Connection con = new Connection();

            con.OpenConn();
            //truy vấn -> kho
            string query = "SELECT * FROM kho WHERE idloai ='1'";
            SqlCommand cmd = new SqlCommand(query, con.Conn);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); // luu vô dt
                    return dt;
                }
            }
            catch { throw; }
        }
        public DataTable ReadItemsTableNG()
        {
            Connection con = new Connection();

            con.OpenConn();
            //truy vấn -> kho
            string query = "SELECT * FROM kho WHERE idloai ='2'";
            SqlCommand cmd = new SqlCommand(query, con.Conn);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); // luu vô dt
                    return dt;
                }
            }
            catch { throw; }
        }
        public DataTable ReadItemsTableCF()
        {
            Connection con = new Connection();

            con.OpenConn();
            //truy vấn -> kho
            string query = "SELECT * FROM kho WHERE idloai ='3'";
            SqlCommand cmd = new SqlCommand(query, con.Conn);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); // luu vô dt
                    return dt;
                }
            }
            catch { throw; }
        }
        public DataTable ReadItemsTableFood()
        {
            Connection con = new Connection();

            con.OpenConn();
            //truy vấn -> kho
            string query = "SELECT * FROM kho WHERE idloai ='4'";
            SqlCommand cmd = new SqlCommand(query, con.Conn);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); // luu vô dt
                    return dt;
                }
            }
            catch { throw; }
        }
    }
   
}
