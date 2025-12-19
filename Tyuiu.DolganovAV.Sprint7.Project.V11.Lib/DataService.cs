using System.ComponentModel.Design;

namespace Tyuiu.DolganovAV.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        private List<Employee> employees;
        private List<Department> departments;

        public DataService()
        {
            employees = new List<Employee>();
            departments = new List<Department>();
        }

        // ============= add data
        // employee add
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        // department add
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }



        // ============= remove data
        // remove employee (id) самый простой способ, чтобы удалить сотрудника, при этом не допустив случайных ошибок
        // напр. удаление не того сотрудника из-за одинаковых фамилий
        public bool RemoveEmployee(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp); 
                return true;
            }
            return false;
        }
        // remove department (name) тож самый простой способ, чтобы ниче не повторялось меби)
        public bool RemoveDepartment(string name)
        {
            var dmt = departments.FirstOrDefault(d => d.Name == name);
            if (dmt != null)
            {
                departments.Remove(dmt); 
                return true;
            }
            return false;
        }



        // ============= edit data
        // edit employee data / update employee
        public bool UpdateEmployee(int id, Employee updatedEmployee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.LastName = updatedEmployee.LastName;
                emp.FirstName = updatedEmployee.FirstName;
                emp.MiddleName = updatedEmployee.MiddleName;
                emp.Phone = updatedEmployee.Phone;
                emp.BirthDate = updatedEmployee.BirthDate;
                emp.ExperienceYears = updatedEmployee.ExperienceYears;
                emp.Salary = updatedEmployee.Salary;
                emp.Department = updatedEmployee.Department;
                return true;
            }
            return false;
        }
        // edit department data / update department
        public bool UpdateDepartment(string name, Department updatedDepartment)
        {
            var dmt = departments.FirstOrDefault(d => d.Name == name);
            if (dmt != null)
            {
                dmt.StaffCount = updatedDepartment.StaffCount;
                dmt.MonthlyPayroll = updatedDepartment.MonthlyPayroll;
                dmt.YearlyPayroll = updatedDepartment.YearlyPayroll;
                return true;
            }
            return false;
        }




        // ============= search data
        // search employee data
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
        // search department data
        public List<Department> GetAllDepartments()
        {
            return departments;
        }
        public Department FindDepartment(string name)
        {
            return departments.FirstOrDefault(d => d.Name == name);
        }



        // ============= filter
        // filter department
        public List<Employee> FilterByDepartment(string department)
        {
            return employees.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();
        }



        // stats - v processe
        // avg salary, avg montly salary и тп



        // csv files
        // save
        public void SaveEmpToFile(string filePath)
        {
            var lines = new List<string> { "Id,LastName,FirstName,MiddleName,Phone,BirthDate,ExperienceYears,Salary,Department" };
            foreach (var emp in employees)
            {
                lines.Add($"{emp.Id},{emp.LastName},{emp.FirstName},{emp.MiddleName},{emp.Phone},{emp.BirthDate:yyyy-MM-dd},{emp.Salary},{emp.Department}");
            }
            File.WriteAllLines(filePath, lines);
        }
        // load
        public void LoadEmpFromFile(string filePath)
        {
            employees.Clear();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length > 9) break;
                employees.Add(new Employee {
                    Id = int.Parse(parts[0]),
                    LastName = parts[1],
                    FirstName = parts[2],
                    MiddleName = parts[3],
                    Phone = parts[4],
                    BirthDate = DateTime.Parse(parts[5]),
                    ExperienceYears = int.Parse(parts[6]),
                    Salary = decimal.Parse(parts[7]),
                    Department = parts[8]
                });
            }
        }
    }
}
