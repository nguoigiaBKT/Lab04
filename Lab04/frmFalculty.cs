using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFaculties = context.Faculty.ToList();
                BindGrid(listFaculties);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text) || string.IsNullOrWhiteSpace(txtFacultyName.Text) || string.IsNullOrWhiteSpace(txtTotalProfessor.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtTotalProfessor.Text, out int totalProfessor))
                {
                    MessageBox.Show("Tổng số GS phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                int facultyID = int.Parse(txtFacultyID.Text);
                var faculty = db.Faculty.FirstOrDefault(f => f.FacultyID == facultyID);

                if (faculty == null)
                {
                    var newFaculty = new Faculty
                    {
                        FacultyID = facultyID,
                        FacultyName = txtFacultyName.Text,
                        TotalProfessor = totalProfessor
                    };

                    db.Faculty.Add(newFaculty);
                    MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    faculty.FacultyName = txtFacultyName.Text;
                    faculty.TotalProfessor = totalProfessor;
                    MessageBox.Show("Cập nhật khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                db.SaveChanges();
                BindGrid(db.Faculty.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm/cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentContextDB db = new StudentContextDB();
                int facultyID = int.Parse(txtFacultyID.Text);
                var faculty = db.Faculty.FirstOrDefault(f => f.FacultyID == facultyID);

                if (faculty != null)
                {
                    db.Faculty.Remove(faculty);
                    db.SaveChanges();
                    BindGrid(db.Faculty.ToList());
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFaculties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFaculties.Rows[e.RowIndex];
                txtFacultyID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                txtFacultyName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtTotalProfessor.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BindGrid(List<Faculty> listFaculties)
        {
            dgvFaculties.Rows.Clear();
            foreach (var item in listFaculties)
            {
                int index = dgvFaculties.Rows.Add();
                dgvFaculties.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculties.Rows[index].Cells[1].Value = item.FacultyName;
                dgvFaculties.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        private void frmFaculty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
