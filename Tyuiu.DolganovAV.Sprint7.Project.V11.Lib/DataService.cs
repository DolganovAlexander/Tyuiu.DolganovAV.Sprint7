using System.ComponentModel.Design;

namespace Tyuiu.DolganovAV.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        private List<Employee> employees;

        public DataService()
        {
            employees = new List<Employee>();
        }
        // ============= ADD/REMOVE EMPLOYEE
        public void AddEmployee(Employee employee) // добавление сотрудника
        {
            employees.Add(employee);
        }
        public bool RemoveEmployee(int id) // удаление сотрудника
        {
            // remove employee (id) самый простой способ, чтобы удалить сотрудника, при этом не допустив случайных ошибок
            // напр. удаление не того сотрудника из-за одинаковых фамилий
            var emp = employees.FirstOrDefault(e => e.Id == id); 
            if (emp != null)
            {
                employees.Remove(emp); 
                return true;
            }
            return false;
        }



        // ============= EDIT DATA?
        public bool UpdateEmployee(int id, Employee updatedEmployee) // обновляет/изменяет данные сотрудника
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.LastName = updatedEmployee.LastName;
                emp.FirstName = updatedEmployee.FirstName;
                emp.MiddleName = updatedEmployee.MiddleName;
                emp.BirthDate = updatedEmployee.BirthDate;
                emp.ExperienceYears = updatedEmployee.ExperienceYears;
                emp.Salary = updatedEmployee.Salary;
                emp.Department = updatedEmployee.Department;
                return true;
            }
            return false;
        }



        // ============= SEARCH DATA
        public List<Employee> GetAllEmployees() // получение всего списка работников
        {
            return employees;
        }
        public Employee FindEmployeeById(int id) // поиск по id
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
        public List<Employee> FindByFisrtName(string firstName) // поиск по фамилии
        {
            return employees.Where(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)).ToList();
            // StringComparsion.Ordinal... - сравнение без учета регистра
        }
        public List<Employee> FindByDepartment(string departmentName) // поиск по отделу
        {
            return employees.Where(e => e.Department.Equals(departmentName, StringComparison.OrdinalIgnoreCase)).ToList();
        }



        // ============= CSV FILES
        public void SaveEmpToFile(string filePath) //сохраниние
        {
            var lines = new List<string> { "Id,LastName,FirstName,MiddleName,BirthDate,ExperienceYears,Salary,Department" };
            foreach (var emp in employees)
            {
                lines.Add($"{emp.Id},{emp.LastName},{emp.FirstName},{emp.MiddleName},{emp.BirthDate:yyyy-MM-dd},{emp.ExperienceYears},{emp.Salary},{emp.Department}");
            }
            File.WriteAllLines(filePath, lines);
        }

        public void LoadEmpFromFile(string filePath) // загрузка из файла
        {
            employees.Clear();

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length < 8) continue;
                employees.Add(new Employee {
                    Id = int.Parse(parts[0]),
                    LastName = parts[1],
                    FirstName = parts[2],
                    MiddleName = parts[3],
                    BirthDate = DateTime.Parse(parts[4]),
                    ExperienceYears = int.Parse(parts[5]),
                    Salary = decimal.Parse(parts[6]),
                    Department = parts[7]
                });
            }
        }


        // ============= FILTERS
        public List<Employee> FilterByDepartment(string department) // фильтр по отделу
        {
            return employees.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Employee> FilterBySalary(decimal minSalary, decimal maxSalary) // фильт по диапазону зарплат
        {
            return employees.Where(e => e.Salary >= minSalary && e.Salary <= maxSalary).ToList();
        }
        public List<Employee> FilterBySalaryAscending() // фтльр по убываниб зарплат
        {
            return employees.OrderBy(e => e.Salary).ToList();
        }
        public List<Employee> FilterBySalaryDescending() // фильтр по возрастанию зарплат
        {
            return employees.OrderByDescending(e => e.Salary).ToList();
        }
        public List<Employee> FilterByExperipenceAscending() // фильтр по убыванию стажа
        {
            return employees.OrderBy(e => e.ExperienceYears).ToList();
        }
        public List<Employee> FilterByExperienceDescending() // фильтр по возрастанию стажа
        {
            return employees.OrderByDescending(e => e.ExperienceYears).ToList();
        }
        public List<Employee> FilterByLastNameAscending() // по возрастанию фамилий (от а до я)
        {
            return employees.OrderBy(e => e.LastName).ToList();
        }
        public List<Employee> FilterByLastNameDescending() // фильтр по убыанию фамилий (от я до а)
        {
            return employees.OrderByDescending(e => e.LastName).ToList();
        }

        // ============= STATISTIC
        public decimal GetTotalSalary() // общая сумма зарплат
        {
            return employees.Sum(e => e.Salary);
        }
        public decimal GetAvgSalary() // сердняя зп
        {
            if (employees.Count == 0) return 0;
            return employees.Average(e => e.Salary);
        }
        public int GetEmployeeCount() // количество сотрудников
        {
            return employees.Count();
        }
    }
}
