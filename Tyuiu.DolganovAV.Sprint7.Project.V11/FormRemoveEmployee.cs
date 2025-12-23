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
    public partial class FormRemoveEmployee : Form
    {
        public int EmployeeId { get; private set; }
        public bool ConfirmedRmv { get; private set; }
        public FormRemoveEmployee(Employee employee)
        {
            InitializeComponent();
            EmployeeId = employee.Id;
            ConfirmedRmv = false;
            DisplayEmployeeInfo(employee);
        }
        private void DisplayEmployeeInfo(Employee employee)
        {
            string employeeInfo = $"ID: {employee.Id}\n" +
                $"Фамилия: {employee.LastName}\n" +
                $"Имя: {employee.FirstName}\n" +
                $"Отчество: {employee.MiddleName}\n" +
                $"Стаж: {employee.ExperienceYears}\n" +
                $"Зарплата: {employee.Salary}\n" +
                $"Отдел: {employee.Department}";
            labelEmpInfo_DAV.Text = employeeInfo;
        }
        private void buttonRemoveEmp_DAV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы дейстивтельно хотите удалить этого сотрудника? Это действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ConfirmedRmv = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_DAV_Click(object sender, EventArgs e)
        {
            ConfirmedRmv = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
