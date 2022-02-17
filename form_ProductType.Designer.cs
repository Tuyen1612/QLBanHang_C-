
namespace qlbanhang_csharp
{
    partial class form_ProductType
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_tenLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_loaiSP = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_themLoaiSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_suaLoaiSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_them = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(12, 106);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(77, 24);
            this.btn_xoa.TabIndex = 84;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(197, 72);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(77, 24);
            this.btn_huy.TabIndex = 83;
            this.btn_huy.Text = "Làm mới";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(104, 106);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(77, 24);
            this.btn_sua.TabIndex = 82;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // txt_tenLoai
            // 
            this.txt_tenLoai.Location = new System.Drawing.Point(50, 75);
            this.txt_tenLoai.Name = "txt_tenLoai";
            this.txt_tenLoai.Size = new System.Drawing.Size(135, 20);
            this.txt_tenLoai.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Tên Nhân viên:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên loại";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Loại SP";
            this.columnHeader1.Width = 80;
            // 
            // lstView_loaiSP
            // 
            this.lstView_loaiSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstView_loaiSP.GridLines = true;
            this.lstView_loaiSP.HideSelection = false;
            this.lstView_loaiSP.LabelEdit = true;
            this.lstView_loaiSP.Location = new System.Drawing.Point(12, 136);
            this.lstView_loaiSP.MultiSelect = false;
            this.lstView_loaiSP.Name = "lstView_loaiSP";
            this.lstView_loaiSP.Size = new System.Drawing.Size(262, 293);
            this.lstView_loaiSP.TabIndex = 78;
            this.lstView_loaiSP.UseCompatibleStateImageBehavior = false;
            this.lstView_loaiSP.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_themLoaiSP,
            this.mnu_suaLoaiSP});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // mnu_themLoaiSP
            // 
            this.mnu_themLoaiSP.Name = "mnu_themLoaiSP";
            this.mnu_themLoaiSP.Size = new System.Drawing.Size(181, 22);
            this.mnu_themLoaiSP.Text = "Thêm loại sản phẩm";
            // 
            // mnu_suaLoaiSP
            // 
            this.mnu_suaLoaiSP.Name = "mnu_suaLoaiSP";
            this.mnu_suaLoaiSP.Size = new System.Drawing.Size(181, 22);
            this.mnu_suaLoaiSP.Text = "Sửa loại sản phẩm";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(197, 106);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(77, 24);
            this.btn_them.TabIndex = 79;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // form_ProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 438);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.txt_tenLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstView_loaiSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_them);
            this.Name = "form_ProductType";
            this.Text = "form_ProductType";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_tenLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstView_loaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_themLoaiSP;
        private System.Windows.Forms.ToolStripMenuItem mnu_suaLoaiSP;
        private System.Windows.Forms.Button btn_them;
    }
}