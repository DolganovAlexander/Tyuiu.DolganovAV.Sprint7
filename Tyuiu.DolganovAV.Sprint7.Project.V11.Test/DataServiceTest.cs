using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;

namespace Tyuiu.DolganovAV.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService ds = new DataService();

        [TestInitialize]
        public void Setup() // тест список
        {
            ds.AddEmployee(new Employee
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                BirthDate = new DateTime(1990, 1, 1),
                ExperienceYears = 5,
                Salary = 50000,
                Department = "IT"
            });

            ds.AddEmployee(new Employee
            {
                Id = 2,
                LastName = "Петров",
                FirstName = "Пётр",
                MiddleName = "Петрович",
                BirthDate = new DateTime(1985, 5, 10),
                ExperienceYears = 10,
                Salary = 80000,
                Department = "HR"
            });
        }

        // ================= ДОБАВЛЕНИЕ / УДАЛЕНИЕ

        [TestMethod]
        public void AddEmployeet()
        {
            ds.AddEmployee(new Employee { Id = 3 });
            Assert.AreEqual(3, ds.GetEmployeeCount());
        }

        [TestMethod]
        public void RemoveEmployee()
        {
            bool result = ds.RemoveEmployee(1);
            Assert.IsTrue(result);
            Assert.AreEqual(1, ds.GetEmployeeCount());
        }

        // ================= ИЗМЕНЕНИЕ

        [TestMethod]
        public void UpdateEmployee_ValidId()
        {
            var updated = new Employee
            {
                LastName = "Сидоров",
                FirstName = "Сидор",
                MiddleName = "Сидорович",
                BirthDate = new DateTime(1995, 3, 3),
                ExperienceYears = 3,
                Salary = 60000,
                Department = "QA"
            };

            bool result = ds.UpdateEmployee(1, updated);

            var emp = ds.FindEmployeeById(1);

            Assert.IsTrue(result);
            Assert.AreEqual("Сидоров", emp.LastName);
            Assert.AreEqual(60000, emp.Salary);
        }

        // ================= ПОИСК

        [TestMethod]
        public void FindEmployeeById()
        {
            var emp = ds.FindEmployeeById(2);
            Assert.IsNotNull(emp);
            Assert.AreEqual("Петров", emp.LastName);
        }

        [TestMethod]
        public void FindByLastName()
        {
            var list = ds.FindByLastName("Петров");
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void FindByDepartment_ReturnsCorrectList()
        {
            var list = ds.FindByDepartment("IT");
            Assert.AreEqual(1, list.Count);
        }

        // ================= ФИЛЬТРЫ

        [TestMethod]
        public void FilterBySalaryDescending()
        {
            var list = ds.FilterBySalaryDescending();
            Assert.AreEqual(80000, list.First().Salary);
        }

        [TestMethod]
        public void FilterByExperienceAscending()
        {
            var list = ds.FilterByExperipenceAscending();
            Assert.AreEqual(5, list.First().ExperienceYears);
        }

        [TestMethod]
        public void FilterByIdAscending()
        {
            var list = ds.FilterByIdAscending();
            Assert.AreEqual(1, list.First().Id);
        }

        [TestMethod]
        public void FilterByIdDescending()
        {
            var list = ds.FilterByIdDescending();
            Assert.AreEqual(2, list.First().Id);
        }

        [TestMethod]
        public void FilterByLastNameAscending()
        {
            var list = ds.FilterByLastNameAscending();
            Assert.AreEqual("Иванов", list.First().LastName);
        }

        [TestMethod]
        public void FilterByLastNameDescending()
        {
            var list = ds.FilterByLastNameDescending();
            Assert.AreEqual("Петров", list.First().LastName);
        }

        // ================= СТАТИСТИКА

        [TestMethod]
        public void GetEmployeeCount()
        {
            int count = ds.GetEmployeeCount();
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void GetTotalSalary()
        {
            decimal total = ds.GetTotalSalary();
            Assert.AreEqual(130000, total);
        }

        [TestMethod]
        public void GetAverageSalary()
        {
            decimal avg = ds.GetAvgSalary();
            Assert.AreEqual(65000, avg);
        }

        [TestMethod]
        public void GetAverageExperience()
        {
            double avg = ds.GetAvgExpYears();
            Assert.AreEqual(7.5, avg);
        }

        // ================= ЗАГРУЗКА / СОХРАНЕНИЕ

        [TestMethod]
        public void SaveAndLoadEmployees()
        {
            string path = "test_employees.csv";

            ds.SaveEmpToFile(path);

            var newService = new DataService();
            newService.LoadEmpFromFile(path);

            Assert.AreEqual(2, newService.GetEmployeeCount());
            Assert.AreEqual(130000, newService.GetTotalSalary());

            File.Delete(path);
        }
    }
}
