using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Xml.Linq;
using System.Reflection.Emit;
using Microsoft.Reporting.WinForms;
using BarcodeLib;
using QRCoder;

namespace Shopping_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection consql = new SqlConnection(@"Server= YAMAKAZE; Database= Shopping_app; Integrated Security=True;");
        int style_panel=0;
        string ID = "-1";
        int CART = -1;

        private void Header_iphone_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label12.Text = "Have a nice day, " + Environment.NewLine + "Do you want to creat an account for you?";
            Generate_Iphone();
            Generate_samsung();
            Generate_OPPO();
            Generate_Realme();
            List_filter();
            if(ID == "-1")
            {
                pictureBox1.Visible = false;
                button4.Visible = false;
            }    
            return_label.Visible = false;
            flowLayoutPanel2.Visible = false;
            label7.Visible = false;
            Login.Visible = true;
            logout.Visible = false;
            this.reportViewer1.RefreshReport();
        }
        //Homepage generate iphone picture
        private void Generate_Iphone()
        {
            consql.Open();
            SqlDataAdapter da_IP = new SqlDataAdapter();
            da_IP.SelectCommand = new SqlCommand("select * from Item where TRADEMARK = 'IP' AND CLASS = 'PHONE'", consql);
            DataTable dt_IP = new DataTable();
            da_IP.Fill(dt_IP);
            List_Item[] listitem_iphone = new List_Item[100];
            String t, d, p, g, da;
            int i = 0;
            foreach (DataRow row in dt_IP.Rows)
            {
                listitem_iphone[i] = new List_Item();
                listitem_iphone[i].Ten = row["TEN"].ToString();
                listitem_iphone[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_iphone[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_iphone[i].Gia = row["GIA"].ToString() + "d";
                listitem_iphone[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_iphone[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                da = listitem_iphone[i].Danhgia;
                if (flowLayoutPanel_iphone.Controls.Count < 0)
                {
                    flowLayoutPanel_iphone.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel_iphone.Controls.Add(listitem_iphone[i]);
                }
                listitem_iphone[i].Click += (s, ee) => Changepanel(ID);
                i = i + 1;
            }
            consql.Close();
        }

        //Homepage generate samsung picture
        private void Generate_samsung()
        {
            consql.Open();
            SqlDataAdapter da_SS = new SqlDataAdapter();
            da_SS.SelectCommand = new SqlCommand("select * from Item where TRADEMARK = 'SS' AND CLASS = 'PHONE'", consql);
            DataTable dt_SS = new DataTable();
            da_SS.Fill(dt_SS);
            List_Item[] listitem_samsung = new List_Item[100];
            String t, d, p, g, da;
            int i = 0;
            foreach (DataRow row in dt_SS.Rows)
            {
                listitem_samsung[i] = new List_Item();
                listitem_samsung[i].Ten = row["TEN"].ToString();
                listitem_samsung[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_samsung[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_samsung[i].Gia = row["GIA"].ToString() + "d";
                listitem_samsung[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_samsung[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                da = listitem_samsung[i].Danhgia;
                if (flowLayoutPanel_samsung.Controls.Count < 0)
                {
                    flowLayoutPanel_samsung.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel_samsung.Controls.Add(listitem_samsung[i]);
                }
                listitem_samsung[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }

        //Homepage generate oppo picture
        private void Generate_OPPO()
        {
            consql.Open();
            SqlDataAdapter da_OP = new SqlDataAdapter();
            da_OP.SelectCommand = new SqlCommand("select * from Item where TRADEMARK = 'OP' AND CLASS = 'PHONE'", consql);
            DataTable dt_OP = new DataTable();
            da_OP.Fill(dt_OP);
            List_Item[] listitem_OPPO = new List_Item[100];
            String t, d, p, g, da;
            int i = 0;
            foreach (DataRow row in dt_OP.Rows)
            {
                listitem_OPPO[i] = new List_Item();
                listitem_OPPO[i].Ten = row["TEN"].ToString();
                listitem_OPPO[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_OPPO[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_OPPO[i].Gia = row["GIA"].ToString() + "d";
                listitem_OPPO[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                t = listitem_OPPO[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                da = listitem_OPPO[i].Danhgia;
                string ID = row["ID"].ToString();
                if (flowLayoutPanel_oppo.Controls.Count < 0)
                {
                    flowLayoutPanel_oppo.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel_oppo.Controls.Add(listitem_OPPO[i]);
                }
                listitem_OPPO[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }

        //Homepage generate realme picture
        private void Generate_Realme()
        {
            consql.Open();
            SqlDataAdapter da_RM = new SqlDataAdapter();
            da_RM.SelectCommand = new SqlCommand("select * from Item where TRADEMARK = 'RM' AND CLASS = 'PHONE'", consql);
            DataTable dt_RM = new DataTable();
            da_RM.Fill(dt_RM);
            List_Item[] listitem_Realme = new List_Item[100];
            String t, d, p, g, da;
            int i = 0;
            foreach (DataRow row in dt_RM.Rows)
            {
                listitem_Realme[i] = new List_Item();
                listitem_Realme[i].Ten = row["TEN"].ToString();
                listitem_Realme[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_Realme[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_Realme[i].Gia = row["GIA"].ToString() + "d";
                listitem_Realme[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_Realme[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                da = listitem_Realme[i].Danhgia;
                if (flowLayoutPanel_realme.Controls.Count < 0)
                {
                    flowLayoutPanel_realme.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel_realme.Controls.Add(listitem_Realme[i]);
                }
                listitem_Realme[i].Click += (s, ee) => Changepanel(ID);
                i = i + 1;
            }
            consql.Close();
        }

        private void Changepanel(string ID)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel5.Visible = false;
            Login_panel.Visible = false;
            cart_panel.Visible = false;
            label7.Visible = false;
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item JOIN PHONE_INFO ON Item.ID = INFO_ID WHERE Item.ID = " + ID, consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Information info = new Information();
            foreach (DataRow row in dt.Rows)
            {
                int x = int.Parse(row["GIA"].ToString());
                int y = int.Parse(row["DISCOUNT"].ToString());
                int temp = (x * 100) / (100 - y);
                string id = row["ID"].ToString();
                info.info_Baseprice = temp.ToString();
                info.info_Chip = row["INFO_CHIP"].ToString();
                info.info_Discount = row["DISCOUNT"].ToString();
                info.info_Picture = Image.FromFile(row["PICTURE"].ToString());
                info.info_Price = row["GIA"].ToString();
                info.info_ram = row["INFO_RAM"].ToString();
                info.info_rom = row["INFO_ROM"].ToString();
                info.info_Screen = row["INFO_SCREEN"].ToString();
                info.info_Ten = row["TEN"].ToString();
                info.info_Danhgia = row["DANHGIA"].ToString();
                info.info_Battery = row["INFO_BATTERY"].ToString();
                info.info_Camera = row["INFO_CAM"].ToString();
                info.Add_cart_click += (s, ee) => addcart(id, info);
            }
            var panel = new Panel { Name = "newpanel" };
            panel.Location = new System.Drawing.Point(251, 142);
            panel.Size = new System.Drawing.Size(1672, 881);
            panel.Controls.Add(info);
            Controls.Add(panel);
            return_label.Visible = true;
            return_label.Click += new EventHandler(Return_label_Click);
            consql.Close();
        }

        private void addcart(string st, Information ifo)
        {
            if (ID == "-1")
            {
                MessageBox.Show("Please login first!!!");
            }
            else
            {
                consql.Open();
                var cmd = consql.CreateCommand();
                cmd.CommandText = "INSERT INTO CART VALUES (@cart, @user, @id_item, @quantity, null, 0)";
                cmd.Parameters.AddWithValue("@cart", CART);
                cmd.Parameters.AddWithValue("@user", ID);
                cmd.Parameters.AddWithValue("@id_item", st);
                cmd.Parameters.AddWithValue("@quantity", ifo.info_Quantity);
                cmd.ExecuteNonQuery();
                consql.Close();
            }
        }

        private void Return_label_Click(object sender, EventArgs e)
        {
            //Panel p = sender as Panel;
            return_label.Visible = false;
            var panel = Controls["newpanel"];
            Controls.Remove(panel);
            if (style_panel == 0)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = false;
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 1)
            {
                flowLayoutPanel2.Visible = true;
                flowLayoutPanel2.BringToFront();
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 2)
            {
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = true;
                flowLayoutPanel5.BringToFront();
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }  
        }

        private void List_filter()
        {
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT DISTINCT TRADEMARK FROM Item", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row["TRADEMARK"].ToString() == "SS")
                {
                    comboBox1.Items.Add("Samsung");
                }
                else if (row["TRADEMARK"].ToString() == "IP")
                {
                    comboBox1.Items.Add("Iphone");
                }
                else if (row["TRADEMARK"].ToString() == "RM")
                {
                    comboBox1.Items.Add("Realme");
                }
                else if (row["TRADEMARK"].ToString() == "OP")
                {
                    comboBox1.Items.Add("OPPO");
                }
            }
            comboBox2.Items.Add("Below 1.000.000");
            comboBox2.Items.Add("Below 10.000.000");
            comboBox2.Items.Add("Below 20.000.000");
            comboBox2.Items.Add("More than 20.000.000");
            consql.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            style_panel = 1;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Controls.Clear();
            label7.Visible = true; label7.BringToFront();
            consql.Open();
            string command = "SELECT * FROM Item ";
            if ((string.IsNullOrWhiteSpace(comboBox2.Text) == false) || (string.IsNullOrWhiteSpace(comboBox1.Text) == false) || (string.IsNullOrWhiteSpace(searchbox.Text) == false))
            {
                command = command + "WHERE ";
            }    
            if (string.IsNullOrWhiteSpace(searchbox.Text) == false)
            {
                command = command + "TEN LIKE '%" + searchbox.Text + "%'";
            }
            if((string.IsNullOrWhiteSpace(comboBox1.Text) == false) && (string.IsNullOrWhiteSpace(searchbox.Text) == false))
            {
                command = command + " AND";
            }    
            if(comboBox1.Text == "Iphone")
            {
                command = command + " TRADEMARK = 'IP'";
            }
            else if (comboBox1.Text == "AVA+")
            {
                command = command + " TRADEMARK = 'AVA'";
            }
            else if (comboBox1.Text == "Awei")
            {
                command = command + " TRADEMARK = 'AW'";
            }
            else if (comboBox1.Text == "Samsung")
            {
                command = command + " TRADEMARK = 'SS'";
            }
            else if (comboBox1.Text == "Realme")
            {
                command = command + " TRADEMARK = 'RM'";
            }
            else if (comboBox1.Text == "OPPO")
            {
                command = command + " TRADEMARK = 'OP'";
            }
            if ((string.IsNullOrWhiteSpace(comboBox2.Text) == false)&& ((string.IsNullOrWhiteSpace(comboBox1.Text) == false) || (string.IsNullOrWhiteSpace(searchbox.Text) == false)))
            {
                command = command + " AND";
            }
            if (comboBox2.Text == "Below 1.000.000")
            {
                command = command + " GIA < 1000000";
            }
            else if (comboBox2.Text == "Below 10.000.000")
            {
                command = command + " GIA < 10000000";
            }
            else if (comboBox2.Text == "Below 20.000.000")
            {
                command = command + " GIA < 20000000";
            }
            else if (comboBox2.Text == "More than 20.000.000")
            {
                command = command + " GIA > 20000000";
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(command, consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List_Item[] listitem_Filter = new List_Item[100];
            String t, d, p, g, ju;
            int i = 0;
            if (dt.Rows.Count == 0)
            {
                var label1 = new System.Windows.Forms.Label();
                label1.Location = new System.Drawing.Point(0, 0);
                label1.Size = new System.Drawing.Size(1000, 500);
                label1.Text = "No products found matching your search";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
                flowLayoutPanel2.Controls.Add(label1);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    listitem_Filter[i] = new List_Item();
                    listitem_Filter[i].Ten = row["TEN"].ToString();
                    listitem_Filter[i].Discount = row["DISCOUNT"].ToString() + "%";
                    listitem_Filter[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                    listitem_Filter[i].Gia = row["GIA"].ToString() + "d";
                    listitem_Filter[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                    string ID = row["ID"].ToString();
                    t = listitem_Filter[i].Ten;
                    d = row["DISCOUNT"].ToString();
                    p = row["PICTURE"].ToString();
                    g = row["GIA"].ToString();
                    ju = listitem_Filter[i].Danhgia;
                    if (flowLayoutPanel2.Controls.Count < 0)
                    {
                        flowLayoutPanel2.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel2.Controls.Add(listitem_Filter[i]);
                    }
                    listitem_Filter[i].Click += (s, ee) => Changepanel(
                        ID);
                    i = i + 1;
                }
            }
            consql.Close();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Panel p = sender as Panel;
            flowLayoutPanel2.Visible = false;
            label7.Visible = false;
            flowLayoutPanel5.Visible = false;
            flowLayoutPanel1.Visible = true;
            style_panel = 0;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            button4.Visible = true;
            consql.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LOGIN_USER WHERE USERNAME='" + textBox1.Text + "' AND PASS='" + textBox2.Text + "'", consql);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOGIN_USER WHERE USERNAME='" + textBox1.Text + "' AND PASS='" + textBox2.Text + "'", consql);
                DataTable sdt = new DataTable(); 
                da.Fill(sdt);
                foreach (DataRow row in sdt.Rows)
                {
                    ID = row["ID_USER"].ToString();
                    label12.Text = "Have a nice day, " + Environment.NewLine + row["NICKNAME"].ToString();
                }
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT MAX(ID_CART)AS largestID FROM CART ", consql);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                   CART = int.Parse(dr["largestID"].ToString()) + 1;
                }
                Login_panel.Visible = false;
                Login.Visible = false;
                logout.Visible =  true;
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible=false;
                pictureBox1.Visible = true;

            }
            else
            MessageBox.Show("Invalid username or password");
            consql.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) == false)
            {
                consql.Open();
                label11.Visible = true;
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOGIN_USER WHERE USERNAME='" + textBox1.Text + "'", consql);
                DataTable sdt = new DataTable(); 
                da.Fill(sdt);
                foreach (DataRow row in sdt.Rows)
                    label11.Text = "Your password is " + row["PASS"].ToString();
                consql.Close();
            }
        }

        private void Signup_label_Click(object sender, EventArgs e)
        {
            signup_panel.Visible = true;
            Login_panel.Visible = false;
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = true;
            Login_panel.BringToFront();
            Login.Enabled = false;
            cart_panel.Visible = false;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            label7.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            //consql.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT MAX(ID_CART)AS largestID FROM CART WHERE ID_USER = '" + ID + "'", consql);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
             //   CART = int.Parse(row["largestID"].ToString());
            //}
            //consql.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            ID = "-1";
            pictureBox1.Visible = false;
            button4.Visible = false;
            logout.Visible = false;
            Login.Visible = true;
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CART WHERE ID_USER= '" + ID + "' AND ID_CART = '" + CART.ToString() + "' AND PAY = 0", consql);
            DataTable sdt = new DataTable();
            da.Fill(sdt);
            if(sdt.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("There are some products in your cart but you have not paid yet, do you want to cancel this cart?", "UNPAID GOODS", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var cmd = consql.CreateCommand();
                    cmd.CommandText = "DELETE FROM CART WHERE ID_CART = @cart";
                    cmd.Parameters.AddWithValue("@cart", CART);
                    cmd.ExecuteNonQuery();
                    ID = "-1";
                    label12.Text = "Have a nice day, " + Environment.NewLine + "Do you want to create an account for yourself?";
                    Login.Visible = true;
                    Login.Enabled = true;
                    logout.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            consql.Close();
        }

        private void watch__all0_Click(object sender, EventArgs e)
        {
            style_panel = 0;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Controls.Clear();
            label7.Visible = true; label7.BringToFront();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item WHERE TRADEMARK ='IP' AND CLASS = 'PHONE'", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List_Item[] listitem_Filter = new List_Item[100];
            String t, d, p, g, ju;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listitem_Filter[i] = new List_Item();
                listitem_Filter[i].Ten = row["TEN"].ToString();
                listitem_Filter[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_Filter[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_Filter[i].Gia = row["GIA"].ToString() + "d";
                listitem_Filter[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_Filter[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                ju = listitem_Filter[i].Danhgia;
                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(listitem_Filter[i]);
                }
                listitem_Filter[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }

        private void watch_all1_Click(object sender, EventArgs e)
        {
            style_panel = 0;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Controls.Clear();
            label7.Visible = true; label7.BringToFront();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item WHERE TRADEMARK ='SS' AND CLASS = 'PHONE'", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List_Item[] listitem_Filter = new List_Item[100];
            String t, d, p, g, ju;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listitem_Filter[i] = new List_Item();
                listitem_Filter[i].Ten = row["TEN"].ToString();
                listitem_Filter[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_Filter[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_Filter[i].Gia = row["GIA"].ToString() + "d";
                listitem_Filter[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_Filter[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                ju = listitem_Filter[i].Danhgia;
                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(listitem_Filter[i]);
                }
                listitem_Filter[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }

        private void watch_all2_Click(object sender, EventArgs e)
        {
            style_panel = 0;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Controls.Clear();
            label7.Visible = true; label7.BringToFront();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item WHERE TRADEMARK ='OP' AND CLASS = 'PHONE'", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List_Item[] listitem_Filter = new List_Item[100];
            String t, d, p, g, ju;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listitem_Filter[i] = new List_Item();
                listitem_Filter[i].Ten = row["TEN"].ToString();
                listitem_Filter[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_Filter[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_Filter[i].Gia = row["GIA"].ToString() + "d";
                listitem_Filter[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_Filter[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                ju = listitem_Filter[i].Danhgia;
                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(listitem_Filter[i]);
                }
                listitem_Filter[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            style_panel = 0;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel2.Controls.Clear();
            label7.Visible = true; label7.BringToFront();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item WHERE TRADEMARK ='RM' AND CLASS = 'PHONE'", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List_Item[] listitem_Filter = new List_Item[100];
            String t, d, p, g, ju;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listitem_Filter[i] = new List_Item();
                listitem_Filter[i].Ten = row["TEN"].ToString();
                listitem_Filter[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem_Filter[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem_Filter[i].Gia = row["GIA"].ToString() + "d";
                listitem_Filter[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                string ID = row["ID"].ToString();
                t = listitem_Filter[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                ju = listitem_Filter[i].Danhgia;
                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(listitem_Filter[i]);
                }
                listitem_Filter[i].Click += (s, ee) => Changepanel(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }


        List<Receipt> abc = new List<Receipt>();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cart.Text = "CART NO." + CART.ToString();
            cart_panel.Visible = true;
            cart_panel.BringToFront();
            return_label.Visible = false;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            label7.Visible = false;
            cart_panel.Visible = true;
            flowLayoutPanel3.Controls.Clear();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT Item.ID, Item.TEN, Item.GIA, Item.PICTURE, Item.DISCOUNT, SUM(CART.QUANTITY) AS quantity FROM Item JOIN CART ON Item.ID = CART.ITEM_ID WHERE CART.ID_USER = '"+ID + "' AND CART.ID_CART = '" + CART + "' GROUP BY Item.ID, Item.TEN, Item.GIA, Item.PICTURE, Item.DISCOUNT", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Receipt[] list_receipt = new Receipt[100];
            int i = 0;
            int total = 0;
            foreach (DataRow row in dt.Rows)
            {
                list_receipt[i] = new Receipt();
                list_receipt[i].Id = row["ID"].ToString();
                string st = row["ID"].ToString();
                list_receipt[i].Name = row["TEN"].ToString();
                list_receipt[i].Price = (int.Parse(row["GIA"].ToString()) - (((int.Parse(row["GIA"].ToString()) * int.Parse(row["DISCOUNT"].ToString())) / 100))).ToString();
                list_receipt[i].Quantity = row["quantity"].ToString();
                list_receipt[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                list_receipt[i].btn3_click += (s,ee) => list_btn(st);
                list_receipt[i].btn2_click += (s, ee) => list_btn2(st);
                list_receipt[i].btn1_click += (s, ee) => list_btn1(st);
                total = total + ((int.Parse(row["GIA"].ToString()) - (((int.Parse(row["GIA"].ToString()) * int.Parse(row["DISCOUNT"].ToString())) / 100))) * (int.Parse(row["quantity"].ToString())));
                flowLayoutPanel3.Controls.Add(list_receipt[i]);
                abc.Add(new Receipt() { Id = row["ID"].ToString(),
                    Name = row["TEN"].ToString(),
                    Price = (int.Parse(row["GIA"].ToString()) - (((int.Parse(row["GIA"].ToString()) * int.Parse(row["DISCOUNT"].ToString())) / 100))).ToString(),
                    Quantity = row["quantity"].ToString()

                });
            }
            //flowLayoutPanel3.Controls.RemoveAt(1);
            total_label.Text = "Total Price: " + total.ToString();
            consql.Close();
        }
        private void list_btn( string str)
        {
            int i = 0;
            int total = 0;
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                if (!(receipt is null))
                {
                    if (receipt.Id == str)
                    {
                        consql.Open();
                        var cmd = consql.CreateCommand();
                        cmd.CommandText = "DELETE FROM CART WHERE ITEM_ID = @str";
                        cmd.Parameters.AddWithValue("@str", str);
                        cmd.ExecuteNonQuery();
                        flowLayoutPanel3.Controls.RemoveAt(i);
                        consql.Close();
                    }
                    i++;
                }
            }
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                total = total + (int.Parse(receipt.Price) * int.Parse(receipt.Quantity));
            }
            total_label.Text = "Total Price: " + total.ToString();

        }

        private void list_btn2(string str)
        {
            int total = 0;
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                total = total + (int.Parse(receipt.Price) * int.Parse(receipt.Quantity));
            }
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                if (!(receipt is null))
                {
                    if (receipt.Id == str && Int32.Parse(receipt.Quantity) > 1)
                    {
                        consql.Open();
                        var cmd = consql.CreateCommand();
                        cmd.CommandText = "UPDATE CART SET QUANTITY = @quan WHERE ITEM_ID = '" + str +"'";
                        cmd.Parameters.AddWithValue("@quan", Int32.Parse(receipt.Quantity) - 1);
                        total = total - (int.Parse(receipt.Price));
                        cmd.ExecuteNonQuery();
                        consql.Close();
                        break;
                    }
                }
            }
            total_label.Text = "Total Price: " + total.ToString();
        }

        private void list_btn1(string str)
        {
            int total = 0;
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                total = total + (int.Parse(receipt.Price) * int.Parse(receipt.Quantity));
            }
            foreach (Receipt receipt in flowLayoutPanel3.Controls)
            {
                if (!(receipt is null))
                {
                    if (receipt.Id == str)
                    {
                        consql.Open();
                        var cmd = consql.CreateCommand();
                        cmd.CommandText = "UPDATE CART SET QUANTITY = @quan WHERE ITEM_ID = '" + str + "'";
                        cmd.Parameters.AddWithValue("@quan", Int32.Parse(receipt.Quantity) + 1);
                        total = total + (int.Parse(receipt.Price));
                        cmd.ExecuteNonQuery();
                        consql.Close();
                        break;
                    }
                }
            }
            total_label.Text = "Total Price: " + total.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            cart_panel.Visible = false;
            if (style_panel == 0)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = false;
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 1)
            {
                flowLayoutPanel2.Visible = true;
                flowLayoutPanel2.BringToFront();
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 2)
            {
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = true;
                flowLayoutPanel5.BringToFront();
                label7.Visible = true; label7.BringToFront();
                label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
        }

        bool isCheck = false;
        private void radioButton_home_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_home.Checked)
            {
                int total = 0;
                foreach (Receipt receipt in flowLayoutPanel3.Controls)
                {
                    total = total + (int.Parse(receipt.Price) * int.Parse(receipt.Quantity));
                }
                total = total + 30000;
                total_label.Text = "Total Price: " + total.ToString();
                isCheck = true;
                label23.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void radioButton_store_CheckedChanged(object sender, EventArgs e)
        {
            if(isCheck == true && radioButton_store.Checked)
            {
                var matches = Regex.Matches(total_label.Text, @"\d+");
                string str = string.Empty;
                foreach (var match in matches)
                {
                    str += match;
                }
                int total = 0;
                if (str != "0")
                {
                    total = int.Parse(str) - 30000;
                }
                total_label.Text = "Total Price: " + total.ToString();
                label23.Visible = false;
                textBox3.Visible = false;
            }
        }
        bool isCheck1 = false;
        private void radioButton_cash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_cash.Checked)
            {
                isCheck1 = true;
                label24.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void radioButton_credit_CheckedChanged(object sender, EventArgs e)
        {
            if (isCheck1 == true && radioButton_credit.Checked)
            {
                label24.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            history_panel.Visible = true;
            history_panel.BringToFront();
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT DISTINCT ID_CART FROM CART WHERE ID_USER = '" + ID + "'", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var label = new System.Windows.Forms.Label();
                label.Location = new System.Drawing.Point(0, 0);
                label.Size = new System.Drawing.Size(600, 150);
                label.Text = "CART NO." + dr["ID_CART"].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                flowLayoutPanel4.Controls.Add(label);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = new SqlCommand(
                    "SELECT CART.ID_USER, CART.ID_CART, SUM(CART.QUANTITY)AS QUAN, ITEM.TEN, Item.GIA, Item.PICTURE, CART.ITEM_ID " +
                    "FROM CART, Item WHERE CART.ID_USER = '" + ID + "' AND CART.ITEM_ID = Item.ID AND CART.ID_CART = '" + dr["ID_CART"].ToString() + "' AND CART.PAY = 1 " +
                    "group by CART.ID_CART,CART.QUANTITY, ITEM.TEN, Item.GIA, Item.PICTURE, CART.ITEM_ID, CART.ID_USER ", consql);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    var label1 = new System.Windows.Forms.Label();
                    label1.Location = new System.Drawing.Point(0, 0);
                    label1.Size = new System.Drawing.Size(600, 50);
                    label1.Text = "There are no products in this cart";
                    label1.TextAlign = ContentAlignment.MiddleCenter;
                    label1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    flowLayoutPanel4.Controls.Add(label1);
                }
                else
                {
                    History[] his = new History[100];
                    int j = 0;
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        his[j] = new History();
                        his[j].Id = dr1["ITEM_ID"].ToString();
                        his[j].Name = dr1["TEN"].ToString();
                        his[j].Picture = Image.FromFile(dr1["PICTURE"].ToString());
                        his[j].Price = dr1["GIA"].ToString();
                        his[j].Quantity = dr1["QUAN"].ToString();
                        flowLayoutPanel4.Controls.Add(his[j]);
                        j++;
                    }
                }
            }
            consql.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            flowLayoutPanel4.Controls.Clear();
            history_panel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT MAX(ID_USER)AS largestID FROM LOGIN_USER", consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ID = dr["largestID"].ToString();
            }
            int k = int.Parse(ID) + 1;
            int temp = k;
            int c = 0;
            while(temp != 0)
            {
                c = c + 1;
                temp = temp / 10;
            }
            c = 4 - c;
            ID = k.ToString();
            while(c > 0)
            {
                ID = "0" + ID;
                c = c- 1;
            }
            var cmd = consql.CreateCommand();
            cmd.CommandText = "INSERT INTO LOGIN_USER VAlUES(@id, @username, @pass, @nick, 0)";
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@username", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);
            cmd.Parameters.AddWithValue("@nick", textBox7.Text);
            cmd.ExecuteNonQuery();
            consql.Close();
            signup_panel.Visible = false;
            Login_panel.Visible = true;
            flowLayoutPanel2.Visible = false;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Controls.Count == 0)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else
            {
                consql.Open();
                var cmd = consql.CreateCommand();
                cmd.CommandText = "UPDATE CART SET PAY = 1 WHERE CART.ID_USER = '" + ID + "' AND CART.ID_CART = '" + CART.ToString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE CART SET PAY_ADDRESS = '" + textBox3.Text + "' WHERE CART.ID_USER = '" + ID + "' AND CART.ID_CART = '" + CART.ToString() + "'";
                cmd.ExecuteNonQuery();

                cart_panel.Visible = false;
                panel3.Visible = true;
                panel3.BringToFront();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT CART.ID_USER, CART.ID_CART, SUM(CART.QUANTITY)AS QUAN, ITEM.TEN, Item.GIA, Item.PICTURE, CART.ITEM_ID, CART.PAY, CART.PAY_ADDRESS, Item.TRADEMARK, Item.DISCOUNT, Item.CLASS, Item.ID" +
                                                  " FROM CART, Item WHERE CART.ID_USER = '" + ID + "' AND CART.ITEM_ID = Item.ID AND CART.ID_CART = '" + CART + "'" +
                                                  " group by CART.ID_USER, CART.ID_CART, CART.QUANTITY, ITEM.TEN, Item.GIA, Item.PICTURE, CART.ITEM_ID, CART.PAY, CART.PAY_ADDRESS, Item.TRADEMARK, Item.DISCOUNT, Item.CLASS, Item.ID", consql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BarcodeLib.Barcode code128;
                code128 = new Barcode();
                Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, CART.ToString());
                barcode_pic.Image = barcode;
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(CART.ToString(), QRCodeGenerator.ECCLevel.Q));
                QRcode_pic.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = ("RP/Report1.rdlc");
                ReportDataSource rds = new ReportDataSource("DataSet2", dt);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
                consql.Close();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
            CART = CART + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            style_panel = 2;
            consql.Open();
            flowLayoutPanel5.Controls.Clear();
            SqlDataAdapter da_OP = new SqlDataAdapter();
            da_OP.SelectCommand = new SqlCommand("select * from Item where CLASS = 'HEADPHONE'", consql);
            DataTable dt_OP = new DataTable();
            da_OP.Fill(dt_OP);
            List_Item[] listitem = new List_Item[100];
            String t, d, p, g, da;
            int i = 0;
            flowLayoutPanel5.Visible = true;
            flowLayoutPanel5.BringToFront();
            label7.Visible = true; label7.BringToFront();
            label7.BringToFront();
            flowLayoutPanel2.Visible = false;
            label7.Visible = true; label7.BringToFront();
            if (dt_OP.Rows.Count == 0)
            {
                var label1 = new System.Windows.Forms.Label();
                label1.Location = new System.Drawing.Point(0, 0);
                label1.Size = new System.Drawing.Size(1000, 500);
                label1.Text = "No products found matching your search";
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
                flowLayoutPanel5.Controls.Add(label1);
            }
            foreach (DataRow row in dt_OP.Rows)
            {
                listitem[i] = new List_Item();
                listitem[i].Ten = row["TEN"].ToString();
                listitem[i].Discount = row["DISCOUNT"].ToString() + "%";
                listitem[i].Picture = Image.FromFile(row["PICTURE"].ToString());
                listitem[i].Gia = row["GIA"].ToString() + "d";
                listitem[i].Danhgia = row["DANHGIA"].ToString() + "sao";
                t = listitem[i].Ten;
                d = row["DISCOUNT"].ToString();
                p = row["PICTURE"].ToString();
                g = row["GIA"].ToString();
                da = listitem[i].Danhgia;
                string ID = row["ID"].ToString();
                flowLayoutPanel5.Controls.Add(listitem[i]);
                listitem[i].Click += (s, ee) => Changepanel1(
                    ID);
                i = i + 1;
            }
            consql.Close();
        }
        private void Changepanel1(string ID)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel5.Visible = false;
            Login_panel.Visible = false;
            cart_panel.Visible = false;
            label7.Visible = false;
            consql.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Item JOIN HEADPHONE_INFO ON Item.ID = HEADPHONE_INFO.INFO_ID WHERE Item.ID = " + ID, consql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            headphone_info info = new headphone_info();
            foreach (DataRow row in dt.Rows)
            {
                int x = int.Parse(row["GIA"].ToString());
                int y = int.Parse(row["DISCOUNT"].ToString());
                int temp = (x*100)/(100-y);
                string id = row["ID"].ToString();
                info.info_Baseprice = temp.ToString();
                info.info_Discount = row["DISCOUNT"].ToString();
                info.info_Picture = Image.FromFile(row["INFO"].ToString());
                info.info_Price = row["GIA"].ToString();
                info.info_Ten = row["TEN"].ToString();
                info.info_Danhgia = row["DANHGIA"].ToString();
                info.Picture = Image.FromFile(row["PICTURE"].ToString());
                info.Add_cart_click += (s, ee) => addcart_headphone(id, info);
            }
            var panel = new Panel { Name = "newpanel" };
            panel.Location = new System.Drawing.Point(251, 142);
            panel.Size = new System.Drawing.Size(1672, 881);
            panel.Controls.Add(info);
            Controls.Add(panel);
            panel.BringToFront();
            return_label.Visible = true;
            return_label.Click += new EventHandler(Return_label_Click1);
            consql.Close();
        }
        private void Return_label_Click1(object sender, EventArgs e)
        {
            //Panel p = sender as Panel;
            return_label.Visible = false;
            var panel = Controls["newpanel"];
            Controls.Remove(panel);
            if (style_panel == 0)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = false;
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 1)
            {
                flowLayoutPanel2.Visible = true;
                flowLayoutPanel2.BringToFront();
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 2)
            {
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = true;
                flowLayoutPanel5.BringToFront();
                label7.Visible = true; label7.BringToFront(); label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
        }
        private void addcart_headphone(string st, headphone_info ifo)
        {
            if (ID == "-1")
            {
                MessageBox.Show("Please login first!!!");
            }
            else
            {
                consql.Open();
                var cmd = consql.CreateCommand();
                cmd.CommandText = "INSERT INTO CART VALUES (@cart, @user, @id_item, @quantity, null, 0)";
                cmd.Parameters.AddWithValue("@cart", CART);
                cmd.Parameters.AddWithValue("@user", ID);
                cmd.Parameters.AddWithValue("@id_item", st);
                cmd.Parameters.AddWithValue("@quantity", ifo.info_Quantity);
                cmd.ExecuteNonQuery();
                consql.Close();
            }
        }

        private void Phone_button_Click(object sender, EventArgs e)
        {
            style_panel = 0;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
        }

        private void return_homepage_Click(object sender, EventArgs e)
        {
            Login.Enabled = true;
            if (style_panel == 0)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = false;
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 1)
            {
                flowLayoutPanel2.Visible = true;
                flowLayoutPanel2.BringToFront();
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = false;
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
            else if (style_panel == 2)
            {
                flowLayoutPanel2.Visible = false;
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel5.Visible = true;
                flowLayoutPanel5.BringToFront();
                label7.Visible = true; label7.BringToFront();
                Topic_panel.Visible = true;
                Topic_panel.BringToFront();
            }
        }
    }
}
