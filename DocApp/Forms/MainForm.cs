using DocApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetPatientsList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetPatientsList();
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            NewPatientForm frm = new NewPatientForm();
            frm.Show();
        }

        private void newMedicineButton_Click(object sender, EventArgs e)
        {
            NewMedicineForm frm = new NewMedicineForm();
            frm.Show();
        }

        // Fetch all patients
        private void GetPatientsList()
        {
            using (var context = new DocContext())
            {
                patientBindingSource.DataSource = context.Patients
                    .OrderBy(e => e.Lastname)
                    .ThenBy(e => e.Firstname)
                    .ToList();
            }
        }

        private void patientsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = patientsDataGridView.Rows[e.RowIndex];
            String patient_id = selectedRow.Cells[0].Value.ToString();
            PatientForm frm = new PatientForm(patient_id);
            frm.Show();
        }
    }
}
