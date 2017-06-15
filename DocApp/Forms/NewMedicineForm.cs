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
    public partial class NewMedicineForm : Form
    {
        public NewMedicineForm()
        {
            InitializeComponent();
        }

        private void NewMedicineForm_Load(object sender, EventArgs e)
        {

        }

        private void createMedicineButton_Click(object sender, EventArgs e)
        {
            var medicine = new Medicine()
            {
                Title = nameMedicineTextBox.Text,
                Description = descriptionTextBox.Text
            };

            using (var context = new DocContext())
            {
                context.Medicines.Add(medicine);
                context.SaveChanges();

                MessageBox.Show($"Le Médicament {medicine.Title} a été créé.");
                Close();
            }
        }
    }
}
