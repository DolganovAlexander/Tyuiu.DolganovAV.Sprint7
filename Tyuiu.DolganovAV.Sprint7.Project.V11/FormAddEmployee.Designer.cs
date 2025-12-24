namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormAddEmployee
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
            components = new System.ComponentModel.Container();
            groupBoxAddEmployee_DAV = new GroupBox();
            buttonCancel_DAV = new Button();
            buttonAddEmp_DAV = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelLastName_DAV = new Label();
            textBoxDepartment_DAV = new TextBox();
            textBoxSalary_DAV = new TextBox();
            textBoxExpYears_DAV = new TextBox();
            textBoxBirthDate_DAV = new TextBox();
            textBoxMiddleName_DAV = new TextBox();
            textBoxFirstName_DAV = new TextBox();
            textBoxLastName_DAV = new TextBox();
            toolTipAddEmp_DAV = new ToolTip(components);
            groupBoxAddEmployee_DAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddEmployee_DAV
            // 
            groupBoxAddEmployee_DAV.Controls.Add(buttonCancel_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(buttonAddEmp_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(label7);
            groupBoxAddEmployee_DAV.Controls.Add(label6);
            groupBoxAddEmployee_DAV.Controls.Add(label5);
            groupBoxAddEmployee_DAV.Controls.Add(label4);
            groupBoxAddEmployee_DAV.Controls.Add(label3);
            groupBoxAddEmployee_DAV.Controls.Add(label2);
            groupBoxAddEmployee_DAV.Controls.Add(labelLastName_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxDepartment_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxSalary_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxExpYears_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxBirthDate_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxMiddleName_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxFirstName_DAV);
            groupBoxAddEmployee_DAV.Controls.Add(textBoxLastName_DAV);
            groupBoxAddEmployee_DAV.Dock = DockStyle.Fill;
            groupBoxAddEmployee_DAV.Font = new Font("Segoe UI", 11F);
            groupBoxAddEmployee_DAV.Location = new Point(0, 0);
            groupBoxAddEmployee_DAV.Name = "groupBoxAddEmployee_DAV";
            groupBoxAddEmployee_DAV.Size = new Size(639, 273);
            groupBoxAddEmployee_DAV.TabIndex = 0;
            groupBoxAddEmployee_DAV.TabStop = false;
            groupBoxAddEmployee_DAV.Text = "Ввод данных сотрудника";
            // 
            // buttonCancel_DAV
            // 
            buttonCancel_DAV.Location = new Point(407, 227);
            buttonCancel_DAV.Name = "buttonCancel_DAV";
            buttonCancel_DAV.Size = new Size(107, 34);
            buttonCancel_DAV.TabIndex = 22;
            buttonCancel_DAV.Text = "Отмена";
            toolTipAddEmp_DAV.SetToolTip(buttonCancel_DAV, "Отменить добавление сотрудника");
            buttonCancel_DAV.UseVisualStyleBackColor = true;
            buttonCancel_DAV.Click += buttonCancel_DAV_Click;
            // 
            // buttonAddEmp_DAV
            // 
            buttonAddEmp_DAV.Location = new Point(520, 227);
            buttonAddEmp_DAV.Name = "buttonAddEmp_DAV";
            buttonAddEmp_DAV.Size = new Size(107, 34);
            buttonAddEmp_DAV.TabIndex = 21;
            buttonAddEmp_DAV.Text = "Добавить";
            toolTipAddEmp_DAV.SetToolTip(buttonAddEmp_DAV, "Создать карточку нового сотрудника");
            buttonAddEmp_DAV.UseVisualStyleBackColor = true;
            buttonAddEmp_DAV.Click += buttonAddEmp_DAV_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 227);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 20;
            label7.Text = "Отдел";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 194);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 19;
            label6.Text = "Зарплата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 161);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 18;
            label5.Text = "Стаж";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 128);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 17;
            label4.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 95);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 16;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 15;
            label2.Text = "Имя";
            // 
            // labelLastName_DAV
            // 
            labelLastName_DAV.AutoSize = true;
            labelLastName_DAV.Location = new Point(16, 29);
            labelLastName_DAV.Name = "labelLastName_DAV";
            labelLastName_DAV.Size = new Size(91, 25);
            labelLastName_DAV.TabIndex = 14;
            labelLastName_DAV.Text = "Фамилия";
            // 
            // textBoxDepartment_DAV
            // 
            textBoxDepartment_DAV.Location = new Point(164, 224);
            textBoxDepartment_DAV.Name = "textBoxDepartment_DAV";
            textBoxDepartment_DAV.Size = new Size(125, 32);
            textBoxDepartment_DAV.TabIndex = 13;
            // 
            // textBoxSalary_DAV
            // 
            textBoxSalary_DAV.Location = new Point(164, 191);
            textBoxSalary_DAV.Name = "textBoxSalary_DAV";
            textBoxSalary_DAV.Size = new Size(125, 32);
            textBoxSalary_DAV.TabIndex = 12;
            // 
            // textBoxExpYears_DAV
            // 
            textBoxExpYears_DAV.Location = new Point(164, 158);
            textBoxExpYears_DAV.Name = "textBoxExpYears_DAV";
            textBoxExpYears_DAV.Size = new Size(125, 32);
            textBoxExpYears_DAV.TabIndex = 11;
            // 
            // textBoxBirthDate_DAV
            // 
            textBoxBirthDate_DAV.Location = new Point(164, 125);
            textBoxBirthDate_DAV.Name = "textBoxBirthDate_DAV";
            textBoxBirthDate_DAV.Size = new Size(125, 32);
            textBoxBirthDate_DAV.TabIndex = 10;
            // 
            // textBoxMiddleName_DAV
            // 
            textBoxMiddleName_DAV.Location = new Point(164, 92);
            textBoxMiddleName_DAV.Name = "textBoxMiddleName_DAV";
            textBoxMiddleName_DAV.Size = new Size(125, 32);
            textBoxMiddleName_DAV.TabIndex = 8;
            // 
            // textBoxFirstName_DAV
            // 
            textBoxFirstName_DAV.Location = new Point(164, 59);
            textBoxFirstName_DAV.Name = "textBoxFirstName_DAV";
            textBoxFirstName_DAV.Size = new Size(125, 32);
            textBoxFirstName_DAV.TabIndex = 9;
            // 
            // textBoxLastName_DAV
            // 
            textBoxLastName_DAV.Location = new Point(164, 26);
            textBoxLastName_DAV.Name = "textBoxLastName_DAV";
            textBoxLastName_DAV.Size = new Size(125, 32);
            textBoxLastName_DAV.TabIndex = 7;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 273);
            Controls.Add(groupBoxAddEmployee_DAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddEmployee";
            Text = "Добавить сотрудника";
            Load += FormAddEmployee_Load;
            groupBoxAddEmployee_DAV.ResumeLayout(false);
            groupBoxAddEmployee_DAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddEmployee_DAV;
        private TextBox textBoxDepartment_DAV;
        private TextBox textBoxSalary_DAV;
        private TextBox textBoxExpYears_DAV;
        private TextBox textBoxBirthDate_DAV;
        private TextBox textBoxMiddleName_DAV;
        private TextBox textBoxFirstName_DAV;
        private TextBox textBoxLastName_DAV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelLastName_DAV;
        private Button buttonAddEmp_DAV;
        private Button buttonCancel_DAV;
        private ToolTip toolTipAddEmp_DAV;
    }
}