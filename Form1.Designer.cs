namespace EmployeeRecordNET
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBoxEmpRecord = new System.Windows.Forms.GroupBox();
            this.lblEmpJob = new System.Windows.Forms.Label();
            this.lblEmpState = new System.Windows.Forms.Label();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.lblEmpCity = new System.Windows.Forms.Label();
            this.lblEmpSurname = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtBoxEmpJob = new System.Windows.Forms.TextBox();
            this.rdBtnMarried = new System.Windows.Forms.RadioButton();
            this.rdBtnSingle = new System.Windows.Forms.RadioButton();
            this.mskdTxtBoxEmpSalary = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxEmpCity = new System.Windows.Forms.ComboBox();
            this.txtBoxEmpSurname = new System.Windows.Forms.TextBox();
            this.txtBoxEmpName = new System.Windows.Forms.TextBox();
            this.txtBoxEmpId = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBoxProcess = new System.Windows.Forms.GroupBox();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxRecords = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new EmployeeRecordNET.PersonelVeriTabaniDataSet();
            this.table_1TableAdapter = new EmployeeRecordNET.PersonelVeriTabaniDataSetTableAdapters.Table_1TableAdapter();
            this.lblControl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxEmpRecord.SuspendLayout();
            this.grpBoxProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxEmpRecord
            // 
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpJob);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpState);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpSalary);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpCity);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpSurname);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpName);
            this.grpBoxEmpRecord.Controls.Add(this.lblEmpId);
            this.grpBoxEmpRecord.Controls.Add(this.txtBoxEmpJob);
            this.grpBoxEmpRecord.Controls.Add(this.rdBtnMarried);
            this.grpBoxEmpRecord.Controls.Add(this.rdBtnSingle);
            this.grpBoxEmpRecord.Controls.Add(this.mskdTxtBoxEmpSalary);
            this.grpBoxEmpRecord.Controls.Add(this.cmbBoxEmpCity);
            this.grpBoxEmpRecord.Controls.Add(this.txtBoxEmpSurname);
            this.grpBoxEmpRecord.Controls.Add(this.txtBoxEmpName);
            this.grpBoxEmpRecord.Controls.Add(this.txtBoxEmpId);
            this.grpBoxEmpRecord.Location = new System.Drawing.Point(15, 15);
            this.grpBoxEmpRecord.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxEmpRecord.Name = "grpBoxEmpRecord";
            this.grpBoxEmpRecord.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxEmpRecord.Size = new System.Drawing.Size(450, 308);
            this.grpBoxEmpRecord.TabIndex = 0;
            this.grpBoxEmpRecord.TabStop = false;
            this.grpBoxEmpRecord.Text = "Employee Record";
            // 
            // lblEmpJob
            // 
            this.lblEmpJob.AutoSize = true;
            this.lblEmpJob.Location = new System.Drawing.Point(46, 257);
            this.lblEmpJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpJob.Name = "lblEmpJob";
            this.lblEmpJob.Size = new System.Drawing.Size(119, 20);
            this.lblEmpJob.TabIndex = 14;
            this.lblEmpJob.Text = "Employee Job:";
            // 
            // lblEmpState
            // 
            this.lblEmpState.AutoSize = true;
            this.lblEmpState.Location = new System.Drawing.Point(118, 224);
            this.lblEmpState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpState.Name = "lblEmpState";
            this.lblEmpState.Size = new System.Drawing.Size(53, 20);
            this.lblEmpState.TabIndex = 13;
            this.lblEmpState.Text = "State:";
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Location = new System.Drawing.Point(30, 190);
            this.lblEmpSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(139, 20);
            this.lblEmpSalary.TabIndex = 12;
            this.lblEmpSalary.Text = "Employee Salary:";
            // 
            // lblEmpCity
            // 
            this.lblEmpCity.AutoSize = true;
            this.lblEmpCity.Location = new System.Drawing.Point(49, 153);
            this.lblEmpCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpCity.Name = "lblEmpCity";
            this.lblEmpCity.Size = new System.Drawing.Size(121, 20);
            this.lblEmpCity.TabIndex = 11;
            this.lblEmpCity.Text = "Employee City:";
            // 
            // lblEmpSurname
            // 
            this.lblEmpSurname.AutoSize = true;
            this.lblEmpSurname.Location = new System.Drawing.Point(8, 117);
            this.lblEmpSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpSurname.Name = "lblEmpSurname";
            this.lblEmpSurname.Size = new System.Drawing.Size(159, 20);
            this.lblEmpSurname.TabIndex = 10;
            this.lblEmpSurname.Text = "Employee Surname:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(30, 83);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(136, 20);
            this.lblEmpName.TabIndex = 9;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(62, 47);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(105, 20);
            this.lblEmpId.TabIndex = 8;
            this.lblEmpId.Text = "Employee Id:";
            // 
            // txtBoxEmpJob
            // 
            this.txtBoxEmpJob.Location = new System.Drawing.Point(178, 254);
            this.txtBoxEmpJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpJob.Name = "txtBoxEmpJob";
            this.txtBoxEmpJob.Size = new System.Drawing.Size(202, 27);
            this.txtBoxEmpJob.TabIndex = 8;
            // 
            // rdBtnMarried
            // 
            this.rdBtnMarried.AutoSize = true;
            this.rdBtnMarried.Location = new System.Drawing.Point(293, 220);
            this.rdBtnMarried.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnMarried.Name = "rdBtnMarried";
            this.rdBtnMarried.Size = new System.Drawing.Size(87, 24);
            this.rdBtnMarried.TabIndex = 7;
            this.rdBtnMarried.TabStop = true;
            this.rdBtnMarried.Text = "Married";
            this.rdBtnMarried.UseVisualStyleBackColor = true;
            this.rdBtnMarried.CheckedChanged += new System.EventHandler(this.rdBtnMarried_CheckedChanged);
            // 
            // rdBtnSingle
            // 
            this.rdBtnSingle.AutoSize = true;
            this.rdBtnSingle.Location = new System.Drawing.Point(178, 221);
            this.rdBtnSingle.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnSingle.Name = "rdBtnSingle";
            this.rdBtnSingle.Size = new System.Drawing.Size(76, 24);
            this.rdBtnSingle.TabIndex = 6;
            this.rdBtnSingle.TabStop = true;
            this.rdBtnSingle.Text = "Single";
            this.rdBtnSingle.UseVisualStyleBackColor = true;
            this.rdBtnSingle.CheckedChanged += new System.EventHandler(this.rdBtnSingle_CheckedChanged);
            // 
            // mskdTxtBoxEmpSalary
            // 
            this.mskdTxtBoxEmpSalary.Location = new System.Drawing.Point(178, 186);
            this.mskdTxtBoxEmpSalary.Margin = new System.Windows.Forms.Padding(4);
            this.mskdTxtBoxEmpSalary.Mask = "00000";
            this.mskdTxtBoxEmpSalary.Name = "mskdTxtBoxEmpSalary";
            this.mskdTxtBoxEmpSalary.Size = new System.Drawing.Size(202, 27);
            this.mskdTxtBoxEmpSalary.TabIndex = 5;
            // 
            // cmbBoxEmpCity
            // 
            this.cmbBoxEmpCity.FormattingEnabled = true;
            this.cmbBoxEmpCity.Items.AddRange(new object[] {
            "Istanbul",
            "Bursa",
            "Edirne",
            "Ankara"});
            this.cmbBoxEmpCity.Location = new System.Drawing.Point(178, 149);
            this.cmbBoxEmpCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxEmpCity.Name = "cmbBoxEmpCity";
            this.cmbBoxEmpCity.Size = new System.Drawing.Size(202, 28);
            this.cmbBoxEmpCity.TabIndex = 4;
            // 
            // txtBoxEmpSurname
            // 
            this.txtBoxEmpSurname.Location = new System.Drawing.Point(178, 114);
            this.txtBoxEmpSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpSurname.Name = "txtBoxEmpSurname";
            this.txtBoxEmpSurname.Size = new System.Drawing.Size(202, 27);
            this.txtBoxEmpSurname.TabIndex = 3;
            // 
            // txtBoxEmpName
            // 
            this.txtBoxEmpName.Location = new System.Drawing.Point(178, 79);
            this.txtBoxEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpName.Name = "txtBoxEmpName";
            this.txtBoxEmpName.Size = new System.Drawing.Size(202, 27);
            this.txtBoxEmpName.TabIndex = 2;
            // 
            // txtBoxEmpId
            // 
            this.txtBoxEmpId.Location = new System.Drawing.Point(178, 44);
            this.txtBoxEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmpId.Name = "txtBoxEmpId";
            this.txtBoxEmpId.Size = new System.Drawing.Size(202, 27);
            this.txtBoxEmpId.TabIndex = 1;
            // 
            // grpBoxProcess
            // 
            this.grpBoxProcess.Controls.Add(this.button1);
            this.grpBoxProcess.Controls.Add(this.btnGraphics);
            this.grpBoxProcess.Controls.Add(this.btnStatistics);
            this.grpBoxProcess.Controls.Add(this.btnClear);
            this.grpBoxProcess.Controls.Add(this.btnUpdate);
            this.grpBoxProcess.Controls.Add(this.btnDelete);
            this.grpBoxProcess.Controls.Add(this.btnRecord);
            this.grpBoxProcess.Controls.Add(this.btnList);
            this.grpBoxProcess.Location = new System.Drawing.Point(472, 15);
            this.grpBoxProcess.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxProcess.Name = "grpBoxProcess";
            this.grpBoxProcess.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxProcess.Size = new System.Drawing.Size(313, 308);
            this.grpBoxProcess.TabIndex = 1;
            this.grpBoxProcess.TabStop = false;
            this.grpBoxProcess.Text = "Process";
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(79, 225);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(149, 27);
            this.btnGraphics.TabIndex = 15;
            this.btnGraphics.Text = "Graphics";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(79, 192);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(149, 27);
            this.btnStatistics.TabIndex = 14;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(79, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 27);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(79, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 27);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(79, 60);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(149, 27);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(79, 27);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(149, 27);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(792, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxRecords
            // 
            this.grpBoxRecords.Controls.Add(this.dataGridView1);
            this.grpBoxRecords.Location = new System.Drawing.Point(15, 330);
            this.grpBoxRecords.Name = "grpBoxRecords";
            this.grpBoxRecords.Size = new System.Drawing.Size(973, 180);
            this.grpBoxRecords.TabIndex = 3;
            this.grpBoxRecords.TabStop = false;
            this.grpBoxRecords.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empSurnameDataGridViewTextBoxColumn,
            this.empCityDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn,
            this.empStatusDataGridViewCheckBoxColumn,
            this.empJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(967, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSurnameDataGridViewTextBoxColumn
            // 
            this.empSurnameDataGridViewTextBoxColumn.DataPropertyName = "EmpSurname";
            this.empSurnameDataGridViewTextBoxColumn.HeaderText = "EmpSurname";
            this.empSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSurnameDataGridViewTextBoxColumn.Name = "empSurnameDataGridViewTextBoxColumn";
            this.empSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empCityDataGridViewTextBoxColumn
            // 
            this.empCityDataGridViewTextBoxColumn.DataPropertyName = "EmpCity";
            this.empCityDataGridViewTextBoxColumn.HeaderText = "EmpCity";
            this.empCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empCityDataGridViewTextBoxColumn.Name = "empCityDataGridViewTextBoxColumn";
            this.empCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            this.empSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // empStatusDataGridViewCheckBoxColumn
            // 
            this.empStatusDataGridViewCheckBoxColumn.DataPropertyName = "EmpStatus";
            this.empStatusDataGridViewCheckBoxColumn.HeaderText = "EmpStatus";
            this.empStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.empStatusDataGridViewCheckBoxColumn.Name = "empStatusDataGridViewCheckBoxColumn";
            this.empStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // empJobDataGridViewTextBoxColumn
            // 
            this.empJobDataGridViewTextBoxColumn.DataPropertyName = "EmpJob";
            this.empJobDataGridViewTextBoxColumn.HeaderText = "EmpJob";
            this.empJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empJobDataGridViewTextBoxColumn.Name = "empJobDataGridViewTextBoxColumn";
            this.empJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(861, 276);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(53, 20);
            this.lblControl.TabIndex = 4;
            this.lblControl.Text = "label1";
            this.lblControl.Visible = false;
            this.lblControl.TextChanged += new System.EventHandler(this.lblControl_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reporting";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1019, 563);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.grpBoxRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBoxProcess);
            this.Controls.Add(this.grpBoxEmpRecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employee Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxEmpRecord.ResumeLayout(false);
            this.grpBoxEmpRecord.PerformLayout();
            this.grpBoxProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEmpRecord;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBoxProcess;
        private System.Windows.Forms.Label lblEmpJob;
        private System.Windows.Forms.Label lblEmpState;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Label lblEmpCity;
        private System.Windows.Forms.Label lblEmpSurname;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtBoxEmpJob;
        private System.Windows.Forms.RadioButton rdBtnMarried;
        private System.Windows.Forms.RadioButton rdBtnSingle;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxEmpSalary;
        private System.Windows.Forms.ComboBox cmbBoxEmpCity;
        private System.Windows.Forms.TextBox txtBoxEmpSurname;
        private System.Windows.Forms.TextBox txtBoxEmpName;
        private System.Windows.Forms.TextBox txtBoxEmpId;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Button button1;
    }
}

