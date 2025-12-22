using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;
namespace Tyuiu.DolganovAV.Sprint7.Project.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void AddEmployeeToList()
        {
            Employee employee = new Employee
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                BirthDate = new DateTime(1990, 1, 1),
                ExperienceYears = 5,
                Salary = 50000,
                Department = "IT"
            };
            ds.AddEmployee(employee);
            List<Employee> employees = ds.GetAllEmployees();
            Assert.AreEqual(1, employees.Count());
            Assert.AreEqual("Иванов", employees[0].LastName);
        }

        [TestMethod]
        public void ValidFindEmpById()
        {
            Employee employee1 = new Employee { Id = 1, LastName = "Иванов" };
            Employee employee2 = new Employee { Id = 2, LastName = "Федотов" };
            ds.AddEmployee(employee1); 
            ds.AddEmployee(employee2);

            Employee result = ds.FindEmployeeById(2);
            Assert.AreEqual("Федотов", result.LastName);
        }

        [TestMethod]
        public void ValidRemoveEmp()
        {
            Employee employee = new Employee { Id = 1, LastName = "Иванов" };
            ds.AddEmployee(employee);

            bool result = ds.RemoveEmployee(1);
            List<Employee> employees = ds.GetAllEmployees();

            Assert.AreEqual(true, result);
            Assert.AreEqual(0, employees.Count());
        }

        [TestMethod]
        public void ValidSaveAndLoad_CSVfile()
        {
            Employee emp = new Employee
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                BirthDate = new DateTime(1990, 1, 1),
                ExperienceYears = 5,
                Salary = 50000,
                Department = "IT"
            };
            ds.AddEmployee(emp);
            string filePath = Path.GetTempFileName();

            ds.SaveEmpToFile(filePath);

            DataService dsAlt = new DataService();
            dsAlt.LoadEmpFromFile(filePath);

            List<Employee> loadedEmployees = dsAlt.GetAllEmployees();
            Assert.AreEqual(1, loadedEmployees.Count());
            Assert.AreEqual("Иванов", loadedEmployees[0].LastName);
            Assert.IsTrue(File.Exists(filePath));
        }
    }
}