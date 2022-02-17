
namespace qlbanhang_csharp
{
    partial class form_Color
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
            this.lbl_mau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_themSanPham
            // 
            this.lbl_themSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_themSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_themSanPham.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_themSanPham.ForeColor = System.Drawing.Color.White;
            this.lbl_themSanPham.Location = new System.Drawing.Point(0, 0);
            this.lbl_themSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_themSanPham.Name = "lbl_themSanPham";
            this.lbl_themSanPham.Size = new System.Drawing.Size(271, 58);
            this.lbl_themSanPham.TabIndex = 1;
            this.lbl_themSanPham.Text = "BẢNG MÀU";
            this.lbl_themSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mau
            // 
            this.lbl_mau.Location = new System.Drawing.Point(15, 76);
            this.lbl_mau.Name = "lbl_mau";
            this.lbl_mau.Size = new System.Drawing.Size(64, 23);
            this.lbl_mau.TabIndex = 2;
            this.lbl_mau.Text = "ID Màu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên màu:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 233);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Màu";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên màu";
            this.columnHeader2.Width = 146;
            // 
            // form_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 409);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_mau);
            this.Controls.Add(this.lbl_themSanPham);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Color";
            this.Text = "Form Màu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_themSanPham;
        private System.Windows.Forms.Label lbl_mau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}