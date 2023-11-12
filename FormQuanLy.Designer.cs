namespace LTTQ_Proj
{
    partial class FormQuanLy
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabSinhVien = new TabPage();
            groupBoxSinhVienViewData = new GroupBox();
            dataGridViewSinhVien = new DataGridView();
            groupBoxSinhVien2 = new GroupBox();
            groupBoxSinhVien1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabSinhVien.SuspendLayout();
            groupBoxSinhVienViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabSinhVien);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabSinhVien
            // 
            tabSinhVien.Controls.Add(groupBoxSinhVienViewData);
            tabSinhVien.Controls.Add(groupBoxSinhVien2);
            tabSinhVien.Controls.Add(groupBoxSinhVien1);
            tabSinhVien.Location = new Point(4, 24);
            tabSinhVien.Name = "tabSinhVien";
            tabSinhVien.Padding = new Padding(3);
            tabSinhVien.Size = new Size(792, 422);
            tabSinhVien.TabIndex = 1;
            tabSinhVien.Text = "Sinh Viên";
            tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBoxSinhVienViewData
            // 
            groupBoxSinhVienViewData.Controls.Add(dataGridViewSinhVien);
            groupBoxSinhVienViewData.Location = new Point(404, 6);
            groupBoxSinhVienViewData.Name = "groupBoxSinhVienViewData";
            groupBoxSinhVienViewData.Size = new Size(382, 408);
            groupBoxSinhVienViewData.TabIndex = 2;
            groupBoxSinhVienViewData.TabStop = false;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Dock = DockStyle.Fill;
            dataGridViewSinhVien.Location = new Point(3, 19);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowTemplate.Height = 25;
            dataGridViewSinhVien.Size = new Size(376, 386);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // groupBoxSinhVien2
            // 
            groupBoxSinhVien2.Location = new Point(8, 263);
            groupBoxSinhVien2.Name = "groupBoxSinhVien2";
            groupBoxSinhVien2.Size = new Size(390, 151);
            groupBoxSinhVien2.TabIndex = 1;
            groupBoxSinhVien2.TabStop = false;
            // 
            // groupBoxSinhVien1
            // 
            groupBoxSinhVien1.Location = new Point(8, 6);
            groupBoxSinhVien1.Name = "groupBoxSinhVien1";
            groupBoxSinhVien1.Size = new Size(390, 251);
            groupBoxSinhVien1.TabIndex = 0;
            groupBoxSinhVien1.TabStop = false;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormQuanLy";
            Text = "FormQuanLy";
            Load += FormQuanLy_Load;
            tabControl1.ResumeLayout(false);
            tabSinhVien.ResumeLayout(false);
            groupBoxSinhVienViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabSinhVien;
        private GroupBox groupBoxSinhVien2;
        private GroupBox groupBoxSinhVien1;
        private GroupBox groupBoxSinhVienViewData;
        private DataGridView dataGridViewSinhVien;
    }
}