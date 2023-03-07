namespace Lab1_Bai2_NguyenVanMinhHai
{
    partial class frmBai1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.picDen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.rdDen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thanhtien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tien = new System.Windows.Forms.Label();
            this.picXanh = new System.Windows.Forms.PictureBox();
            this.picTrang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // picDen
            // 
            this.picDen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDen.Cursor = System.Windows.Forms.Cursors.Default;
            this.picDen.Image = ((System.Drawing.Image)(resources.GetObject("picDen.Image")));
            this.picDen.Location = new System.Drawing.Point(37, 42);
            this.picDen.Name = "picDen";
            this.picDen.Size = new System.Drawing.Size(270, 184);
            this.picDen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDen.TabIndex = 0;
            this.picDen.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTrang);
            this.groupBox1.Controls.Add(this.rdXanh);
            this.groupBox1.Controls.Add(this.rdDen);
            this.groupBox1.Location = new System.Drawing.Point(357, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose Colors";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Checked = true;
            this.rdTrang.Location = new System.Drawing.Point(7, 66);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(53, 17);
            this.rdTrang.TabIndex = 0;
            this.rdTrang.TabStop = true;
            this.rdTrang.Text = "Trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(7, 43);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(50, 17);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.Text = "Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // rdDen
            // 
            this.rdDen.AutoSize = true;
            this.rdDen.Location = new System.Drawing.Point(7, 20);
            this.rdDen.Name = "rdDen";
            this.rdDen.Size = new System.Drawing.Size(45, 17);
            this.rdDen.TabIndex = 0;
            this.rdDen.Text = "Đen";
            this.rdDen.UseVisualStyleBackColor = true;
            this.rdDen.CheckedChanged += new System.EventHandler(this.rdDen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(414, 142);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(92, 20);
            this.txtgia.TabIndex = 3;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(414, 180);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(92, 20);
            this.txtsoluong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thành tiền";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // thanhtien
            // 
            this.thanhtien.Location = new System.Drawing.Point(402, 227);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(75, 23);
            this.thanhtien.TabIndex = 4;
            this.thanhtien.Text = "Thanh toán";
            this.thanhtien.UseVisualStyleBackColor = true;
            this.thanhtien.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 2;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "$";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // tien
            // 
            this.tien.AutoSize = true;
            this.tien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tien.Location = new System.Drawing.Point(435, 274);
            this.tien.Name = "tien";
            this.tien.Size = new System.Drawing.Size(13, 19);
            this.tien.TabIndex = 2;
            this.tien.Text = ".";
            this.tien.Click += new System.EventHandler(this.label1_Click);
            // 
            // picXanh
            // 
            this.picXanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picXanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picXanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.picXanh.Image = ((System.Drawing.Image)(resources.GetObject("picXanh.Image")));
            this.picXanh.Location = new System.Drawing.Point(37, 42);
            this.picXanh.Name = "picXanh";
            this.picXanh.Size = new System.Drawing.Size(270, 184);
            this.picXanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXanh.TabIndex = 0;
            this.picXanh.TabStop = false;
            // 
            // picTrang
            // 
            this.picTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTrang.Cursor = System.Windows.Forms.Cursors.Default;
            this.picTrang.Image = ((System.Drawing.Image)(resources.GetObject("picTrang.Image")));
            this.picTrang.Location = new System.Drawing.Point(37, 42);
            this.picTrang.Name = "picTrang";
            this.picTrang.Size = new System.Drawing.Size(270, 184);
            this.picTrang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrang.TabIndex = 0;
            this.picTrang.TabStop = false;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thanhtien);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picTrang);
            this.Controls.Add(this.picXanh);
            this.Controls.Add(this.picDen);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.RadioButton rdDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button thanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tien;
        private System.Windows.Forms.PictureBox picXanh;
        private System.Windows.Forms.PictureBox picTrang;
    }
}