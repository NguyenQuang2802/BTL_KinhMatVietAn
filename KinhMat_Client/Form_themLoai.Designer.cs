
namespace KinhMat_Client
{
    partial class Form_themLoai
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Loai = new System.Windows.Forms.DataGridView();
            this.tb_keyLoai = new System.Windows.Forms.TextBox();
            this.bt_keyLoai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tenLoai = new System.Windows.Forms.TextBox();
            this.tb_maLoai = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Loai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_Loai);
            this.groupBox2.Controls.Add(this.tb_keyLoai);
            this.groupBox2.Controls.Add(this.bt_keyLoai);
            this.groupBox2.Location = new System.Drawing.Point(253, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // DGV_Loai
            // 
            this.DGV_Loai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_Loai.Location = new System.Drawing.Point(3, 39);
            this.DGV_Loai.Name = "DGV_Loai";
            this.DGV_Loai.Size = new System.Drawing.Size(250, 306);
            this.DGV_Loai.TabIndex = 0;
            this.DGV_Loai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Loai_CellContentClick);
            // 
            // tb_keyLoai
            // 
            this.tb_keyLoai.Location = new System.Drawing.Point(50, 13);
            this.tb_keyLoai.Name = "tb_keyLoai";
            this.tb_keyLoai.Size = new System.Drawing.Size(100, 20);
            this.tb_keyLoai.TabIndex = 1;
            // 
            // bt_keyLoai
            // 
            this.bt_keyLoai.Location = new System.Drawing.Point(156, 11);
            this.bt_keyLoai.Name = "bt_keyLoai";
            this.bt_keyLoai.Size = new System.Drawing.Size(75, 23);
            this.bt_keyLoai.TabIndex = 0;
            this.bt_keyLoai.Text = "Tìm Kiếm";
            this.bt_keyLoai.UseVisualStyleBackColor = true;
            this.bt_keyLoai.Click += new System.EventHandler(this.bt_keyLoai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_tenLoai);
            this.groupBox1.Controls.Add(this.tb_maLoai);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Location = new System.Drawing.Point(1, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Loại";
            // 
            // tb_tenLoai
            // 
            this.tb_tenLoai.Location = new System.Drawing.Point(95, 109);
            this.tb_tenLoai.Name = "tb_tenLoai";
            this.tb_tenLoai.Size = new System.Drawing.Size(100, 20);
            this.tb_tenLoai.TabIndex = 1;
            // 
            // tb_maLoai
            // 
            this.tb_maLoai.Location = new System.Drawing.Point(95, 68);
            this.tb_maLoai.Name = "tb_maLoai";
            this.tb_maLoai.Size = new System.Drawing.Size(100, 20);
            this.tb_maLoai.TabIndex = 1;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(144, 264);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 0;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(24, 264);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 0;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(144, 212);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 0;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(24, 212);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maloai";
            this.Column1.HeaderText = "Mã Loại";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenloai";
            this.Column2.HeaderText = "Tên Loại";
            this.Column2.Name = "Column2";
            // 
            // Form_themLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_themLoai";
            this.Text = "Form_themLoai";
            this.Load += new System.EventHandler(this.Form_themLoai_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Loai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_Loai;
        private System.Windows.Forms.TextBox tb_keyLoai;
        private System.Windows.Forms.Button bt_keyLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_maLoai;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}