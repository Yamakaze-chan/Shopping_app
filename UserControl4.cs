using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_app
{
    public partial class headphone_info : UserControl
    {
        public EventHandler Add_cart_click;
        public headphone_info()
        {
            InitializeComponent();
        }

        private void headphone_info_Load(object sender, EventArgs e)
        {

        }

        #region
        private string info_ten;
        private string info_baseprice;
        private string info_danhgia;
        private string info_discount;
        private string info_price;
        private Image info_picture;
        private Image picture;
        private int info_quantity = 1;

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
            set { info_picture = value; pictureBox2.Image = value; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBox1.Image = value; }
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
