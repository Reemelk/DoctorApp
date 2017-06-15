using DocApp.Data;
using DocApp.Models;
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
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                Civility = mrRadioButton.Checked ? (string)mrRadioButton.Tag : (string)mrsRadioButton.Tag, // ternaire
                Lastname = lastnameTextBox.Text,
                Firstname = firstnameTextBox.Text,
                DOB = DOBDateTimePicker.Value
            };

            using (var context = new DocContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();

                MessageBox.Show($"Le patient {patient.Fullname} a été créé.");
                Close();
            }
        }
    }
}
