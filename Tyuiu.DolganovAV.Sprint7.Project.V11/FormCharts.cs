using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;

namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    public partial class FormCharts : Form
    {
        private List<Employee> employees;

        public FormCharts(List<Employee> emp)
        {
            InitializeComponent();
            employees = emp ?? new List<Employee>();
            LoadData();
        }

        private void LoadData()
        {
            LoadDepartmentChart();
            LoadSalaryChart();
            LoadExperienceChart();
        }

        private void LoadDepartmentChart()
        {
            try
            {
                chartDepartment_DAV.Series.Clear();
                chartDepartment_DAV.Titles.Clear();

                chartDepartment_DAV.Titles.Add("Сотрудники по отделам");

                Series series = new Series("Отделы");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                series.Label = "#VALX (#PERCENT{P1})";

                if (employees.Count == 0) return;

                var groups = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new { Dept = g.Key, Count = g.Count() })
                    .ToList();

                MessageBox.Show($"Найдено отделов: {groups.Count}");

                foreach (var g in groups)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(g.Dept, g.Count);
                    point.Label = $"{g.Dept}: {g.Count}";
                    series.Points.Add(point);
                }

                chartDepartment_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике отделов: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void LoadSalaryChart()
        {
            try
            {
                chartSalary_DAV.Series.Clear();
                chartSalary_DAV.Titles.Clear();

                chartSalary_DAV.Titles.Add("Средняя зарплата по отделам");
                if (chartSalary_DAV.ChartAreas.Count == 0)
                    chartSalary_DAV.ChartAreas.Add(new ChartArea());

                chartSalary_DAV.ChartAreas[0].AxisX.Title = "Отделы";
                chartSalary_DAV.ChartAreas[0].AxisY.Title = "Зарплата (руб.)";
                chartSalary_DAV.ChartAreas[0].AxisX.Interval = 1;
                chartSalary_DAV.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                Series series = new Series("Средняя ЗП");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N0";
                series["PointWidth"] = "0.6";

                if (employees.Count == 0) return;

                var avg = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new { Dept = g.Key, Avg = Math.Round(g.Average(x => x.Salary), 2) })
                    .ToList();

                MessageBox.Show($"Отделов для зарплат: {avg.Count}");

                foreach (var item in avg)
                {
                    series.Points.AddXY(item.Dept, item.Avg);
                }

                chartSalary_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике зарплат: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void LoadExperienceChart()
        {
            try
            {
                chartExpYears_DAV.Series.Clear();
                chartExpYears_DAV.Titles.Clear();

                chartExpYears_DAV.Titles.Add("Средний стаж по отделам");

                if (chartExpYears_DAV.ChartAreas.Count == 0)
                    chartExpYears_DAV.ChartAreas.Add(new ChartArea());

                chartExpYears_DAV.ChartAreas[0].AxisX.Title = "Отделы";
                chartExpYears_DAV.ChartAreas[0].AxisY.Title = "Стаж (лет)";
                chartExpYears_DAV.ChartAreas[0].AxisX.Interval = 1;
                chartExpYears_DAV.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                Series series = new Series("Средний стаж");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N1";
                series["PointWidth"] = "0.6";

                if (employees.Count == 0) return;

                var avgExp = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new { Dept = g.Key, Avg = Math.Round(g.Average(x => x.ExperienceYears), 1) })
                    .ToList();

                MessageBox.Show($"Отделов для стажа: {avgExp.Count}");

                foreach (var item in avgExp)
                {
                    series.Points.AddXY(item.Dept, item.Avg);
                }

                chartExpYears_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике стажа: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}