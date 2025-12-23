namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormCharts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControlCharts_DAV = new TabControl();
            tabPageDepartment_DAV = new TabPage();
            chartDepartment_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageSalary_DAV = new TabPage();
            chartSalary_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageExpYears_DAV = new TabPage();
            chartExpYears_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControlCharts_DAV.SuspendLayout();
            tabPageDepartment_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDepartment_DAV).BeginInit();
            tabPageSalary_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSalary_DAV).BeginInit();
            tabPageExpYears_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpYears_DAV).BeginInit();
            SuspendLayout();
            // 
            // tabControlCharts_DAV
            // 
            tabControlCharts_DAV.Controls.Add(tabPageDepartment_DAV);
            tabControlCharts_DAV.Controls.Add(tabPageSalary_DAV);
            tabControlCharts_DAV.Controls.Add(tabPageExpYears_DAV);
            tabControlCharts_DAV.Dock = DockStyle.Fill;
            tabControlCharts_DAV.Location = new Point(0, 0);
            tabControlCharts_DAV.Name = "tabControlCharts_DAV";
            tabControlCharts_DAV.SelectedIndex = 0;
            tabControlCharts_DAV.Size = new Size(808, 454);
            tabControlCharts_DAV.TabIndex = 0;
            // 
            // tabPageDepartment_DAV
            // 
            tabPageDepartment_DAV.Controls.Add(chartDepartment_DAV);
            tabPageDepartment_DAV.Location = new Point(4, 29);
            tabPageDepartment_DAV.Name = "tabPageDepartment_DAV";
            tabPageDepartment_DAV.Padding = new Padding(3);
            tabPageDepartment_DAV.Size = new Size(800, 421);
            tabPageDepartment_DAV.TabIndex = 0;
            tabPageDepartment_DAV.Text = "Отделы";
            tabPageDepartment_DAV.UseVisualStyleBackColor = true;
            // 
            // chartDepartment_DAV
            // 
            chartArea1.Name = "ChartArea1";
            chartDepartment_DAV.ChartAreas.Add(chartArea1);
            chartDepartment_DAV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDepartment_DAV.Legends.Add(legend1);
            chartDepartment_DAV.Location = new Point(3, 3);
            chartDepartment_DAV.Name = "chartDepartment_DAV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDepartment_DAV.Series.Add(series1);
            chartDepartment_DAV.Size = new Size(794, 415);
            chartDepartment_DAV.TabIndex = 0;
            chartDepartment_DAV.Text = "chartDepartment_DAV";
            // 
            // tabPageSalary_DAV
            // 
            tabPageSalary_DAV.Controls.Add(chartSalary_DAV);
            tabPageSalary_DAV.Location = new Point(4, 29);
            tabPageSalary_DAV.Name = "tabPageSalary_DAV";
            tabPageSalary_DAV.Padding = new Padding(3);
            tabPageSalary_DAV.Size = new Size(800, 421);
            tabPageSalary_DAV.TabIndex = 1;
            tabPageSalary_DAV.Text = "Зарплаты";
            tabPageSalary_DAV.UseVisualStyleBackColor = true;
            // 
            // chartSalary_DAV
            // 
            chartArea2.Name = "ChartArea1";
            chartSalary_DAV.ChartAreas.Add(chartArea2);
            chartSalary_DAV.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartSalary_DAV.Legends.Add(legend2);
            chartSalary_DAV.Location = new Point(3, 3);
            chartSalary_DAV.Name = "chartSalary_DAV";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartSalary_DAV.Series.Add(series2);
            chartSalary_DAV.Size = new Size(794, 415);
            chartSalary_DAV.TabIndex = 0;
            chartSalary_DAV.Text = "chartSalary_DAV";
            // 
            // tabPageExpYears_DAV
            // 
            tabPageExpYears_DAV.Controls.Add(chartExpYears_DAV);
            tabPageExpYears_DAV.Location = new Point(4, 29);
            tabPageExpYears_DAV.Name = "tabPageExpYears_DAV";
            tabPageExpYears_DAV.Padding = new Padding(3);
            tabPageExpYears_DAV.Size = new Size(800, 421);
            tabPageExpYears_DAV.TabIndex = 2;
            tabPageExpYears_DAV.Text = "Стаж";
            tabPageExpYears_DAV.UseVisualStyleBackColor = true;
            // 
            // chartExpYears_DAV
            // 
            chartArea3.Name = "ChartArea1";
            chartExpYears_DAV.ChartAreas.Add(chartArea3);
            chartExpYears_DAV.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartExpYears_DAV.Legends.Add(legend3);
            chartExpYears_DAV.Location = new Point(3, 3);
            chartExpYears_DAV.Name = "chartExpYears_DAV";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartExpYears_DAV.Series.Add(series3);
            chartExpYears_DAV.Size = new Size(794, 415);
            chartExpYears_DAV.TabIndex = 0;
            chartExpYears_DAV.Text = "chartE";
            // 
            // FormCharts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 454);
            Controls.Add(tabControlCharts_DAV);
            Name = "FormCharts";
            Text = "Статистика компании";
            tabControlCharts_DAV.ResumeLayout(false);
            tabPageDepartment_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDepartment_DAV).EndInit();
            tabPageSalary_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSalary_DAV).EndInit();
            tabPageExpYears_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartExpYears_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCharts_DAV;
        private TabPage tabPageDepartment_DAV;
        private TabPage tabPageSalary_DAV;
        private TabPage tabPageExpYears_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartment_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpYears_DAV;
    }
}