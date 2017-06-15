namespace DocApp.Forms
{
    partial class PatientForm
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
            this.civilityLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientRefIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.decasesLabel = new System.Windows.Forms.Label();
            this.diseaseTextBox = new System.Windows.Forms.TextBox();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.treatmentTextBox = new System.Windows.Forms.TextBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.medicinesLabel = new System.Windows.Forms.Label();
            this.disLabel = new System.Windows.Forms.Label();
            this.treatLabel = new System.Windows.Forms.Label();
            this.reportMedicinesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // civilityLabel
            // 
            this.civilityLabel.AutoSize = true;
            this.civilityLabel.Location = new System.Drawing.Point(27, 9);
            this.civilityLabel.Name = "civilityLabel";
            this.civilityLabel.Size = new System.Drawing.Size(35, 13);
            this.civilityLabel.TabIndex = 0;
            this.civilityLabel.Text = "civility";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(68, 9);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(46, 13);
            this.fullnameLabel.TabIndex = 1;
            this.fullnameLabel.Text = "fullname";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(DocApp.Models.Report);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.patientRefIdDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.medicinesDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "Disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            this.diseaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseDataGridViewTextBoxColumn.Width = 175;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.treatmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientRefIdDataGridViewTextBoxColumn
            // 
            this.patientRefIdDataGridViewTextBoxColumn.DataPropertyName = "PatientRefId";
            this.patientRefIdDataGridViewTextBoxColumn.HeaderText = "PatientRefId";
            this.patientRefIdDataGridViewTextBoxColumn.Name = "patientRefIdDataGridViewTextBoxColumn";
            this.patientRefIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientRefIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicinesDataGridViewTextBoxColumn
            // 
            this.medicinesDataGridViewTextBoxColumn.DataPropertyName = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.HeaderText = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.Name = "medicinesDataGridViewTextBoxColumn";
            this.medicinesDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicinesDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // MedicinesCheckedListBox
            // 
            this.MedicinesCheckedListBox.FormattingEnabled = true;
            this.MedicinesCheckedListBox.Location = new System.Drawing.Point(12, 355);
            this.MedicinesCheckedListBox.Name = "MedicinesCheckedListBox";
            this.MedicinesCheckedListBox.Size = new System.Drawing.Size(180, 169);
            this.MedicinesCheckedListBox.TabIndex = 3;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(278, 321);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(39, 13);
            this.reportLabel.TabIndex = 4;
            this.reportLabel.Text = "Report";
            // 
            // decasesLabel
            // 
            this.decasesLabel.AutoSize = true;
            this.decasesLabel.Location = new System.Drawing.Point(229, 355);
            this.decasesLabel.Name = "decasesLabel";
            this.decasesLabel.Size = new System.Drawing.Size(45, 13);
            this.decasesLabel.TabIndex = 5;
            this.decasesLabel.Text = "Disease";
            // 
            // diseaseTextBox
            // 
            this.diseaseTextBox.Location = new System.Drawing.Point(307, 352);
            this.diseaseTextBox.Name = "diseaseTextBox";
            this.diseaseTextBox.Size = new System.Drawing.Size(338, 20);
            this.diseaseTextBox.TabIndex = 6;
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Location = new System.Drawing.Point(229, 386);
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(55, 13);
            this.treatmentLabel.TabIndex = 7;
            this.treatmentLabel.Text = "Treatment";
            // 
            // treatmentTextBox
            // 
            this.treatmentTextBox.Location = new System.Drawing.Point(307, 386);
            this.treatmentTextBox.Multiline = true;
            this.treatmentTextBox.Name = "treatmentTextBox";
            this.treatmentTextBox.Size = new System.Drawing.Size(338, 97);
            this.treatmentTextBox.TabIndex = 8;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(415, 489);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(138, 35);
            this.createReportButton.TabIndex = 9;
            this.createReportButton.Text = "create report";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // medicinesLabel
            // 
            this.medicinesLabel.AutoSize = true;
            this.medicinesLabel.Location = new System.Drawing.Point(12, 339);
            this.medicinesLabel.Name = "medicinesLabel";
            this.medicinesLabel.Size = new System.Drawing.Size(86, 13);
            this.medicinesLabel.TabIndex = 10;
            this.medicinesLabel.Text = "List of Medicines";
            // 
            // disLabel
            // 
            this.disLabel.AutoSize = true;
            this.disLabel.Location = new System.Drawing.Point(480, 35);
            this.disLabel.Name = "disLabel";
            this.disLabel.Size = new System.Drawing.Size(43, 13);
            this.disLabel.TabIndex = 11;
            this.disLabel.Text = "disease";
            // 
            // treatLabel
            // 
            this.treatLabel.AutoSize = true;
            this.treatLabel.Location = new System.Drawing.Point(369, 77);
            this.treatLabel.Name = "treatLabel";
            this.treatLabel.Size = new System.Drawing.Size(51, 13);
            this.treatLabel.TabIndex = 12;
            this.treatLabel.Text = "treatment";
            // 
            // reportMedicinesListBox
            // 
            this.reportMedicinesListBox.FormattingEnabled = true;
            this.reportMedicinesListBox.Location = new System.Drawing.Point(415, 176);
            this.reportMedicinesListBox.Name = "reportMedicinesListBox";
            this.reportMedicinesListBox.Size = new System.Drawing.Size(180, 121);
            this.reportMedicinesListBox.TabIndex = 13;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 536);
            this.Controls.Add(this.reportMedicinesListBox);
            this.Controls.Add(this.treatLabel);
            this.Controls.Add(this.disLabel);
            this.Controls.Add(this.medicinesLabel);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.treatmentTextBox);
            this.Controls.Add(this.treatmentLabel);
            this.Controls.Add(this.diseaseTextBox);
            this.Controls.Add(this.decasesLabel);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.MedicinesCheckedListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.civilityLabel);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label civilityLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientRefIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox MedicinesCheckedListBox;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label decasesLabel;
        private System.Windows.Forms.TextBox diseaseTextBox;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.TextBox treatmentTextBox;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Label medicinesLabel;
        private System.Windows.Forms.Label disLabel;
        private System.Windows.Forms.Label treatLabel;
        private System.Windows.Forms.ListBox reportMedicinesListBox;
    }
}