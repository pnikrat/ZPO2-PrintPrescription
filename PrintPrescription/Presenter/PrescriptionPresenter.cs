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
            InitiateMockPatientData();
        }

        private void InitiateMockPatientData()
        {
            currentPatient.prescriptionNumber = "1234567891234567891234";
            currentPatient.patientName = "Bartłomiej Prędki";
            currentPatient.city = "Poznań";
            currentPatient.age = 45;
            currentPatient.pesel = "93072313653";
            currentPatient.nfzNumber = 15;
            currentPatient.priviliges = true;
            currentPatient.illness = false;
            currentPatient.prescriptionText = "Vigantol krople doustne 20 000 j.m / ml (0,5mg)\n"
                + "l.g. 2a\n"
                + "DS1x1\n\n"
                + "Cebion - krople 0,1 g/ml\n"
                + "lg. jedno opakowanie a\n"
                + "DS2x1";

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
            _form.PrintStart += this.PrintStart;
            _form.GetAvailablePrinters += this.GetAvailablePrinters;
        }

        private bool ValidatePeselControlSum(String Pesel)
        {
            int[] wages = { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += wages[i] * (Pesel[i]-48);
            }
            int remainder = sum % 10;
            if (remainder == (Pesel[10] - 48))
                return true;
            else
                return false;
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
            if (args.value.All(c => Char.IsDigit(c)) && args.value.Length == 11)
            {
                if (ValidatePeselControlSum(args.value))
                {
                    _form.ClearError(sender);
                    currentPatient.pesel = args.value;
                    return;
                }
            }
            _form.SetError(sender, "PESEL nie istnieje lub nie zawiera 11 cyfr");
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

        private void PrintStart(object sender, EventArgs args)
        {
            if (_form.GetErrorCount() == 0 && !String.IsNullOrEmpty((String)_form.GetChosenPrinter())
                && !currentPatient.PatientDataNotFilled())
            {
                _form.SetErrorLabel("Printing successful, can start");

                PrintingAdapter adapter = new PrintingAdapter(currentPatient, (String)_form.GetChosenPrinter());
                adapter.Printing();

                _form.ClearPatientData();
                currentPatient = new PatientData();                
            }
            else
            {
                _form.SetErrorLabel("Nie można drukować - brak danych pacjenta lub brak wybranej drukarki");
            }
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
