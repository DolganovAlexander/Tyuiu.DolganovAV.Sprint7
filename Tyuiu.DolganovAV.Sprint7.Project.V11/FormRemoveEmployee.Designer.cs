namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormRemoveEmployee
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
            groupBoxRemoveEmp_DAV = new GroupBox();
            buttonCancel_DAV = new Button();
            buttonRemoveEmp_DAV = new Button();
            labelEmpInfo_DAV = new Label();
            toolTipRmvEmp_DAV = new ToolTip(components);
            groupBoxRemoveEmp_DAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRemoveEmp_DAV
            // 
            groupBoxRemoveEmp_DAV.Controls.Add(buttonCancel_DAV);
            groupBoxRemoveEmp_DAV.Controls.Add(buttonRemoveEmp_DAV);
            groupBoxRemoveEmp_DAV.Controls.Add(labelEmpInfo_DAV);
            groupBoxRemoveEmp_DAV.Dock = DockStyle.Fill;
            groupBoxRemoveEmp_DAV.Font = new Font("Segoe UI", 11F);
            groupBoxRemoveEmp_DAV.Location = new Point(0, 0);
            groupBoxRemoveEmp_DAV.Name = "groupBoxRemoveEmp_DAV";
            groupBoxRemoveEmp_DAV.Size = new Size(639, 273);
            groupBoxRemoveEmp_DAV.TabIndex = 0;
            groupBoxRemoveEmp_DAV.TabStop = false;
            groupBoxRemoveEmp_DAV.Text = "Вы действительно хотите удалить:";
            // 
            // buttonCancel_DAV
            // 
            buttonCancel_DAV.Location = new Point(407, 227);
            buttonCancel_DAV.Name = "buttonCancel_DAV";
            buttonCancel_DAV.Size = new Size(107, 34);
            buttonCancel_DAV.TabIndex = 24;
            buttonCancel_DAV.Text = "Отмена";
            toolTipRmvEmp_DAV.SetToolTip(buttonCancel_DAV, "Отменить удаление выбранного сотрудника");
            buttonCancel_DAV.UseVisualStyleBackColor = true;
            buttonCancel_DAV.Click += buttonCancel_DAV_Click;
            // 
            // buttonRemoveEmp_DAV
            // 
            buttonRemoveEmp_DAV.Location = new Point(520, 227);
            buttonRemoveEmp_DAV.Name = "buttonRemoveEmp_DAV";
            buttonRemoveEmp_DAV.Size = new Size(107, 34);
            buttonRemoveEmp_DAV.TabIndex = 23;
            buttonRemoveEmp_DAV.Text = "Удалить";
            toolTipRmvEmp_DAV.SetToolTip(buttonRemoveEmp_DAV, "Удалить карточку сотрудника");
            buttonRemoveEmp_DAV.UseVisualStyleBackColor = true;
            buttonRemoveEmp_DAV.Click += buttonRemoveEmp_DAV_Click;
            // 
            // labelEmpInfo_DAV
            // 
            labelEmpInfo_DAV.AutoSize = true;
            labelEmpInfo_DAV.Location = new Point(12, 37);
            labelEmpInfo_DAV.Name = "labelEmpInfo_DAV";
            labelEmpInfo_DAV.Size = new Size(42, 25);
            labelEmpInfo_DAV.TabIndex = 0;
            labelEmpInfo_DAV.Text = "123";
            // 
            // FormRemoveEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 273);
            Controls.Add(groupBoxRemoveEmp_DAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRemoveEmployee";
            Text = "Удаление сотрудника";
            groupBoxRemoveEmp_DAV.ResumeLayout(false);
            groupBoxRemoveEmp_DAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRemoveEmp_DAV;
        private Label labelEmpInfo_DAV;
        private Button buttonCancel_DAV;
        private Button buttonRemoveEmp_DAV;
        private ToolTip toolTipRmvEmp_DAV;
    }
}