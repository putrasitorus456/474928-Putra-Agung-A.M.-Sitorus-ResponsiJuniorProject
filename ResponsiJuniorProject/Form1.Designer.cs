namespace ResponsiJuniorProject
{
    partial class Form1
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
            lblLogo = new Label();
            lblNama = new Label();
            lblDep = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            dgvData = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.Location = new Point(106, 29);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(57, 28);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Logo";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNama.Location = new Point(32, 93);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(131, 21);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Karyawan :";
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDep.Location = new Point(43, 128);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(120, 21);
            lblDep.TabIndex = 2;
            lblDep.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(169, 93);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(175, 23);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(169, 130);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(175, 23);
            cbDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(169, 187);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 32);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(313, 187);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 32);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(472, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(590, 45);
            label1.Name = "label1";
            label1.Size = new Size(160, 126);
            label1.TabIndex = 8;
            label1.Text = "ID Departemen:\r\nHR : HR\r\nENG : Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN : Finance";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(32, 236);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(730, 150);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(687, 402);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(lblDep);
            Controls.Add(lblNama);
            Controls.Add(lblLogo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private Label lblNama;
        private Label lblDep;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private DataGridView dgvData;
        private Button btnLoad;
    }
}