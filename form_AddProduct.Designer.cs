
namespace qlbanhang_csharp
{
    partial class form_AddProduct
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
            this.lbl_themSanPham = new System.Windows.Forms.Label();
            this.lstView_dsSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_IDNCC = new System.Windows.Forms.Label();
            this.lbl_IDSP = new System.Windows.Forms.Label();
            this.lbl_tenSP = new System.Windows.Forms.Label();
            this.lbl_slTon = new System.Windows.Forms.Label();
            this.lbl_tenLoai = new System.Windows.Forms.Label();
            this.lbl_moTa = new System.Windows.Forms.Label();
            this.txt_IDNCC = new System.Windows.Forms.TextBox();
            this.txt_moTa = new System.Windows.Forms.TextBox();
            this.txt_tenLoai = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.txt_IDSP = new System.Windows.Forms.TextBox();
            this.txt_slTon = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.lbl_donGia = new System.Windows.Forms.Label();
            this.pic_anh = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_chonAnh = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_boQua = new System.Windows.Forms.Button();
            this.btn_chonAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).BeginInit();
            this.grp_chonAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_themSanPham
            // 
            this.lbl_themSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_themSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_themSanPham.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_themSanPham.ForeColor = System.Drawing.Color.White;
            this.lbl_themSanPham.Location = new System.Drawing.Point(0, 0);
            this.lbl_themSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_themSanPham.Name = "lbl_themSanPham";
            this.lbl_themSanPham.Size = new System.Drawing.Size(847, 47);
            this.lbl_themSanPham.TabIndex = 0;
            this.lbl_themSanPham.Text = "THÊM SẢN PHẨM";
            this.lbl_themSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstView_dsSP
            // 
            this.lstView_dsSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstView_dsSP.FullRowSelect = true;
            this.lstView_dsSP.GridLines = true;
            this.lstView_dsSP.HideSelection = false;
            this.lstView_dsSP.LabelEdit = true;
            this.lstView_dsSP.Location = new System.Drawing.Point(10, 153);
            this.lstView_dsSP.Name = "lstView_dsSP";
            this.lstView_dsSP.Size = new System.Drawing.Size(619, 485);
            this.lstView_dsSP.TabIndex = 23;
            this.lstView_dsSP.UseCompatibleStateImageBehavior = false;
            this.lstView_dsSP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID NCC";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID SP";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sản Phẩm";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô Tả";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên Loại";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Giá";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SL Tồn";
            this.columnHeader7.Width = 71;
            // 
            // lbl_IDNCC
            // 
            this.lbl_IDNCC.ForeColor = System.Drawing.Color.Black;
            this.lbl_IDNCC.Location = new System.Drawing.Point(12, 63);
            this.lbl_IDNCC.Name = "lbl_IDNCC";
            this.lbl_IDNCC.Size = new System.Drawing.Size(55, 21);
            this.lbl_IDNCC.TabIndex = 24;
            this.lbl_IDNCC.Text = "ID NCC:";
            // 
            // lbl_IDSP
            // 
            this.lbl_IDSP.ForeColor = System.Drawing.Color.Black;
            this.lbl_IDSP.Location = new System.Drawing.Point(12, 95);
            this.lbl_IDSP.Name = "lbl_IDSP";
            this.lbl_IDSP.Size = new System.Drawing.Size(55, 21);
            this.lbl_IDSP.TabIndex = 25;
            this.lbl_IDSP.Text = "ID SP:";
            // 
            // lbl_tenSP
            // 
            this.lbl_tenSP.ForeColor = System.Drawing.Color.Black;
            this.lbl_tenSP.Location = new System.Drawing.Point(7, 127);
            this.lbl_tenSP.Name = "lbl_tenSP";
            this.lbl_tenSP.Size = new System.Drawing.Size(55, 21);
            this.lbl_tenSP.TabIndex = 26;
            this.lbl_tenSP.Text = "Tên SP:";
            this.lbl_tenSP.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_slTon
            // 
            this.lbl_slTon.ForeColor = System.Drawing.Color.Black;
            this.lbl_slTon.Location = new System.Drawing.Point(278, 123);
            this.lbl_slTon.Name = "lbl_slTon";
            this.lbl_slTon.Size = new System.Drawing.Size(62, 21);
            this.lbl_slTon.TabIndex = 29;
            this.lbl_slTon.Text = "SL Tồn:";
            this.lbl_slTon.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_tenLoai
            // 
            this.lbl_tenLoai.ForeColor = System.Drawing.Color.Black;
            this.lbl_tenLoai.Location = new System.Drawing.Point(277, 65);
            this.lbl_tenLoai.Name = "lbl_tenLoai";
            this.lbl_tenLoai.Size = new System.Drawing.Size(73, 21);
            this.lbl_tenLoai.TabIndex = 28;
            this.lbl_tenLoai.Text = "Tên loại:";
            // 
            // lbl_moTa
            // 
            this.lbl_moTa.ForeColor = System.Drawing.Color.Black;
            this.lbl_moTa.Location = new System.Drawing.Point(568, 63);
            this.lbl_moTa.Name = "lbl_moTa";
            this.lbl_moTa.Size = new System.Drawing.Size(61, 21);
            this.lbl_moTa.TabIndex = 27;
            this.lbl_moTa.Text = "Mô tả:";
            // 
            // txt_IDNCC
            // 
            this.txt_IDNCC.Location = new System.Drawing.Point(108, 60);
            this.txt_IDNCC.Name = "txt_IDNCC";
            this.txt_IDNCC.Size = new System.Drawing.Size(155, 23);
            this.txt_IDNCC.TabIndex = 30;
            this.txt_IDNCC.TextChanged += new System.EventHandler(this.txt_IDNCC_TextChanged);
            // 
            // txt_moTa
            // 
            this.txt_moTa.Location = new System.Drawing.Point(640, 60);
            this.txt_moTa.Multiline = true;
            this.txt_moTa.Name = "txt_moTa";
            this.txt_moTa.Size = new System.Drawing.Size(195, 88);
            this.txt_moTa.TabIndex = 31;
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Location = new System.Drawing.Point(368, 62);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Size = new System.Drawing.Size(164, 23);
            this.txt_tenLoai.TabIndex = 32;
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Location = new System.Drawing.Point(108, 124);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(155, 23);
            this.txt_tenSP.TabIndex = 33;
            // 
            // txt_IDSP
            // 
            this.txt_IDSP.Location = new System.Drawing.Point(108, 92);
            this.txt_IDSP.Name = "txt_IDSP";
            this.txt_IDSP.Size = new System.Drawing.Size(155, 23);
            this.txt_IDSP.TabIndex = 34;
            this.txt_IDSP.TextChanged += new System.EventHandler(this.txt_IDSP_TextChanged);
            // 
            // txt_slTon
            // 
            this.txt_slTon.Location = new System.Drawing.Point(368, 123);
            this.txt_slTon.Name = "txt_slTon";
            this.txt_slTon.Size = new System.Drawing.Size(165, 23);
            this.txt_slTon.TabIndex = 35;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(7, 326);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(195, 42);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(368, 91);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(165, 23);
            this.txt_donGia.TabIndex = 38;
            // 
            // lbl_donGia
            // 
            this.lbl_donGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_donGia.Location = new System.Drawing.Point(278, 94);
            this.lbl_donGia.Name = "lbl_donGia";
            this.lbl_donGia.Size = new System.Drawing.Size(72, 21);
            this.lbl_donGia.TabIndex = 39;
            this.lbl_donGia.Text = "Đơn giá:";
            this.lbl_donGia.Click += new System.EventHandler(this.lbl_donGia_Click);
            // 
            // pic_anh
            // 
            this.pic_anh.Image = global::qlbanhang_csharp.Properties.Resources.b270a66dfcfede0729eb0ad5a2003b47;
            this.pic_anh.Location = new System.Drawing.Point(7, 22);
            this.pic_anh.Name = "pic_anh";
            this.pic_anh.Size = new System.Drawing.Size(195, 179);
            this.pic_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anh.TabIndex = 40;
            this.pic_anh.TabStop = false;
            this.pic_anh.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grp_chonAnh
            // 
            this.grp_chonAnh.Controls.Add(this.pictureBox3);
            this.grp_chonAnh.Controls.Add(this.pictureBox2);
            this.grp_chonAnh.Controls.Add(this.pictureBox1);
            this.grp_chonAnh.Controls.Add(this.button1);
            this.grp_chonAnh.Controls.Add(this.btn_boQua);
            this.grp_chonAnh.Controls.Add(this.btn_chonAnh);
            this.grp_chonAnh.Controls.Add(this.pic_anh);
            this.grp_chonAnh.Controls.Add(this.btn_them);
            this.grp_chonAnh.Location = new System.Drawing.Point(634, 173);
            this.grp_chonAnh.Name = "grp_chonAnh";
            this.grp_chonAnh.Size = new System.Drawing.Size(213, 465);
            this.grp_chonAnh.TabIndex = 41;
            this.grp_chonAnh.TabStop = false;
            this.grp_chonAnh.Text = "Chọn ảnh minh hoạ:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(136, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 58);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(72, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_boQua
            // 
            this.btn_boQua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boQua.Location = new System.Drawing.Point(7, 374);
            this.btn_boQua.Name = "btn_boQua";
            this.btn_boQua.Size = new System.Drawing.Size(195, 40);
            this.btn_boQua.TabIndex = 42;
            this.btn_boQua.Text = "Làm Mới";
            this.btn_boQua.UseVisualStyleBackColor = true;
            this.btn_boQua.Click += new System.EventHandler(this.btn_boQua_Click);
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonAnh.Location = new System.Drawing.Point(9, 271);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(195, 36);
            this.btn_chonAnh.TabIndex = 42;
            this.btn_chonAnh.Text = "Chọn ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            // 
            // form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 654);
            this.Controls.Add(this.grp_chonAnh);
            this.Controls.Add(this.lbl_donGia);
            this.Controls.Add(this.txt_donGia);
            this.Controls.Add(this.txt_slTon);
            this.Controls.Add(this.txt_IDSP);
            this.Controls.Add(this.txt_tenSP);
            this.Controls.Add(this.txt_tenLoai);
            this.Controls.Add(this.txt_moTa);
            this.Controls.Add(this.txt_IDNCC);
            this.Controls.Add(this.lbl_slTon);
            this.Controls.Add(this.lbl_tenLoai);
            this.Controls.Add(this.lbl_moTa);
            this.Controls.Add(this.lbl_tenSP);
            this.Controls.Add(this.lbl_IDSP);
            this.Controls.Add(this.lbl_IDNCC);
            this.Controls.Add(this.lstView_dsSP);
            this.Controls.Add(this.lbl_themSanPham);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_AddProduct";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).EndInit();
            this.grp_chonAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_themSanPham;
        private System.Windows.Forms.ListView lstView_dsSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbl_IDNCC;
        private System.Windows.Forms.Label lbl_IDSP;
        private System.Windows.Forms.Label lbl_tenSP;
        private System.Windows.Forms.Label lbl_slTon;
        private System.Windows.Forms.Label lbl_tenLoai;
        private System.Windows.Forms.Label lbl_moTa;
        private System.Windows.Forms.TextBox txt_IDNCC;
        private System.Windows.Forms.TextBox txt_moTa;
        private System.Windows.Forms.TextBox txt_tenLoai;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.TextBox txt_IDSP;
        private System.Windows.Forms.TextBox txt_slTon;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label lbl_donGia;
        private System.Windows.Forms.PictureBox pic_anh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_chonAnh;
        private System.Windows.Forms.Button btn_chonAnh;
        private System.Windows.Forms.Button btn_boQua;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

