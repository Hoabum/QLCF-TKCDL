using POS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.BLL
{
    internal class ClassBLL
    {
        public bool SaveItemsKho(Image anh, string ten, float giamon,string idloai)
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); 
                return objdal.AddItemsToTableKho(anh, ten, giamon, idloai); //chuyển các giá trị cho chức năng lớp truy cập dữ liệu
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        public DataTable GetItems1()
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); // đối tượng lớp lớp truy cập dữ liệu để truy cập các hàm
                return objdal.ReadItemsTableTS();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems2()
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); // đối tượng lớp lớp truy cập dữ liệu để truy cập các hàm
                return objdal.ReadItemsTableNG();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems3()
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); // đối tượng lớp lớp truy cập dữ liệu để truy cập các hàm
                return objdal.ReadItemsTableCF();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetItems4()
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); // đối tượng lớp lớp truy cập dữ liệu để truy cập các hàm
                return objdal.ReadItemsTableFood();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        internal object SaveItems(string text1, string text2, Image image, Func<string> toString, string text3)
        {
            throw new NotImplementedException();
        }
    }
}
