namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panelAbout_DAV = new Panel();
            labelAbout_DAV = new Label();
            buttonDone_DAV = new Button();
            pictureBoxAva_DAV = new PictureBox();
            panelAbout_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_DAV).BeginInit();
            SuspendLayout();
            // 
            // panelAbout_DAV
            // 
            panelAbout_DAV.Controls.Add(labelAbout_DAV);
            panelAbout_DAV.Controls.Add(buttonDone_DAV);
            panelAbout_DAV.Controls.Add(pictureBoxAva_DAV);
            panelAbout_DAV.Dock = DockStyle.Fill;
            panelAbout_DAV.Location = new Point(0, 0);
            panelAbout_DAV.Name = "panelAbout_DAV";
            panelAbout_DAV.Size = new Size(700, 327);
            panelAbout_DAV.TabIndex = 0;
            // 
            // labelAbout_DAV
            // 
            labelAbout_DAV.AutoSize = true;
            labelAbout_DAV.Font = new Font("Segoe UI", 10F);
            labelAbout_DAV.Location = new Point(228, 12);
            labelAbout_DAV.Name = "labelAbout_DAV";
            labelAbout_DAV.Size = new Size(438, 207);
            labelAbout_DAV.TabIndex = 2;
            labelAbout_DAV.Text = resources.GetString("labelAbout_DAV.Text");
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Font = new Font("Segoe UI", 12F);
            buttonDone_DAV.Location = new Point(587, 278);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(101, 37);
            buttonDone_DAV.TabIndex = 1;
            buttonDone_DAV.Text = "OK";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // pictureBoxAva_DAV
            // 
            pictureBoxAva_DAV.Image = (Image)resources.GetObject("pictureBoxAva_DAV.Image");
            pictureBoxAva_DAV.Location = new Point(12, 12);
            pictureBoxAva_DAV.Name = "pictureBoxAva_DAV";
            pictureBoxAva_DAV.Size = new Size(210, 303);
            pictureBoxAva_DAV.TabIndex = 0;
            pictureBoxAva_DAV.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 327);
            Controls.Add(panelAbout_DAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            panelAbout_DAV.ResumeLayout(false);
            panelAbout_DAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAbout_DAV;
        private Button buttonDone_DAV;
        private PictureBox pictureBoxAva_DAV;
        private Label labelAbout_DAV;
    }
}