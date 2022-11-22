using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_app
{
    public partial class List_Item : UserControl
    {
        public event EventHandler list_Item_Click;
        public List_Item()
        {
            InitializeComponent();
        }

        #region
        private string ten;
        private string discount;
        private string gia;
        private string danh_gia;
        private Image picture;


        public string Ten
        {
            get { return ten; }
            set { ten = value; name.Text = value; }
        }

        public string Discount
        {
            get { return discount; }
            set { discount = value; KM.Text = value; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; Anh.Image = value; }
        }

        public string Gia
        {
            get { return gia; }
            set { gia = value; Price.Text = value; }
        }

        public string Danhgia
        {
            get { return danh_gia; }
            set { danh_gia = value; Judge.Text = value; }
        }

        #endregion

        private void List_Item_Load(object sender, EventArgs e)
        {

        }

        private void List_Item_Click(object sender, EventArgs e)
        {
            if (list_Item_Click != null)
                list_Item_Click.Invoke(sender, e);
        }
    }
}
