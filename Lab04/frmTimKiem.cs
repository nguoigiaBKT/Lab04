using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFacultyCombobox();
                txtResult.Text = "0"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadFacultyCombobox()
        {
            using (StudentContextDB context = new StudentContextDB())
            {
                List<Faculty> listFaculties = context.Faculty.ToList();
                FillFacultyCombobox(listFaculties);
            }
        }

        private void FillFacultyCombobox(List<Faculty> listFaculties)
        {
            cmbFaculty.DataSource = null;
            cmbFaculty.DataSource = listFaculties;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
            cmbFaculty.SelectedIndex = -1;

            foreach (var faculty in listFaculties)
            {
                Console.WriteLine($"FacultyID: {faculty.FacultyID}, FacultyName: {faculty.FacultyName}");
            }
            Console.WriteLine($"cmbFaculty.Items.Count: {cmbFaculty.Items.Count}");
            Console.WriteLine($"cmbFaculty.SelectedValue: {cmbFaculty.SelectedValue}");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentContextDB context = new StudentContextDB())
                {
                    IQueryable<Student> query = context.Student.Include(s => s.Faculty);

             
                    if (!string.IsNullOrWhiteSpace(txtStudentId.Text))
                    {
                        query = query.Where(s => s.StudentID.Contains(txtStudentId.Text));
                    }

                
                    if (!string.IsNullOrWhiteSpace(txtFullName.Text))
                    {
                        query = query.Where(s => s.FullName.Contains(txtFullName.Text) || s.FullName.EndsWith(" " + txtFullName.Text));
                    }

                  
                    if (cmbFaculty.SelectedItem != null) 
                    {
                        var selectedFaculty = cmbFaculty.SelectedItem as Faculty;
                        if (selectedFaculty != null)
                        {
                            query = query.Where(s => s.FacultyID == selectedFaculty.FacultyID);
                        }
                    }

             
                    List<Student> listStudent = query.ToList();
                    BindGrid(listStudent);
                    txtResult.Text = $"{listStudent.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();
            txtResult.Text = "0";
            cmbFaculty.SelectedIndex = -1; 
            txtStudentId.Clear(); 
            txtFullName.Clear();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmStudentManagement frmStudentManagement = new frmStudentManagement();
            frmStudentManagement.Show();
            this.Hide();
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[1].Value = item.FullName;
                dgvStudents.Rows[index].Cells[2].Value = item.Faculty != null ? item.Faculty.FacultyName : "Empty";
                dgvStudents.Rows[index].Cells[3].Value = item.AverageScore.HasValue ? item.AverageScore.Value.ToString("F1", CultureInfo.InvariantCulture) : string.Empty;
            }
        }


        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
