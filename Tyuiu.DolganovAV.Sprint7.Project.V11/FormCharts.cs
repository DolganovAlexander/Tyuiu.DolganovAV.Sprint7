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

                foreach (var g in groups)
                {
                    series.Points.AddXY(g.Dept, g.Count);
                }

                chartDepartment_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике отделов:\n{ex.Message}");
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

                var area = chartSalary_DAV.ChartAreas[0];
                area.AxisX.Title = "Отделы";
                area.AxisY.Title = "Зарплата (руб.)";
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -45;

                Series series = new Series("Средняя ЗП");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N0";
                series["PointWidth"] = "0.6";

                series.XValueType = ChartValueType.String;
                series.IsXValueIndexed = true;

                if (employees.Count == 0) return;

                var avgSalary = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new
                    {
                        Dept = g.Key,
                        Avg = Math.Round(g.Average(x => x.Salary), 2)
                    })
                    .ToList();

                foreach (var item in avgSalary)
                {
                    series.Points.AddXY(item.Dept, item.Avg);
                }

                chartSalary_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике зарплат:\n{ex.Message}");
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

                var area = chartExpYears_DAV.ChartAreas[0];
                area.AxisX.Title = "Отделы";
                area.AxisY.Title = "Стаж (лет)";
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -45;

                Series series = new Series("Средний стаж");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N1";
                series["PointWidth"] = "0.6";

                series.XValueType = ChartValueType.String;
                series.IsXValueIndexed = true;

                if (employees.Count == 0) return;

                var avgExp = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new
                    {
                        Dept = g.Key,
                        Avg = Math.Round(g.Average(x => x.ExperienceYears), 1)
                    })
                    .ToList();

                foreach (var item in avgExp)
                {
                    series.Points.AddXY(item.Dept, item.Avg);
                }

                chartExpYears_DAV.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в графике стажа:\n{ex.Message}");
            }
        }
    }
}