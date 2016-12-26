using PrintPrescription.Presenter;
using PrintPrescription.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPrescription
{
    public partial class PrescriptionForm : Form, IPrescriptionForm
    {
        public event EventHandler<EventArgs<String>> PrescriptionNumberChanged;

        public PrescriptionForm()
        {
            InitializeComponent();
        }

        public void ClearPatientData()
        {
            patientNameBox.Text = "Test successful";
        }

        public void SetPatientAgeTest(String args)
        {
            ageBox.Text = args;
        }

        protected virtual void OnPrescriptionNumberChanged(EventArgs<String> args)
        {
            var eventHandler = this.PrescriptionNumberChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        private void prescriptionNumberBox_Leave(object sender, EventArgs e)
        {
            MaskedTextBox temp = (MaskedTextBox)sender;
            OnPrescriptionNumberChanged(new EventArgs<String>(temp.Text));
        }
    }
}
