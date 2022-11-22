namespace Shopping_app
{
    partial class List_Item
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
            this.name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.KM = new System.Windows.Forms.Label();
            this.Judge = new System.Windows.Forms.Label();
            this.Anh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(15, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(170, 50);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.List_Item_Click);
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Red;
            this.Price.Location = new System.Drawing.Point(15, 260);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(170, 50);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Price.Click += new System.EventHandler(this.List_Item_Click);
            // 
            // KM
            // 
            this.KM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KM.ForeColor = System.Drawing.Color.Blue;
            this.KM.Location = new System.Drawing.Point(15, 232);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(170, 30);
            this.KM.TabIndex = 3;
            this.KM.Text = "- ?? %";
            this.KM.Click += new System.EventHandler(this.List_Item_Click);
            // 
            // Judge
            // 
            this.Judge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Judge.Location = new System.Drawing.Point(15, 315);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(104, 29);
            this.Judge.TabIndex = 4;
            this.Judge.Text = "Judgement";
            this.Judge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Judge.Click += new System.EventHandler(this.List_Item_Click);
            // 
            // Anh
            // 
            this.Anh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Anh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Anh.Location = new System.Drawing.Point(15, 15);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(170, 170);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anh.TabIndex = 0;
            this.Anh.TabStop = false;
            this.Anh.Click += new System.EventHandler(this.List_Item_Click);
            // 
            // List_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.KM);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Anh);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "List_Item";
            this.Size = new System.Drawing.Size(200, 370);
            this.Load += new System.EventHandler(this.List_Item_Load);
            this.Click += new System.EventHandler(this.List_Item_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Anh;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label KM;
        private System.Windows.Forms.Label Judge;
    }
}
