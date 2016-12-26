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
        public event EventHandler GetAvailablePrinters;

        public PrescriptionForm()
        {
            InitializeComponent();
        }

        public void InitializeForm()
        {
            OnGetAvailablePrinters();
        }

        public void ClearPatientData()
        {
            prescriptionNumberBox.ResetText();
            patientNameBox.Text = "";
            cityBox.Text = "";
            ageBox.Text = "";
            peselBox.Text = "";
            nfzNumberBox.ResetText();
            priviligesCheckBox.Checked = false;
            illnessCheckBox.Checked = false;
            prescriptionTextBox.Text = "";
        }

        public void PopulatePrinterList(String printer)
        {
            printerList.Items.Add(printer);
        }

        protected virtual void OnPrescriptionNumberChanged(EventArgs<String> args)
        {
            var eventHandler = this.PrescriptionNumberChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnGetAvailablePrinters()
        {
            var eventHandler = this.GetAvailablePrinters;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        private void prescriptionNumberBox_Leave(object sender, EventArgs e)
        {
            MaskedTextBox temp = (MaskedTextBox)sender;
            OnPrescriptionNumberChanged(new EventArgs<String>(temp.Text));
        }
    }
}
