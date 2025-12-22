namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelNavigation_DAV = new Panel();
            groupBoxEmployeeInfo_DAV = new GroupBox();
            chartPayrolls_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDeparts_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxInfo_DAV = new TextBox();
            panelGetInfo_DAV = new Panel();
            buttonGetCompInfo_DAV = new Button();
            buttonGetEmpInfo_DAV = new Button();
            groupBoxActions_DAV = new GroupBox();
            buttonRemoveEmployee_DAV = new Button();
            buttonEditEmployee_DAV = new Button();
            buttonAddEmployee_DAV = new Button();
            groupBoxFiles_DAV = new GroupBox();
            buttonLoad_DAV = new Button();
            buttonSave_DAV = new Button();
            buttonOpen_DAV = new Button();
            groupBoxSearch_DAV = new GroupBox();
            buttonSearch_DAV = new Button();
            comboBoxSearchType_DAV = new ComboBox();
            textBoxSearch_DAV = new TextBox();
            panelShowData_DAV = new Panel();
            dataGridViewEmployee_DAV = new DataGridView();
            openFileDialog_DAV = new OpenFileDialog();
            panelNavigation_DAV.SuspendLayout();
            groupBoxEmployeeInfo_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPayrolls_DAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDeparts_DAV).BeginInit();
            panelGetInfo_DAV.SuspendLayout();
            groupBoxActions_DAV.SuspendLayout();
            groupBoxFiles_DAV.SuspendLayout();
            groupBoxSearch_DAV.SuspendLayout();
            panelShowData_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee_DAV).BeginInit();
            SuspendLayout();
            // 
            // panelNavigation_DAV
            // 
            panelNavigation_DAV.Controls.Add(groupBoxEmployeeInfo_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxActions_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxFiles_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxSearch_DAV);
            panelNavigation_DAV.Dock = DockStyle.Left;
            panelNavigation_DAV.Location = new Point(0, 0);
            panelNavigation_DAV.Name = "panelNavigation_DAV";
            panelNavigation_DAV.Size = new Size(381, 923);
            panelNavigation_DAV.TabIndex = 0;
            // 
            // groupBoxEmployeeInfo_DAV
            // 
            groupBoxEmployeeInfo_DAV.Controls.Add(chartPayrolls_DAV);
            groupBoxEmployeeInfo_DAV.Controls.Add(chartDeparts_DAV);
            groupBoxEmployeeInfo_DAV.Controls.Add(textBoxInfo_DAV);
            groupBoxEmployeeInfo_DAV.Controls.Add(panelGetInfo_DAV);
            groupBoxEmployeeInfo_DAV.Dock = DockStyle.Fill;
            groupBoxEmployeeInfo_DAV.Location = new Point(0, 244);
            groupBoxEmployeeInfo_DAV.Name = "groupBoxEmployeeInfo_DAV";
            groupBoxEmployeeInfo_DAV.Size = new Size(381, 679);
            groupBoxEmployeeInfo_DAV.TabIndex = 3;
            groupBoxEmployeeInfo_DAV.TabStop = false;
            groupBoxEmployeeInfo_DAV.Text = "О компании";
            // 
            // chartPayrolls_DAV
            // 
            chartArea3.Name = "ChartArea1";
            chartPayrolls_DAV.ChartAreas.Add(chartArea3);
            chartPayrolls_DAV.Dock = DockStyle.Top;
            legend3.Name = "Legend1";
            chartPayrolls_DAV.Legends.Add(legend3);
            chartPayrolls_DAV.Location = new Point(3, 353);
            chartPayrolls_DAV.Name = "chartPayrolls_DAV";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartPayrolls_DAV.Series.Add(series3);
            chartPayrolls_DAV.Size = new Size(375, 150);
            chartPayrolls_DAV.TabIndex = 5;
            chartPayrolls_DAV.Text = "chart1";
            // 
            // chartDeparts_DAV
            // 
            chartArea4.Name = "ChartArea1";
            chartDeparts_DAV.ChartAreas.Add(chartArea4);
            chartDeparts_DAV.Dock = DockStyle.Top;
            legend4.Name = "Legend1";
            chartDeparts_DAV.Legends.Add(legend4);
            chartDeparts_DAV.Location = new Point(3, 203);
            chartDeparts_DAV.Name = "chartDeparts_DAV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartDeparts_DAV.Series.Add(series4);
            chartDeparts_DAV.Size = new Size(375, 150);
            chartDeparts_DAV.TabIndex = 4;
            chartDeparts_DAV.Text = "chart1";
            // 
            // textBoxInfo_DAV
            // 
            textBoxInfo_DAV.Dock = DockStyle.Top;
            textBoxInfo_DAV.Location = new Point(3, 74);
            textBoxInfo_DAV.Multiline = true;
            textBoxInfo_DAV.Name = "textBoxInfo_DAV";
            textBoxInfo_DAV.ReadOnly = true;
            textBoxInfo_DAV.Size = new Size(375, 129);
            textBoxInfo_DAV.TabIndex = 3;
            textBoxInfo_DAV.Text = "СТАТИСТИКА КОМПАНИИ\r\n===================\r\nsdasdasdsa\r\ndadsadsa\r\nasdsadsad\r\nsad";
            // 
            // panelGetInfo_DAV
            // 
            panelGetInfo_DAV.Controls.Add(buttonGetCompInfo_DAV);
            panelGetInfo_DAV.Controls.Add(buttonGetEmpInfo_DAV);
            panelGetInfo_DAV.Dock = DockStyle.Top;
            panelGetInfo_DAV.Location = new Point(3, 23);
            panelGetInfo_DAV.Name = "panelGetInfo_DAV";
            panelGetInfo_DAV.Size = new Size(375, 51);
            panelGetInfo_DAV.TabIndex = 2;
            // 
            // buttonGetCompInfo_DAV
            // 
            buttonGetCompInfo_DAV.Dock = DockStyle.Fill;
            buttonGetCompInfo_DAV.Location = new Point(187, 0);
            buttonGetCompInfo_DAV.Name = "buttonGetCompInfo_DAV";
            buttonGetCompInfo_DAV.Size = new Size(188, 51);
            buttonGetCompInfo_DAV.TabIndex = 1;
            buttonGetCompInfo_DAV.Text = "GetCompInfo_DAV";
            buttonGetCompInfo_DAV.UseVisualStyleBackColor = true;
            // 
            // buttonGetEmpInfo_DAV
            // 
            buttonGetEmpInfo_DAV.Dock = DockStyle.Left;
            buttonGetEmpInfo_DAV.Location = new Point(0, 0);
            buttonGetEmpInfo_DAV.Name = "buttonGetEmpInfo_DAV";
            buttonGetEmpInfo_DAV.Size = new Size(187, 51);
            buttonGetEmpInfo_DAV.TabIndex = 0;
            buttonGetEmpInfo_DAV.Text = "GetEmployeeInfo";
            buttonGetEmpInfo_DAV.UseVisualStyleBackColor = true;
            buttonGetEmpInfo_DAV.Click += buttonGetEmpInfo_DAV_Click;
            // 
            // groupBoxActions_DAV
            // 
            groupBoxActions_DAV.Controls.Add(buttonRemoveEmployee_DAV);
            groupBoxActions_DAV.Controls.Add(buttonEditEmployee_DAV);
            groupBoxActions_DAV.Controls.Add(buttonAddEmployee_DAV);
            groupBoxActions_DAV.Dock = DockStyle.Top;
            groupBoxActions_DAV.Location = new Point(0, 166);
            groupBoxActions_DAV.Name = "groupBoxActions_DAV";
            groupBoxActions_DAV.Size = new Size(381, 78);
            groupBoxActions_DAV.TabIndex = 2;
            groupBoxActions_DAV.TabStop = false;
            groupBoxActions_DAV.Text = "Действия";
            // 
            // buttonRemoveEmployee_DAV
            // 
            buttonRemoveEmployee_DAV.Dock = DockStyle.Fill;
            buttonRemoveEmployee_DAV.Location = new Point(258, 23);
            buttonRemoveEmployee_DAV.Name = "buttonRemoveEmployee_DAV";
            buttonRemoveEmployee_DAV.Size = new Size(120, 52);
            buttonRemoveEmployee_DAV.TabIndex = 2;
            buttonRemoveEmployee_DAV.Text = "RemoveEmp";
            buttonRemoveEmployee_DAV.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmployee_DAV
            // 
            buttonEditEmployee_DAV.Dock = DockStyle.Left;
            buttonEditEmployee_DAV.Location = new Point(124, 23);
            buttonEditEmployee_DAV.Name = "buttonEditEmployee_DAV";
            buttonEditEmployee_DAV.Size = new Size(134, 52);
            buttonEditEmployee_DAV.TabIndex = 1;
            buttonEditEmployee_DAV.Text = "EditEmp";
            buttonEditEmployee_DAV.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee_DAV
            // 
            buttonAddEmployee_DAV.Dock = DockStyle.Left;
            buttonAddEmployee_DAV.Location = new Point(3, 23);
            buttonAddEmployee_DAV.Name = "buttonAddEmployee_DAV";
            buttonAddEmployee_DAV.Size = new Size(121, 52);
            buttonAddEmployee_DAV.TabIndex = 0;
            buttonAddEmployee_DAV.Text = "AddEmp";
            buttonAddEmployee_DAV.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiles_DAV
            // 
            groupBoxFiles_DAV.Controls.Add(buttonLoad_DAV);
            groupBoxFiles_DAV.Controls.Add(buttonSave_DAV);
            groupBoxFiles_DAV.Controls.Add(buttonOpen_DAV);
            groupBoxFiles_DAV.Dock = DockStyle.Top;
            groupBoxFiles_DAV.Location = new Point(0, 81);
            groupBoxFiles_DAV.Name = "groupBoxFiles_DAV";
            groupBoxFiles_DAV.Size = new Size(381, 85);
            groupBoxFiles_DAV.TabIndex = 1;
            groupBoxFiles_DAV.TabStop = false;
            groupBoxFiles_DAV.Text = "Файл";
            // 
            // buttonLoad_DAV
            // 
            buttonLoad_DAV.Dock = DockStyle.Fill;
            buttonLoad_DAV.Location = new Point(257, 23);
            buttonLoad_DAV.Name = "buttonLoad_DAV";
            buttonLoad_DAV.Size = new Size(121, 59);
            buttonLoad_DAV.TabIndex = 2;
            buttonLoad_DAV.Text = "buttonLoad";
            buttonLoad_DAV.UseVisualStyleBackColor = true;
            buttonLoad_DAV.Click += buttonLoad_DAV_Click;
            // 
            // buttonSave_DAV
            // 
            buttonSave_DAV.Dock = DockStyle.Left;
            buttonSave_DAV.Location = new Point(134, 23);
            buttonSave_DAV.Name = "buttonSave_DAV";
            buttonSave_DAV.Size = new Size(123, 59);
            buttonSave_DAV.TabIndex = 1;
            buttonSave_DAV.Text = "buttonSAVE";
            buttonSave_DAV.UseVisualStyleBackColor = true;
            buttonSave_DAV.Click += buttonSave_DAV_Click;
            // 
            // buttonOpen_DAV
            // 
            buttonOpen_DAV.Dock = DockStyle.Left;
            buttonOpen_DAV.Location = new Point(3, 23);
            buttonOpen_DAV.Name = "buttonOpen_DAV";
            buttonOpen_DAV.Size = new Size(131, 59);
            buttonOpen_DAV.TabIndex = 0;
            buttonOpen_DAV.Text = "buttonOpen";
            buttonOpen_DAV.UseVisualStyleBackColor = true;
            buttonOpen_DAV.Click += buttonOpen_DAV_Click;
            // 
            // groupBoxSearch_DAV
            // 
            groupBoxSearch_DAV.Controls.Add(buttonSearch_DAV);
            groupBoxSearch_DAV.Controls.Add(comboBoxSearchType_DAV);
            groupBoxSearch_DAV.Controls.Add(textBoxSearch_DAV);
            groupBoxSearch_DAV.Dock = DockStyle.Top;
            groupBoxSearch_DAV.Location = new Point(0, 0);
            groupBoxSearch_DAV.Name = "groupBoxSearch_DAV";
            groupBoxSearch_DAV.Size = new Size(381, 81);
            groupBoxSearch_DAV.TabIndex = 0;
            groupBoxSearch_DAV.TabStop = false;
            groupBoxSearch_DAV.Text = "Поиск";
            // 
            // buttonSearch_DAV
            // 
            buttonSearch_DAV.Dock = DockStyle.Fill;
            buttonSearch_DAV.Location = new Point(148, 50);
            buttonSearch_DAV.Name = "buttonSearch_DAV";
            buttonSearch_DAV.Size = new Size(230, 28);
            buttonSearch_DAV.TabIndex = 2;
            buttonSearch_DAV.Text = "Search";
            buttonSearch_DAV.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchType_DAV
            // 
            comboBoxSearchType_DAV.Dock = DockStyle.Left;
            comboBoxSearchType_DAV.FormattingEnabled = true;
            comboBoxSearchType_DAV.Location = new Point(3, 50);
            comboBoxSearchType_DAV.Name = "comboBoxSearchType_DAV";
            comboBoxSearchType_DAV.Size = new Size(145, 28);
            comboBoxSearchType_DAV.TabIndex = 1;
            // 
            // textBoxSearch_DAV
            // 
            textBoxSearch_DAV.Dock = DockStyle.Top;
            textBoxSearch_DAV.Location = new Point(3, 23);
            textBoxSearch_DAV.Name = "textBoxSearch_DAV";
            textBoxSearch_DAV.Size = new Size(375, 27);
            textBoxSearch_DAV.TabIndex = 0;
            // 
            // panelShowData_DAV
            // 
            panelShowData_DAV.Controls.Add(dataGridViewEmployee_DAV);
            panelShowData_DAV.Dock = DockStyle.Fill;
            panelShowData_DAV.Location = new Point(381, 0);
            panelShowData_DAV.Name = "panelShowData_DAV";
            panelShowData_DAV.Size = new Size(1047, 923);
            panelShowData_DAV.TabIndex = 1;
            // 
            // dataGridViewEmployee_DAV
            // 
            dataGridViewEmployee_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee_DAV.Dock = DockStyle.Fill;
            dataGridViewEmployee_DAV.Location = new Point(0, 0);
            dataGridViewEmployee_DAV.Name = "dataGridViewEmployee_DAV";
            dataGridViewEmployee_DAV.RowHeadersWidth = 51;
            dataGridViewEmployee_DAV.Size = new Size(1047, 923);
            dataGridViewEmployee_DAV.TabIndex = 0;
            // 
            // openFileDialog_DAV
            // 
            openFileDialog_DAV.FileName = "openFileDialog_DAV";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 923);
            Controls.Add(panelShowData_DAV);
            Controls.Add(panelNavigation_DAV);
            Name = "FormMain";
            Text = "Form1";
            panelNavigation_DAV.ResumeLayout(false);
            groupBoxEmployeeInfo_DAV.ResumeLayout(false);
            groupBoxEmployeeInfo_DAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPayrolls_DAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDeparts_DAV).EndInit();
            panelGetInfo_DAV.ResumeLayout(false);
            groupBoxActions_DAV.ResumeLayout(false);
            groupBoxFiles_DAV.ResumeLayout(false);
            groupBoxSearch_DAV.ResumeLayout(false);
            groupBoxSearch_DAV.PerformLayout();
            panelShowData_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavigation_DAV;
        private Panel panelShowData_DAV;
        private DataGridView dataGridViewEmployee_DAV;
        private GroupBox groupBoxSearch_DAV;
        private GroupBox groupBoxFiles_DAV;
        private GroupBox groupBoxActions_DAV;
        private GroupBox groupBoxEmployeeInfo_DAV;
        private Button buttonOpen_DAV;
        private Button buttonSave_DAV;
        private Button buttonLoad_DAV;
        private Button buttonAddEmployee_DAV;
        private Button buttonEditEmployee_DAV;
        private Button buttonRemoveEmployee_DAV;
        private Button buttonGetEmpInfo_DAV;
        private TextBox textBoxSearch_DAV;
        private ComboBox comboBoxSearchType_DAV;
        private Button buttonSearch_DAV;
        private Panel panelGetInfo_DAV;
        private Button buttonGetCompInfo_DAV;
        private TextBox textBoxInfo_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeparts_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayrolls_DAV;
        private OpenFileDialog openFileDialog_DAV;
    }
}
