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
    public partial class Receipt : UserControl
    {
        public EventHandler btn3_click;
        public EventHandler btn2_click;
        public EventHandler btn1_click;
        public Receipt()
        {
            InitializeComponent();
        }

        #region
        private string receipt_id;
        private string receipt_name;
        private string receipt_price;
        private string receipt_quantity;
        private Image picture;

        public Button Mybtn { get { return Mybtn; } }
        public string Id
        {
            get { return receipt_id; }
            set { receipt_id = value; label1.Text = value; }
        }

        public string Name
        {
            get { return receipt_name; }
            set { receipt_name = value; label2.Text = value; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBox1.Image = value; }
        }

        public string Price
        {
            get { return receipt_price; }
            set { receipt_price = value; label4.Text = value; }
        }

        public string Quantity
        {
            get { return receipt_quantity; }
            set { receipt_quantity = value; label3.Text = value; }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            btn1_click?.Invoke(sender, e);
            receipt_quantity = (int.Parse(receipt_quantity) + 1).ToString();
            label3.Text = receipt_quantity;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn2_click?.Invoke(sender, e);
            if (int.Parse(receipt_quantity) == 1)
            {
                MessageBox.Show("Quantity must be larger than 0");
            }
            else
            {
                receipt_quantity = (int.Parse(receipt_quantity) - 1).ToString();
                label3.Text = receipt_quantity;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3_click?.Invoke(sender, e);
            
        }
    }
}
