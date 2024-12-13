namespace Lab04
{
    partial class frmFaculty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFaculties = new System.Windows.Forms.DataGridView();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonggs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(65, 302);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(110, 47);
            this.btnThemSua.TabIndex = 52;
            this.btnThemSua.Text = "Thêm / Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(213, 302);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 47);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtTotalProfessor);
            this.grpInput.Controls.Add(this.txtFacultyName);
            this.grpInput.Controls.Add(this.txtFacultyID);
            this.grpInput.Controls.Add(this.label6);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Location = new System.Drawing.Point(32, 64);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(322, 217);
            this.grpInput.TabIndex = 51;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông Tin Khoa";
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(128, 122);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(84, 22);
            this.txtTotalProfessor.TabIndex = 11;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(128, 78);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(161, 22);
            this.txtFacultyName.TabIndex = 10;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(128, 40);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(161, 22);
            this.txtFacultyID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng số GS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khoa";
            // 
            // dgvFaculties
            // 
            this.dgvFaculties.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoa,
            this.tenkhoa,
            this.tonggs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaculties.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaculties.Location = new System.Drawing.Point(384, 88);
            this.dgvFaculties.Name = "dgvFaculties";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculties.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFaculties.RowHeadersWidth = 51;
            this.dgvFaculties.RowTemplate.Height = 24;
            this.dgvFaculties.Size = new System.Drawing.Size(670, 261);
            this.dgvFaculties.TabIndex = 54;
            this.dgvFaculties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculties_CellContentClick);
            // 
            // makhoa
            // 
            this.makhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkhoa.HeaderText = "Tên Khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            // 
            // tonggs
            // 
            this.tonggs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tonggs.HeaderText = "Tổng số GS";
            this.tonggs.MinimumWidth = 6;
            this.tonggs.Name = "tonggs";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(970, 381);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(84, 47);
            this.btnDong.TabIndex = 55;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 539);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvFaculties);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpInput);
            this.Name = "frmFaculty";
            this.Text = "Quản Lý Khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFaculty_FormClosing);
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFaculties;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonggs;
        private System.Windows.Forms.Button btnDong;
    }
}