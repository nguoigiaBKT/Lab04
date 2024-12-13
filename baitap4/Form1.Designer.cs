namespace baitap4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowAll = new System.Windows.Forms.CheckBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaygiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbShowAll);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "~";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(374, 91);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(118, 22);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(184, 91);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 22);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời Gian Giao Hàng";
            // 
            // cbShowAll
            // 
            this.cbShowAll.AutoSize = true;
            this.cbShowAll.Location = new System.Drawing.Point(39, 34);
            this.cbShowAll.Name = "cbShowAll";
            this.cbShowAll.Size = new System.Drawing.Size(160, 20);
            this.cbShowAll.TabIndex = 0;
            this.cbShowAll.Text = "Xem tất cả trong tháng";
            this.cbShowAll.UseVisualStyleBackColor = true;
            this.cbShowAll.CheckedChanged += new System.EventHandler(this.cbShowAll_CheckedChanged);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStt,
            this.clSohd,
            this.clNgaydat,
            this.clNgaygiao,
            this.clThanhtien});
            this.dgvDonHang.Location = new System.Drawing.Point(22, 214);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(1063, 358);
            this.dgvDonHang.TabIndex = 1;
            // 
            // clStt
            // 
            this.clStt.HeaderText = "STT";
            this.clStt.MinimumWidth = 6;
            this.clStt.Name = "clStt";
            // 
            // clSohd
            // 
            this.clSohd.HeaderText = "Số HĐ";
            this.clSohd.MinimumWidth = 6;
            this.clSohd.Name = "clSohd";
            // 
            // clNgaydat
            // 
            this.clNgaydat.HeaderText = "Ngày Đặt Hàng";
            this.clNgaydat.MinimumWidth = 6;
            this.clNgaydat.Name = "clNgaydat";
            // 
            // clNgaygiao
            // 
            this.clNgaygiao.HeaderText = "Ngày Giao Hàng";
            this.clNgaygiao.MinimumWidth = 6;
            this.clNgaygiao.Name = "clNgaygiao";
            // 
            // clThanhtien
            // 
            this.clThanhtien.HeaderText = "Thành Tiền";
            this.clThanhtien.MinimumWidth = 6;
            this.clThanhtien.Name = "clThanhtien";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(870, 595);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(215, 22);
            this.txtTong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng Cộng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Thông Tin Đơn Hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaygiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhtien;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowAll;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

