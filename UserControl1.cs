using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shopping_app
{
    
    public partial class Information : UserControl
    {
        public EventHandler Add_cart_click;
        public Information()
        {
            InitializeComponent();
        }

        #region
        private string info_ten;
        private string info_baseprice;
        private string info_discount;
        private string info_price;
        private string info_chip;
        private string info_RAM;
        private string info_ROM;
        private string info_screen;
        private Image info_picture;
        private string info_danhgia;
        private string info_battery;
        private string info_camera;
        private int info_quantity=1;

        public string info_Ten
        {
            get { return info_ten; }
            set { info_ten = value; info_name.Text = value; }
        }

        public string info_Baseprice
        {
            get { return info_baseprice; }
            set { info_baseprice = value; baseprice.Text = value; }
        }

        public Image info_Picture
        {
            get { return info_picture; }
            set { info_picture = value; info_pic.Image = value; }
        }

        public string info_Discount
        {
            get { return info_discount; }
            set { info_discount = value; Discount.Text = value + "%"; }
        }

        public string info_Price
        {
            get { return info_price; }
            set { info_price = value; price.Text = value; }
        }

        public string info_Chip
        {
            get { return info_chip; }
            set { info_chip = value; label8.Text = value; }
        }

        public string info_ram
        {
            get { return info_RAM; }
            set { info_RAM = value; label9.Text = value; }
        }

        public string info_rom
        {
            get { return info_ROM; }
            set { info_ROM = value; label10.Text = value; }
        }

        public string info_Screen
        {
            get { return info_screen; }
            set { info_screen = value; label11.Text = value; }
        }

        public string info_Battery
        {
            get { return info_battery; }
            set { info_battery = value; label12.Text = value; }
        }

        public string info_Camera
        {
            get { return info_camera; }
            set { info_camera = value; label13.Text =value; }
        }

        public string info_Danhgia
        {
            get { return info_danhgia; }
            set { info_danhgia = value; info_judge.Text = value + " sao"; }
        }

        public int info_Quantity
        {
            get { return info_quantity; }
            set { info_quantity = value; label7.Text = value.ToString(); }
        }

        #endregion

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info_quantity = info_quantity + 1;
            label7.Text = info_quantity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (info_quantity == 1)
                MessageBox.Show("Item quantity must be more than 1");
            else
            {
                info_quantity = info_quantity - 1;
                label7.Text = info_quantity.ToString();
            }
        }

        private void add_cart_Click(object sender, EventArgs e)
        {
            Add_cart_click?.Invoke(sender, e);
        }
    }
}
