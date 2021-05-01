
namespace QLGV
{
    partial class fThemKhoa
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbMaK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemKhoa2 = new System.Windows.Forms.Button();
            this.bt_KXoa = new System.Windows.Forms.Button();
            this.bt_KLuuLai = new System.Windows.Forms.Button();
            this.bt_KLamTrong = new System.Windows.Forms.Button();
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbMaK);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(67, 363);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(472, 49);
            this.panel11.TabIndex = 9;
            // 
            // tbMaK
            // 
            this.tbMaK.Location = new System.Drawing.Point(153, 8);
            this.tbMaK.Name = "tbMaK";
            this.tbMaK.Size = new System.Drawing.Size(314, 27);
            this.tbMaK.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Khoa:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTenK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(67, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 49);
            this.panel1.TabIndex = 10;
            // 
            // tbTenK
            // 
            this.tbTenK.Location = new System.Drawing.Point(153, 8);
            this.tbTenK.Name = "tbTenK";
            this.tbTenK.Size = new System.Drawing.Size(314, 27);
            this.tbTenK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khoa:";
            // 
            // btThemKhoa2
            // 
            this.btThemKhoa2.Location = new System.Drawing.Point(657, 117);
            this.btThemKhoa2.Name = "btThemKhoa2";
            this.btThemKhoa2.Size = new System.Drawing.Size(182, 45);
            this.btThemKhoa2.TabIndex = 11;
            this.btThemKhoa2.Text = "Thêm Khoa";
            this.btThemKhoa2.UseVisualStyleBackColor = true;
            this.btThemKhoa2.Click += new System.EventHandler(this.btThemKhoa2_Click);
            // 
            // bt_KXoa
            // 
            this.bt_KXoa.Location = new System.Drawing.Point(657, 299);
            this.bt_KXoa.Name = "bt_KXoa";
            this.bt_KXoa.Size = new System.Drawing.Size(182, 45);
            this.bt_KXoa.TabIndex = 12;
            this.bt_KXoa.Text = "Xóa Khoa";
            this.bt_KXoa.UseVisualStyleBackColor = true;
            this.bt_KXoa.Click += new System.EventHandler(this.bt_KXoa_Click);
            // 
            // bt_KLuuLai
            // 
            this.bt_KLuuLai.Location = new System.Drawing.Point(657, 207);
            this.bt_KLuuLai.Name = "bt_KLuuLai";
            this.bt_KLuuLai.Size = new System.Drawing.Size(182, 45);
            this.bt_KLuuLai.TabIndex = 13;
            this.bt_KLuuLai.Text = "Lưu Lại";
            this.bt_KLuuLai.UseVisualStyleBackColor = true;
            this.bt_KLuuLai.Click += new System.EventHandler(this.bt_KLuuLai_Click);
            // 
            // bt_KLamTrong
            // 
            this.bt_KLamTrong.Location = new System.Drawing.Point(657, 28);
            this.bt_KLamTrong.Name = "bt_KLamTrong";
            this.bt_KLamTrong.Size = new System.Drawing.Size(182, 45);
            this.bt_KLamTrong.TabIndex = 14;
            this.bt_KLamTrong.Text = "Làm Trống";
            this.bt_KLamTrong.UseVisualStyleBackColor = true;
            this.bt_KLamTrong.Click += new System.EventHandler(this.bt_KLamTrong_Click);
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_Khoa.Location = new System.Drawing.Point(15, 28);
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.RowHeadersVisible = false;
            this.dgv_Khoa.RowHeadersWidth = 51;
            this.dgv_Khoa.RowTemplate.Height = 24;
            this.dgv_Khoa.Size = new System.Drawing.Size(612, 316);
            this.dgv_Khoa.TabIndex = 15;
            this.dgv_Khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKhoa";
            this.Column1.HeaderText = "Mã Khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKhoa";
            this.Column2.HeaderText = "Tên Khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // fThemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 485);
            this.Controls.Add(this.dgv_Khoa);
            this.Controls.Add(this.bt_KLamTrong);
            this.Controls.Add(this.bt_KLuuLai);
            this.Controls.Add(this.bt_KXoa);
            this.Controls.Add(this.btThemKhoa2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fThemKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khoa";
            this.Activated += new System.EventHandler(this.fThemKhoa_Activated);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbMaK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTenK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThemKhoa2;
        private System.Windows.Forms.Button bt_KXoa;
        private System.Windows.Forms.Button bt_KLuuLai;
        private System.Windows.Forms.Button bt_KLamTrong;
        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}