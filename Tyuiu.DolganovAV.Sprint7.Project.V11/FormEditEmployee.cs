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
    public partial class FormEditEmployee : Form
    {
        public Employee EditedEmployee { get; private set; }
        private Employee originalEmployee;
        public FormEditEmployee(Employee employee)
        {
            InitializeComponent();
            originalEmployee = employee;
            EditedEmployee = new Employee {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                BirthDate = employee.BirthDate,
                ExperienceYears = employee.ExperienceYears,
                Salary = employee.Salary,
                Department = employee.Department
            };
            FillFields();

        }
        private void FillFields()
        {
            textBoxLastName_DAV.Text = EditedEmployee.LastName;
            textBoxFirstName_DAV.Text = EditedEmployee.FirstName;
            textBoxMiddleName_DAV.Text = EditedEmployee.MiddleName;
            textBoxBirthDate_DAV.Text = EditedEmployee.BirthDate.ToString("yyyy-MM-dd");
            textBoxExpYears_DAV.Text = EditedEmployee.ExperienceYears.ToString();
            textBoxSalary_DAV.Text = EditedEmployee.Salary.ToString();
            textBoxDepartment_DAV.Text = EditedEmployee.Department;
        }

        private void buttonEditEmp_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLastName_DAV.Text == null || textBoxFirstName_DAV.Text == null)
                {
                    MessageBox.Show("Заполните обязательные поля (Фамилия, Имя)!");
                }
                EditedEmployee.LastName = textBoxLastName_DAV.Text;
                EditedEmployee.FirstName = textBoxFirstName_DAV.Text;
                EditedEmployee.MiddleName = textBoxMiddleName_DAV.Text;

                try { EditedEmployee.BirthDate = DateTime.Parse(textBoxBirthDate_DAV.Text); }
                catch { }

                try { EditedEmployee.ExperienceYears = int.Parse(textBoxExpYears_DAV.Text); }
                catch { }

                try { EditedEmployee.Salary = decimal.Parse(textBoxSalary_DAV.Text); }
                catch { }

                EditedEmployee.Department = textBoxDepartment_DAV.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void buttonCancel_DAV_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
