using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        private string _title;
        private string _price;
        private string _soluong;
        public static string Tensp = string.Empty;
        public string Price
        {
            get { return _price; }
            set { _price = value; lb_gia.Text = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; lb_tenmon.Text = value; }
        }
        public string Soluong
        {
            get { return _soluong; }
            set { _soluong = value; lb_soluong.Value += int.Parse(value); }
        }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void lb_soluong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lb_soluong_Click(object sender, EventArgs e)
        {
            
        }
       public bool kt;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Tensp = lb_tenmon.Text;
           
        }

        private void lb_tenmon_Click(object sender, EventArgs e)
        {

        }
    }
}
