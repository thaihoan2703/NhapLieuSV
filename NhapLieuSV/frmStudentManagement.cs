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
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent(dgvStudent,students);
            frmAddStudent.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent(dgvStudent, students);
            frmAddStudent.ShowDialog();
        }

        private void toolStripTextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
        
            string searchText = toolStripTextBoxSearch.Text;
            if(searchText == "")
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = students;

            }
            else
            {
                var studentSearch = students.Where(s=>s.StdName.Contains(searchText)).ToList();
                if(studentSearch.Count > 0)
                {
                    foreach (var std in studentSearch)
                    {
                        dgvStudent.DataSource = null;
                        dgvStudent.DataSource = studentSearch;
                    }
                }
                else
                {
                    dgvStudent.DataSource = null;

                }
            }
        }
    }
}
