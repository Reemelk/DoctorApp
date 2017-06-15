using DocApp.Data;
using DocApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DocApp.Forms
{
    public partial class PatientForm : Form
    {
        int patient_id;

        public PatientForm(String id)
        {
            InitializeComponent();

            patient_id = Int32.Parse(id);
            Patient patient = GetPatient(patient_id);
            civilityLabel.Text = patient.Civility;
            fullnameLabel.Text = patient.Fullname;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            GetReportByPatient(patient_id);

            List<Medicine> medicines = GetListOfMedicines();
            foreach (Medicine medicine in medicines)
            {
                MedicinesCheckedListBox.Items.Add(medicine.Title);
            }
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            using (var context = new DocContext())
            {
                var patient = GetPatient(patient_id);

                Report new_report = new Report
                {
                    Disease = diseaseTextBox.Text,
                    Treatment = treatmentTextBox.Text,
                    PatientRefId = patient.Id
                };

                foreach (string medicine in MedicinesCheckedListBox.CheckedItems)
                {
                    var med = getMedicine(medicine);
                    new_report.Medicines.Add(med);
                }

                context.Reports.Attach(new_report);
                context.Reports.Add(new_report);
                context.SaveChanges();

                MessageBox.Show("Le Report a été créé.");
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            String report_id = selectedRow.Cells[0].Value.ToString();
            var report = getReport(report_id);

            // spreading data from report
            disLabel.Text = report.Disease;
            treatLabel.Text = report.Treatment;

            // query doesn't work
            //var meds = getListMeds(report.Id);
            //foreach (var med in meds)
            //{
            //    reportMedicinesListBox.Items.Add(med);
            //}
        }

        // Fetch all sort of datas
        private Patient GetPatient(int patient_id)
        {
            using (var context = new DocContext())
            {
                return context.Patients.Find(patient_id);
            }
        }

        private void GetReportByPatient(int id)
        {
            using (var context = new DocContext())
            {
                reportBindingSource.DataSource = context.Reports
                    .Where(e => e.PatientRefId == id)
                    .OrderByDescending(e => e.CreatedAt)
                    .ToList();
            }
        }

        private List<Medicine> GetListOfMedicines()
        {
            using (var context = new DocContext())
            {
                return context.Medicines.ToList();
            }
        }

        private Medicine getMedicine(string title)
        {
            using (var context = new DocContext())
            {
                return context.Medicines.FirstOrDefault(med => med.Title == title);
            }
        }

        private Report getReport(string id)
        {
            using (var context = new DocContext())
            {
                int l = Int32.Parse(id);

                return context.Reports.Find(l);
            }
        }

        //private List<Medicine> getListMeds(int report_id)
        //{
        //    using (var context = new DocContext())
        //    {
        //        return context.Reports.Where(r => r.ReportId == report_id).SelectMany(m => m.Medicines).ToList();
        //    }
        //}
    }
}
