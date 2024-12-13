using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable key events to be handled by the form
          
        }


        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculty.ToList();
                List<Student> listStudent = context.Student.Include(s => s.Faculty).ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[1].Value = item.FullName;
                dgvStudents.Rows[index].Cells[2].Value = item.Faculty != null ? item.Faculty.FacultyName : "N/A";
                dgvStudents.Rows[index].Cells[3].Value = item.AverageScore.HasValue
    ? Math.Round(item.AverageScore.Value, 1).ToString("0.0", CultureInfo.InvariantCulture)
    : string.Empty;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtAverageScore.Text) || cmbFaculty.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtAverageScore.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float dtb) || dtb < 0.0f || dtb > 10.0f)
                {
                    MessageBox.Show("Điểm trung bình phải là số từ 0.0 đến 10.0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtFullName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Họ tên không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                List<Student> studentLst = db.Student.Include(s => s.Faculty).ToList();
                if (studentLst.Any(s => s.StudentID == txtStudentId.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStudent = new Student
                {
                    StudentID = txtStudentId.Text,
                    FullName = txtFullName.Text,
                    AverageScore = Math.Round(dtb, 1), 
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                };


                db.Student.Add(newStudent);
                db.SaveChanges();

                BindGrid(db.Student.Include(s => s.Faculty).ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtAverageScore.Text) || cmbFaculty.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtAverageScore.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float dtb) || dtb < 0.0f || dtb > 10.0f)
                {
                    MessageBox.Show("Điểm trung bình phải là số từ 0.0 đến 10.0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                List<Student> students = db.Student.ToList();
                var student = students.FirstOrDefault(s => s.StudentID == txtStudentId.Text);
                if (student != null)
                {
                    if (students.Any(s => s.StudentID == txtStudentId.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    student.FullName = txtFullName.Text;
                    student.AverageScore = Math.Round(dtb, 1);
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());

                    db.SaveChanges();

                    BindGrid(db.Student.ToList());

                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB db = new StudentContextDB();
                List<Student> studentList = db.Student.ToList();

                var student = studentList.FirstOrDefault(s => s.StudentID == txtStudentId.Text);

                if (student != null)
                {
                    db.Student.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.Student.ToList());

                    MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStudents.Rows[e.RowIndex];

                txtStudentId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtFullName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                cmbFaculty.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                txtAverageScore.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
            }
        }

        private void quảnLýKhoaF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
            this.Hide();
        }

        private void tìmKiếmCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmStudentManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                quảnLýKhoaF2ToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                tìmKiếmCtrlFToolStripMenuItem_Click(sender, e);
            }
        }


        private void frmStudentManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
