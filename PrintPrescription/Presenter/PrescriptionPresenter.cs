using PrintPrescription.View;
using PrintPrescription.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace PrintPrescription.Presenter
{
    class PrescriptionPresenter
    {
        private readonly IPrescriptionForm _form;
        private PatientData currentPatient;
        
        public PrescriptionPresenter(IPrescriptionForm PrescriptionForm)
        {
            _form = PrescriptionForm;
            currentPatient = new PatientData();
            SubscribeToFormEvents();
        } 

        private void SubscribeToFormEvents()
        {
            _form.PrescriptionNumberChanged += this.PrescriptionNumberChanged;
            _form.PatientNameChanged += this.PatientNameChanged;
            _form.CityChanged += this.CityChanged;
            _form.AgeChanged += this.AgeChanged;
            _form.PeselChanged += this.PeselChanged;
            _form.NfzNumberChanged += this.NfzNumberChanged;
            _form.PriviligesChanged += this.PriviligesChanged;
            _form.IllnessChanged += this.IllnessChanged;
            _form.PrescriptionTextChanged += this.PrescriptionTextChanged;
            _form.GetAvailablePrinters += this.GetAvailablePrinters;
            
        }

        private void PrescriptionNumberChanged(object sender, EventArgs<String> args)
        {
            currentPatient.prescriptionNumber = args.value;
        }

        private void PatientNameChanged(object sender, EventArgs<String> args)
        {
            if (args.value.All(c => Char.IsLetter(c) || c == ' ') && !String.IsNullOrEmpty(args.value))
            {
                _form.ClearError(sender);
                currentPatient.patientName = args.value;
            }
            else
            {
                _form.SetError(sender, "Imię i nazwisko nie może być puste i może zawierać tylko litery");
            }
        }

        private void CityChanged(object sender, EventArgs<String> args)
        {
            if (args.value.All(c => Char.IsLetter(c) || c == ' ') && !String.IsNullOrEmpty(args.value))
            {
                _form.ClearError(sender);
                currentPatient.city = args.value;
            }
            else
            {
                _form.SetError(sender, "Miejscowość nie może być pusta i może zawierać tylko litery");
            }
        }

        private void AgeChanged(object sender, EventArgs<int> args)
        {
            currentPatient.age = args.value;
        }

        private void PeselChanged(object sender, EventArgs<String> args)
        {
            //validate PESEL!!
            currentPatient.pesel = args.value;
        }

        private void NfzNumberChanged(object sender, EventArgs<int> args)
        {
            currentPatient.nfzNumber = args.value;
        }

        private void PriviligesChanged(object sender, EventArgs<bool> args)
        {
            currentPatient.priviliges = args.value;
        }

        private void IllnessChanged(object sender, EventArgs<bool> args)
        {
            currentPatient.illness = args.value;
        }

        private void PrescriptionTextChanged(object sender, EventArgs<String> args)
        {
            currentPatient.prescriptionText = args.value;
        }

        private void GetAvailablePrinters(object sender, EventArgs args)
        {
            //if no printers give error in error label
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                _form.PopulatePrinterList(printer);
            }
        }
    }
}
