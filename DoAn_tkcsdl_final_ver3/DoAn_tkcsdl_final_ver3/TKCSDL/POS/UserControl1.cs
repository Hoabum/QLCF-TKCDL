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
    public partial class UserControl1 : System.Windows.Forms.UserControl
    {

       public UserControl1()
        {
            InitializeComponent();
        }
        private string _title;
        private string _price;
        private Image _img;
        public bool ktr = false;
        
        public string Price
        {
            get { return _price; }
            set { _price = value; lb_price.Text = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; lb_title.Text = value; }
        }
        public Image Img
        {
            get { return _img; }
            set { _img = value; pictureBox1.Image = value; }
        }
        private void GunaLinePanel_valid_Paint(object sender, PaintEventArgs e)
        {
           /* if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
               
            }*/
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
               
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void GunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
      

        
 
        private void GunaShadowPanel1_Click(object sender, EventArgs e)
        {
            /*if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }*/
        }
        
        
        private void GunaLinePanel_valid_Click(object sender, EventArgs e)
        {
            /*if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }*/
        }
      
        private void gunaLinePanel_valid_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinePanel_valid_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton_valid_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel_valid_Click_1(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
       
        private void guna2CustomGradientPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaShadowPanel1_Click_1(object sender, EventArgs e)
        {
            

        }

       
    }
}
