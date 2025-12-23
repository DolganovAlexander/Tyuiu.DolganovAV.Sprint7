using System.Data;
using System.Text;
using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;
namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        private List<Employee> employees = new List<Employee>();
        private DataService ds = new DataService();
        private bool isSalaryAsc = true;
        private bool isExperienceAsc = true;
        private bool isLastNameAsc = true;
        private bool isIdAsc = true;
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DAV.Filter = "CSV Файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_DAV.Filter = "CSV Файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
        }

        private int GenNewId()
        {
            var allEmployees = ds.GetAllEmployees();
            if (allEmployees.Count == 0) return 1;
            return allEmployees.Max(e => e.Id) + 1;
        }

        private void buttonOpen_DAV_Click(object sender, EventArgs e)
        {
            if (openFileDialog_DAV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.LoadEmpFromFile(openFileDialog_DAV.FileName);
                    employees = ds.GetAllEmployees();

                    dataGridViewEmployee_DAV.DataSource = employees;


                    dataGridViewEmployee_DAV.Columns["Id"].HeaderText = "Табельный номер (Id)";
                    dataGridViewEmployee_DAV.Columns["LastName"].HeaderText = "Фамилия";
                    dataGridViewEmployee_DAV.Columns["FirstName"].HeaderText = "Имя";
                    dataGridViewEmployee_DAV.Columns["MiddleName"].HeaderText = "Отчество";
                    dataGridViewEmployee_DAV.Columns["BirthDate"].HeaderText = "Дата рождения";
                    dataGridViewEmployee_DAV.Columns["ExperienceYears"].HeaderText = "Стаж";
                    dataGridViewEmployee_DAV.Columns["Salary"].HeaderText = "Оклад";
                    dataGridViewEmployee_DAV.Columns["Department"].HeaderText = "Отдел";

                    dataGridViewEmployee_DAV.AllowUserToOrderColumns = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_DAV_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_DAV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.SaveEmpToFile(saveFileDialog_DAV.FileName);
                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSearch_DAV_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_DAV.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска!", "", MessageBoxButtons.OK);
                dataGridViewEmployee_DAV.DataSource = employees;
                return;
            }

            if (comboBoxSearchType_DAV.SelectedItem == null)
            {
                MessageBox.Show("Выберите режим поиска!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchMode = comboBoxSearchType_DAV.SelectedItem.ToString();
            List<Employee> results = new List<Employee>();
            switch (searchMode)
            {
                case "По ID":
                    try
                    {
                        int id = int.Parse(searchText);
                        var employee = ds.FindEmployeeById(id);
                        if (employee != null) results.Add(employee);
                    }
                    catch
                    {
                        MessageBox.Show("Введите конкретный табельный номер (Id)");
                    }
                    break;
                case "По фамилии":
                    results = ds.FindByFisrtName(searchText);
                    break;
                case "По отделу":
                    results = ds.FindByDepartment(searchText);
                    break;
            }

            dataGridViewEmployee_DAV.DataSource = results;
        }

        private void buttonAddEmployee_DAV_Click(object sender, EventArgs e)
        {
            FormAddEmployee addForm = new FormAddEmployee();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    addForm.NewEmployee.Id = GenNewId();

                    ds.AddEmployee(addForm.NewEmployee);
                    employees = ds.GetAllEmployees();

                    dataGridViewEmployee_DAV.DataSource = null;
                    dataGridViewEmployee_DAV.DataSource = employees;

                    MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEditEmployee_DAV_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee_DAV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var selectedRow = dataGridViewEmployee_DAV.SelectedRows[0];
                var idCell = selectedRow.Cells["Id"];
                if (idCell == null)
                {
                    MessageBox.Show("Ошибка: не удалось получить Табельный номер (Id) сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int employeeId = (int)idCell.Value;
                var employee = ds.FindEmployeeById(employeeId);
                if (employee == null)
                {
                    MessageBox.Show("Сотрудник не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                using (FormEditEmployee editForm = new FormEditEmployee(employee))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        if (ds.UpdateEmployee(employeeId, editForm.EditedEmployee))
                        {
                            employees = ds.GetAllEmployees();
                            dataGridViewEmployee_DAV.DataSource = null;
                            dataGridViewEmployee_DAV.DataSource = employees;

                            MessageBox.Show("Данные сотрудника обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при обновлении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveEmployee_DAV_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee_DAV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var selectedRow = dataGridViewEmployee_DAV.SelectedRows[0];
                var idCell = selectedRow.Cells["Id"];

                if (idCell == null)
                {
                    MessageBox.Show("Ошибка: не удалось получить табельный номер (Id) сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int employeeId = (int)idCell.Value;

                var employee = ds.FindEmployeeById(employeeId);
                if (employee == null)
                {
                    MessageBox.Show("Сотрудник не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                using (FormRemoveEmployee removeForm = new FormRemoveEmployee(employee))
                {
                    if (removeForm.ShowDialog() == DialogResult.OK && removeForm.ConfirmedRmv == true)
                    {
                        if (ds.RemoveEmployee(employeeId))
                        {
                            employees = ds.GetAllEmployees();
                            dataGridViewEmployee_DAV.DataSource = null;
                            dataGridViewEmployee_DAV.DataSource = employees;

                            MessageBox.Show("Сотрудник успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при удалении сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetCompInfo_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = ds.GetAllEmployees();

                if (employees.Count == 0)
                {
                    textBoxInfo_DAV.Text = "Нет данных о сотрудниках/компании";
                    return;
                }

                StringBuilder companyInfo = new StringBuilder();
                companyInfo.AppendLine("Статистика компании");
                companyInfo.AppendLine("===================");
                companyInfo.AppendLine($"Всего сотрудников: {employees.Count}");
                companyInfo.AppendLine($"Общий фонд оплаты труда: {ds.GetTotalSalary()}");
                companyInfo.AppendLine($"Средняя зарплата: {ds.GetAvgSalary()}");
                companyInfo.AppendLine($"Средний стаж: {ds.GetAvgExpYears()} лет");

                string resultText = companyInfo.ToString();
                textBoxInfo_DAV.Text = resultText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void buttonGetCharts_DAV_Click(object sender, EventArgs e)
        {
            var formChart = new FormCharts(employees);
            formChart.ShowDialog();
        }

        private void buttonSortBySalary_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> sortedEmployees;
                if (isSalaryAsc)
                {
                    sortedEmployees = ds.FilterBySalaryAscending();
                    buttonSortBySalary_DAV.Text = "Оклад ▲";
                }
                else
                {
                    sortedEmployees = ds.FilterBySalaryDescending();
                    buttonSortBySalary_DAV.Text = "Оклад ▼";
                }
                dataGridViewEmployee_DAV.DataSource = sortedEmployees;
                isSalaryAsc = !isSalaryAsc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}");
            }
        }

        private void buttonSortByExp_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> sortedEmployees;
                if (isExperienceAsc)
                {
                    sortedEmployees = ds.FilterByExperipenceAscending();
                    buttonSortByExp_DAV.Text = "Стаж ▲";
                }
                else
                {
                    sortedEmployees = ds.FilterByExperienceDescending();
                    buttonSortByExp_DAV.Text = "Стаж ▼";
                }
                dataGridViewEmployee_DAV.DataSource = sortedEmployees;
                isExperienceAsc = !isExperienceAsc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}");
            }
        }

        private void buttonSortByLastName_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> sortedEmployees;
                if (isLastNameAsc)
                {
                    sortedEmployees = ds.FilterByLastNameAscending();
                    buttonSortByLastName_DAV.Text = "Фамилия ▲";
                }
                else
                {
                    sortedEmployees = ds.FilterByLastNameDescending();
                    buttonSortByLastName_DAV.Text = "Фамилия ▼";
                }
                dataGridViewEmployee_DAV.DataSource = sortedEmployees;
                isLastNameAsc = !isLastNameAsc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}");
            }
        }

        private void buttonSortById_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> sortedEmployee;
                if (isIdAsc)
                {
                    sortedEmployee = ds.FilterByIdAscending();
                    buttonSortById_DAV.Text = "Табельный номер ▲";
                }
                else
                {
                    sortedEmployee = ds.FilterByIdDescending();
                    buttonSortById_DAV.Text = "Табельный номер ▼";
                }
                dataGridViewEmployee_DAV.DataSource = sortedEmployee;
                isIdAsc = !isIdAsc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}");
            }
        }
    }
}
