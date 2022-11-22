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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        #region
        private string History_id;
        private string History_name;
        private string History_price;
        private string History_quantity;
        private Image picture;

        public string Id
        {
            get { return History_id; }
            set { History_id = value; label1.Text = value; }
        }

        public string Name
        {
            get { return History_name; }
            set { History_name = value; label2.Text = value; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBox1.Image = value; }
        }

        public string Price
        {
            get { return History_price; }
            set { History_price = value; label4.Text = value; }
        }

        public string Quantity
        {
            get { return History_quantity; }
            set { History_quantity = value; label3.Text = value; }
        }

        #endregion

    }
}
