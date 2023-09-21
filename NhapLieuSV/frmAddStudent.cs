using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapLieuSV
{
    public partial class frmAddStudent : Form
    {
        List<Student> students;
        DataGridView dgvStudent;
        public frmAddStudent()
        {
            InitializeComponent();
        }

        public frmAddStudent(DataGridView dgvStudent, List<Student> students)
        {
            InitializeComponent();
            this.dgvStudent = dgvStudent;
            this.students = students;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private int GetSelectedRow(string stdID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value?.ToString() == stdID)
                {
                    return i;
                }

            }
            return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtStdName.Text);

            if (txtStdID.Text=="" || txtStdName.Text=="" || txtAvgScore.Text == "" || cmbFaculty.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin!!");
            }
            else if(students.Where(s=>s.StdID == txtStdID.Text).Count() > 0)
            {
                MessageBox.Show("Sinh vien nay da ton tai!!");

            }else if (Convert.ToDouble(txtAvgScore.Text) <0 || Convert.ToDouble(txtAvgScore.Text) >10)
            {
                MessageBox.Show("Loi dinh dang nhap diem 0-10!!");
                txtAvgScore.Focus();

            }
            else
            {
                students.Add(new Student() { Stt = students.Count() + 1, StdID = txtStdID.Text, StdName = txtStdName.Text, StdAvgScore = Convert.ToDouble(txtAvgScore.Text), StdFaculty = cmbFaculty.Text }); ;
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = students;
                MessageBox.Show("Them moi thanh cong", "Thong bao", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
