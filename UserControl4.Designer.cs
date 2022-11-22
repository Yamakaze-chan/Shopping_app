namespace Shopping_app
{
    partial class headphone_info
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.add_cart = new System.Windows.Forms.Button();
            this.info_judge = new System.Windows.Forms.Label();
            this.info_name = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.baseprice = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(481, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 50);
            this.label7.TabIndex = 24;
            this.label7.Text = "1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_cart
            // 
            this.add_cart.Location = new System.Drawing.Point(531, 622);
            this.add_cart.Name = "add_cart";
            this.add_cart.Size = new System.Drawing.Size(200, 50);
            this.add_cart.TabIndex = 23;
            this.add_cart.Text = "ADD TO CART";
            this.add_cart.UseVisualStyleBackColor = true;
            this.add_cart.Click += new System.EventHandler(this.add_cart_Click);
            // 
            // info_judge
            // 
            this.info_judge.Location = new System.Drawing.Point(458, 481);
            this.info_judge.Name = "info_judge";
            this.info_judge.Size = new System.Drawing.Size(177, 46);
            this.info_judge.TabIndex = 22;
            this.info_judge.Text = "danhgia";
            this.info_judge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_name
            // 
            this.info_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_name.ForeColor = System.Drawing.Color.Red;
            this.info_name.Location = new System.Drawing.Point(458, 127);
            this.info_name.Name = "info_name";
            this.info_name.Size = new System.Drawing.Size(388, 80);
            this.info_name.TabIndex = 21;
            this.info_name.Text = "Phone";
            this.info_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Discount.Location = new System.Drawing.Point(456, 276);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 23);
            this.Discount.TabIndex = 20;
            this.Discount.Text = "SALE";
            // 
            // baseprice
            // 
            this.baseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseprice.ForeColor = System.Drawing.Color.Silver;
            this.baseprice.Location = new System.Drawing.Point(452, 235);
            this.baseprice.Name = "baseprice";
            this.baseprice.Size = new System.Drawing.Size(197, 41);
            this.baseprice.TabIndex = 19;
            this.baseprice.Text = "base price";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(450, 374);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(400, 61);
            this.price.TabIndex = 18;
            this.price.Text = "PRICE";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1014, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(580, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1014, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product information";
            // 
            // headphone_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_cart);
            this.Controls.Add(this.info_judge);
            this.Controls.Add(this.info_name);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.baseprice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pictureBox1);
            this.Name = "headphone_info";
            this.Size = new System.Drawing.Size(1672, 881);
            this.Load += new System.EventHandler(this.headphone_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_cart;
        private System.Windows.Forms.Label info_judge;
        private System.Windows.Forms.Label info_name;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label baseprice;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
