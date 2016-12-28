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
        public event EventHandler<EventArgs<String>> PatientNameChanged;
        public event EventHandler<EventArgs<String>> CityChanged;
        public event EventHandler<EventArgs<int>> AgeChanged;
        public event EventHandler<EventArgs<String>> PeselChanged;
        public event EventHandler<EventArgs<int>> NfzNumberChanged;
        public event EventHandler<EventArgs<bool>> PriviligesChanged;
        public event EventHandler<EventArgs<bool>> IllnessChanged;
        public event EventHandler<EventArgs<String>> PrescriptionTextChanged;
        public event EventHandler PrintStart;
        public event EventHandler<EventArgs<String>> DoctorNameChanged;

        public event EventHandler GetAvailablePrinters;

        public PrescriptionForm()
        {
            InitializeComponent();
        }

        public void InitializeForm()
        {
            OnGetAvailablePrinters();
            ChooseFirstPrinter();
        }

        private void ChooseFirstPrinter()
        {
            if (printerList.Items.Count > 0)
                printerList.SelectedIndex = 0;
        }

        public void ClearPatientData()
        {
            prescriptionNumberBox.ResetText();
            patientNameBox.Text = "";
            cityBox.Text = "";
            ageBox.Value = 1;
            peselBox.Text = "";
            nfzNumberBox.Value = 1;
            priviligesCheckBox.Checked = false;
            illnessCheckBox.Checked = false;
            prescriptionTextBox.Text = "";
            errorLabel.Text = "";
        }

        public void SetErrorLabel(String text)
        {
            errorLabel.Text = text;
        }

        public void SetError(object control, String text)
        {
            errorProvider.SetError((Control)control, text);
        }

        public void ClearError(object control)
        {
            errorProvider.SetError((Control)control, "");
        }

        public object GetChosenPrinter()
        {
            return printerList.SelectedItem;
        }

        public String GetDoctorName()
        {
            return doctorTextBox.Text;
        }

        public void PopulatePrinterList(String printer)
        {
            printerList.Items.Add(printer);
        }

        protected virtual void OnPrescriptionNumberChanged(EventArgs<String> args)
        {
            var eventHandler = this.PrescriptionNumberChanged;
            if (eventHandler != null)
                eventHandler.Invoke(prescriptionNumberBox, args);
        }

        protected virtual void OnPatientNameChanged(EventArgs<String> args)
        {
            var eventHandler = this.PatientNameChanged;
            if (eventHandler != null)
                eventHandler.Invoke(patientNameBox, args);
        }

        protected virtual void OnCityChanged(EventArgs<String> args)
        {
            var eventHandler = this.CityChanged;
            if (eventHandler != null)
                eventHandler.Invoke(cityBox, args);
        }

        protected virtual void OnAgeChanged(EventArgs<int> args)
        {
            var eventHandler = this.AgeChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnPeselChanged(EventArgs<String> args)
        {
            var eventHandler = this.PeselChanged;
            if (eventHandler != null)
                eventHandler.Invoke(peselBox, args);
        }

        protected virtual void OnNfzNumberChanged(EventArgs<int> args)
        {
            var eventHandler = this.NfzNumberChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnPriviligesChanged(EventArgs<bool> args)
        {
            var eventHandler = this.PriviligesChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnIlnessChanged(EventArgs<bool> args)
        {
            var eventHandler = this.IllnessChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnPrescriptionTextChanged(EventArgs<String> args)
        {
            var eventHandler = this.PrescriptionTextChanged;
            if (eventHandler != null)
                eventHandler.Invoke(this, args);
        }

        protected virtual void OnPrintStart()
        {
            var eventHandler = this.PrintStart;
            if (eventHandler != null)
                eventHandler.Invoke(this, null);
        }

        protected virtual void OnGetAvailablePrinters()
        {
            var eventHandler = this.GetAvailablePrinters;
            if (eventHandler != null)
                eventHandler.Invoke(printerList, null);
        }

        protected virtual void OnDoctorNameChanged(EventArgs<String> args)
        {
            var eventHandler = this.DoctorNameChanged;
            if (eventHandler != null)
                eventHandler.Invoke(doctorTextBox, args);
        }

        private void prescriptionNumberBox_Leave(object sender, EventArgs e)
        {
            MaskedTextBox temp = (MaskedTextBox)sender;
            OnPrescriptionNumberChanged(new EventArgs<String>(temp.Text));
        }

        private void patientNameBox_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            OnPatientNameChanged(new EventArgs<String>(temp.Text));
        }

        private void cityBox_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            OnCityChanged(new EventArgs<String>(temp.Text));
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            NumericUpDown temp = (NumericUpDown)sender;
            OnAgeChanged(new EventArgs<int>((int)temp.Value));
        }

        private void peselBox_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            OnPeselChanged(new EventArgs<String>(temp.Text));
        }

        private void nfzNumberBox_Leave(object sender, EventArgs e)
        {
            NumericUpDown temp = (NumericUpDown)sender;
            OnNfzNumberChanged(new EventArgs<int>((int)temp.Value));
        }

        private void priviligesCheckBox_Leave(object sender, EventArgs e)
        {
            CheckBox temp = (CheckBox)sender;
            OnPriviligesChanged(new EventArgs<bool>(temp.Checked));
        }

        private void illnessCheckBox_Leave(object sender, EventArgs e)
        {
            CheckBox temp = (CheckBox)sender;
            OnIlnessChanged(new EventArgs<bool>(temp.Checked));
        }

        private void prescriptionTextBox_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            OnPrescriptionTextChanged(new EventArgs<String>(temp.Text));
        }

        private void printStartButton_Click(object sender, EventArgs e)
        {
            OnPrintStart();
        }

        private void doctorTextBox_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            OnDoctorNameChanged(new EventArgs<String>(temp.Text));
        }
    }
}
