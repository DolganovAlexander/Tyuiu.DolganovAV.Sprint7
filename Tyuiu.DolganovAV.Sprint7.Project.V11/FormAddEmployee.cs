using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;
namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    public partial class FormAddEmployee : Form
    {
        public Employee NewEmployee { get; private set; }
        public FormAddEmployee()
        {
            InitializeComponent();
            NewEmployee = new Employee();
        }

        private void buttonAddEmp_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxLastName_DAV.Text) || string.IsNullOrEmpty(textBoxFirstName_DAV.Text))
                {
                    MessageBox.Show("Заполните обязательные поля (Фамилия, Имя)!");
                    return;
                }
                NewEmployee.LastName = textBoxLastName_DAV.Text;
                NewEmployee.FirstName = textBoxFirstName_DAV.Text;
                NewEmployee.MiddleName = textBoxMiddleName_DAV.Text;
                NewEmployee.BirthDate = DateTime.Parse(textBoxBirthDate_DAV.Text);
                NewEmployee.ExperienceYears = int.Parse(textBoxExpYears_DAV.Text);
                NewEmployee.Salary = decimal.Parse(textBoxSalary_DAV.Text);
                NewEmployee.Department = textBoxDepartment_DAV.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода данных: {ex.Message}");
            }
        }

        private void buttonCancel_DAV_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            textBoxBirthDate_DAV.Text = DateTime.Now.AddYears(-30).ToString("yyyy-MM-dd");
            textBoxExpYears_DAV.Text = "0";
            textBoxSalary_DAV.Text = "0";
        }
    }
}
