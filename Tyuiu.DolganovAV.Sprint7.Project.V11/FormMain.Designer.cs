namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormMain
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
            panelNavigation_DAV = new Panel();
            groupBoxStatisitc_DAV = new GroupBox();
            textBoxInfo_DAV = new TextBox();
            panelInfo_DAV = new Panel();
            buttonGetCharts_DAV = new Button();
            buttonGetCompInfo_DAV = new Button();
            groupBoxSort_DAV = new GroupBox();
            buttonSortById_DAV = new Button();
            buttonSortByLastName_DAV = new Button();
            buttonSortByExp_DAV = new Button();
            buttonSortBySalary_DAV = new Button();
            groupBoxActions_DAV = new GroupBox();
            buttonRemoveEmployee_DAV = new Button();
            buttonEditEmployee_DAV = new Button();
            buttonAddEmployee_DAV = new Button();
            groupBoxFiles_DAV = new GroupBox();
            buttonSave_DAV = new Button();
            buttonOpen_DAV = new Button();
            groupBoxSearch_DAV = new GroupBox();
            buttonSearch_DAV = new Button();
            comboBoxSearchType_DAV = new ComboBox();
            textBoxSearch_DAV = new TextBox();
            panelShowData_DAV = new Panel();
            dataGridViewEmployee_DAV = new DataGridView();
            openFileDialog_DAV = new OpenFileDialog();
            saveFileDialog_DAV = new SaveFileDialog();
            panelNavigation_DAV.SuspendLayout();
            groupBoxStatisitc_DAV.SuspendLayout();
            panelInfo_DAV.SuspendLayout();
            groupBoxSort_DAV.SuspendLayout();
            groupBoxActions_DAV.SuspendLayout();
            groupBoxFiles_DAV.SuspendLayout();
            groupBoxSearch_DAV.SuspendLayout();
            panelShowData_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee_DAV).BeginInit();
            SuspendLayout();
            // 
            // panelNavigation_DAV
            // 
            panelNavigation_DAV.Controls.Add(groupBoxStatisitc_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxSort_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxActions_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxFiles_DAV);
            panelNavigation_DAV.Controls.Add(groupBoxSearch_DAV);
            panelNavigation_DAV.Dock = DockStyle.Left;
            panelNavigation_DAV.Location = new Point(0, 0);
            panelNavigation_DAV.Name = "panelNavigation_DAV";
            panelNavigation_DAV.Size = new Size(381, 923);
            panelNavigation_DAV.TabIndex = 0;
            // 
            // groupBoxStatisitc_DAV
            // 
            groupBoxStatisitc_DAV.Controls.Add(textBoxInfo_DAV);
            groupBoxStatisitc_DAV.Controls.Add(panelInfo_DAV);
            groupBoxStatisitc_DAV.Dock = DockStyle.Fill;
            groupBoxStatisitc_DAV.Location = new Point(0, 321);
            groupBoxStatisitc_DAV.Name = "groupBoxStatisitc_DAV";
            groupBoxStatisitc_DAV.Size = new Size(381, 602);
            groupBoxStatisitc_DAV.TabIndex = 5;
            groupBoxStatisitc_DAV.TabStop = false;
            groupBoxStatisitc_DAV.Text = "Статистика";
            // 
            // textBoxInfo_DAV
            // 
            textBoxInfo_DAV.Dock = DockStyle.Fill;
            textBoxInfo_DAV.Location = new Point(3, 76);
            textBoxInfo_DAV.Multiline = true;
            textBoxInfo_DAV.Name = "textBoxInfo_DAV";
            textBoxInfo_DAV.ReadOnly = true;
            textBoxInfo_DAV.ScrollBars = ScrollBars.Vertical;
            textBoxInfo_DAV.Size = new Size(375, 523);
            textBoxInfo_DAV.TabIndex = 1;
            // 
            // panelInfo_DAV
            // 
            panelInfo_DAV.Controls.Add(buttonGetCharts_DAV);
            panelInfo_DAV.Controls.Add(buttonGetCompInfo_DAV);
            panelInfo_DAV.Dock = DockStyle.Top;
            panelInfo_DAV.Location = new Point(3, 23);
            panelInfo_DAV.Name = "panelInfo_DAV";
            panelInfo_DAV.Size = new Size(375, 53);
            panelInfo_DAV.TabIndex = 0;
            // 
            // buttonGetCharts_DAV
            // 
            buttonGetCharts_DAV.Dock = DockStyle.Fill;
            buttonGetCharts_DAV.Location = new Point(305, 0);
            buttonGetCharts_DAV.Name = "buttonGetCharts_DAV";
            buttonGetCharts_DAV.Size = new Size(70, 53);
            buttonGetCharts_DAV.TabIndex = 1;
            buttonGetCharts_DAV.Text = "Графики";
            buttonGetCharts_DAV.UseVisualStyleBackColor = true;
            buttonGetCharts_DAV.Click += buttonGetCharts_DAV_Click;
            // 
            // buttonGetCompInfo_DAV
            // 
            buttonGetCompInfo_DAV.Dock = DockStyle.Left;
            buttonGetCompInfo_DAV.Location = new Point(0, 0);
            buttonGetCompInfo_DAV.Name = "buttonGetCompInfo_DAV";
            buttonGetCompInfo_DAV.Size = new Size(305, 53);
            buttonGetCompInfo_DAV.TabIndex = 0;
            buttonGetCompInfo_DAV.Text = "Информация о компании";
            buttonGetCompInfo_DAV.UseVisualStyleBackColor = true;
            buttonGetCompInfo_DAV.Click += buttonGetCompInfo_DAV_Click;
            // 
            // groupBoxSort_DAV
            // 
            groupBoxSort_DAV.Controls.Add(buttonSortById_DAV);
            groupBoxSort_DAV.Controls.Add(buttonSortByLastName_DAV);
            groupBoxSort_DAV.Controls.Add(buttonSortByExp_DAV);
            groupBoxSort_DAV.Controls.Add(buttonSortBySalary_DAV);
            groupBoxSort_DAV.Dock = DockStyle.Top;
            groupBoxSort_DAV.Location = new Point(0, 240);
            groupBoxSort_DAV.Name = "groupBoxSort_DAV";
            groupBoxSort_DAV.Size = new Size(381, 81);
            groupBoxSort_DAV.TabIndex = 4;
            groupBoxSort_DAV.TabStop = false;
            groupBoxSort_DAV.Text = "Сортировка";
            // 
            // buttonSortById_DAV
            // 
            buttonSortById_DAV.Dock = DockStyle.Fill;
            buttonSortById_DAV.Location = new Point(282, 23);
            buttonSortById_DAV.Name = "buttonSortById_DAV";
            buttonSortById_DAV.Size = new Size(96, 55);
            buttonSortById_DAV.TabIndex = 3;
            buttonSortById_DAV.Text = "Табельный номер";
            buttonSortById_DAV.UseVisualStyleBackColor = true;
            buttonSortById_DAV.Click += buttonSortById_DAV_Click;
            // 
            // buttonSortByLastName_DAV
            // 
            buttonSortByLastName_DAV.Dock = DockStyle.Left;
            buttonSortByLastName_DAV.Location = new Point(189, 23);
            buttonSortByLastName_DAV.Name = "buttonSortByLastName_DAV";
            buttonSortByLastName_DAV.Size = new Size(93, 55);
            buttonSortByLastName_DAV.TabIndex = 2;
            buttonSortByLastName_DAV.Text = "Фамилия";
            buttonSortByLastName_DAV.UseVisualStyleBackColor = true;
            buttonSortByLastName_DAV.Click += buttonSortByLastName_DAV_Click;
            // 
            // buttonSortByExp_DAV
            // 
            buttonSortByExp_DAV.Dock = DockStyle.Left;
            buttonSortByExp_DAV.Location = new Point(96, 23);
            buttonSortByExp_DAV.Name = "buttonSortByExp_DAV";
            buttonSortByExp_DAV.Size = new Size(93, 55);
            buttonSortByExp_DAV.TabIndex = 1;
            buttonSortByExp_DAV.Text = "Стаж";
            buttonSortByExp_DAV.UseVisualStyleBackColor = true;
            buttonSortByExp_DAV.Click += buttonSortByExp_DAV_Click;
            // 
            // buttonSortBySalary_DAV
            // 
            buttonSortBySalary_DAV.Dock = DockStyle.Left;
            buttonSortBySalary_DAV.Location = new Point(3, 23);
            buttonSortBySalary_DAV.Name = "buttonSortBySalary_DAV";
            buttonSortBySalary_DAV.Size = new Size(93, 55);
            buttonSortBySalary_DAV.TabIndex = 0;
            buttonSortBySalary_DAV.Text = "Оклад";
            buttonSortBySalary_DAV.UseVisualStyleBackColor = true;
            buttonSortBySalary_DAV.Click += buttonSortBySalary_DAV_Click;
            // 
            // groupBoxActions_DAV
            // 
            groupBoxActions_DAV.Controls.Add(buttonRemoveEmployee_DAV);
            groupBoxActions_DAV.Controls.Add(buttonEditEmployee_DAV);
            groupBoxActions_DAV.Controls.Add(buttonAddEmployee_DAV);
            groupBoxActions_DAV.Dock = DockStyle.Top;
            groupBoxActions_DAV.Location = new Point(0, 161);
            groupBoxActions_DAV.Name = "groupBoxActions_DAV";
            groupBoxActions_DAV.Size = new Size(381, 79);
            groupBoxActions_DAV.TabIndex = 2;
            groupBoxActions_DAV.TabStop = false;
            groupBoxActions_DAV.Text = "Действия";
            // 
            // buttonRemoveEmployee_DAV
            // 
            buttonRemoveEmployee_DAV.Dock = DockStyle.Fill;
            buttonRemoveEmployee_DAV.Location = new Point(258, 23);
            buttonRemoveEmployee_DAV.Name = "buttonRemoveEmployee_DAV";
            buttonRemoveEmployee_DAV.Size = new Size(120, 53);
            buttonRemoveEmployee_DAV.TabIndex = 2;
            buttonRemoveEmployee_DAV.Text = "Удалить сотрудника";
            buttonRemoveEmployee_DAV.UseVisualStyleBackColor = true;
            buttonRemoveEmployee_DAV.Click += buttonRemoveEmployee_DAV_Click;
            // 
            // buttonEditEmployee_DAV
            // 
            buttonEditEmployee_DAV.Dock = DockStyle.Left;
            buttonEditEmployee_DAV.Location = new Point(124, 23);
            buttonEditEmployee_DAV.Name = "buttonEditEmployee_DAV";
            buttonEditEmployee_DAV.Size = new Size(134, 53);
            buttonEditEmployee_DAV.TabIndex = 1;
            buttonEditEmployee_DAV.Text = "Изменить данные";
            buttonEditEmployee_DAV.UseVisualStyleBackColor = true;
            buttonEditEmployee_DAV.Click += buttonEditEmployee_DAV_Click;
            // 
            // buttonAddEmployee_DAV
            // 
            buttonAddEmployee_DAV.Dock = DockStyle.Left;
            buttonAddEmployee_DAV.Location = new Point(3, 23);
            buttonAddEmployee_DAV.Name = "buttonAddEmployee_DAV";
            buttonAddEmployee_DAV.Size = new Size(121, 53);
            buttonAddEmployee_DAV.TabIndex = 0;
            buttonAddEmployee_DAV.Text = "Добавить сотрудника";
            buttonAddEmployee_DAV.UseVisualStyleBackColor = true;
            buttonAddEmployee_DAV.Click += buttonAddEmployee_DAV_Click;
            // 
            // groupBoxFiles_DAV
            // 
            groupBoxFiles_DAV.Controls.Add(buttonSave_DAV);
            groupBoxFiles_DAV.Controls.Add(buttonOpen_DAV);
            groupBoxFiles_DAV.Dock = DockStyle.Top;
            groupBoxFiles_DAV.Location = new Point(0, 82);
            groupBoxFiles_DAV.Name = "groupBoxFiles_DAV";
            groupBoxFiles_DAV.Size = new Size(381, 79);
            groupBoxFiles_DAV.TabIndex = 1;
            groupBoxFiles_DAV.TabStop = false;
            groupBoxFiles_DAV.Text = "Файл";
            // 
            // buttonSave_DAV
            // 
            buttonSave_DAV.Dock = DockStyle.Fill;
            buttonSave_DAV.Location = new Point(190, 23);
            buttonSave_DAV.Name = "buttonSave_DAV";
            buttonSave_DAV.Size = new Size(188, 53);
            buttonSave_DAV.TabIndex = 1;
            buttonSave_DAV.Text = "Сохранить";
            buttonSave_DAV.UseVisualStyleBackColor = true;
            buttonSave_DAV.Click += buttonSave_DAV_Click;
            // 
            // buttonOpen_DAV
            // 
            buttonOpen_DAV.Dock = DockStyle.Left;
            buttonOpen_DAV.Location = new Point(3, 23);
            buttonOpen_DAV.Name = "buttonOpen_DAV";
            buttonOpen_DAV.Size = new Size(187, 53);
            buttonOpen_DAV.TabIndex = 0;
            buttonOpen_DAV.Text = "Открыть";
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
            groupBoxSearch_DAV.Size = new Size(381, 82);
            groupBoxSearch_DAV.TabIndex = 0;
            groupBoxSearch_DAV.TabStop = false;
            groupBoxSearch_DAV.Text = "Поиск";
            // 
            // buttonSearch_DAV
            // 
            buttonSearch_DAV.Dock = DockStyle.Fill;
            buttonSearch_DAV.Location = new Point(190, 50);
            buttonSearch_DAV.Name = "buttonSearch_DAV";
            buttonSearch_DAV.Size = new Size(188, 29);
            buttonSearch_DAV.TabIndex = 2;
            buttonSearch_DAV.Text = "Поиск";
            buttonSearch_DAV.UseVisualStyleBackColor = true;
            buttonSearch_DAV.Click += buttonSearch_DAV_Click;
            // 
            // comboBoxSearchType_DAV
            // 
            comboBoxSearchType_DAV.Dock = DockStyle.Left;
            comboBoxSearchType_DAV.FormattingEnabled = true;
            comboBoxSearchType_DAV.Items.AddRange(new object[] { "По ID", "По фамилии", "По отделу" });
            comboBoxSearchType_DAV.Location = new Point(3, 50);
            comboBoxSearchType_DAV.Name = "comboBoxSearchType_DAV";
            comboBoxSearchType_DAV.Size = new Size(187, 28);
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
            Text = "OtdelKadrov";
            panelNavigation_DAV.ResumeLayout(false);
            groupBoxStatisitc_DAV.ResumeLayout(false);
            groupBoxStatisitc_DAV.PerformLayout();
            panelInfo_DAV.ResumeLayout(false);
            groupBoxSort_DAV.ResumeLayout(false);
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
        private GroupBox groupBoxSort_DAV;
        private Button buttonOpen_DAV;
        private Button buttonSave_DAV;
        private Button buttonAddEmployee_DAV;
        private Button buttonEditEmployee_DAV;
        private Button buttonRemoveEmployee_DAV;
        private TextBox textBoxSearch_DAV;
        private ComboBox comboBoxSearchType_DAV;
        private Button buttonSearch_DAV;
        private TextBox textBoxInfo_DAV;
        private OpenFileDialog openFileDialog_DAV;
        private SaveFileDialog saveFileDialog_DAV;
        private Button buttonGetCompInfo_DAV;
        private Button buttonGetCharts_DAV;
        private GroupBox groupBoxStatisitc_DAV;
        private Panel panelInfo_DAV;
        private Button buttonSortBySalary_DAV;
        private Button buttonSortByExp_DAV;
        private Button buttonSortByLastName_DAV;
        private Button buttonSortById_DAV;
    }
}