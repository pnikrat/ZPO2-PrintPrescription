using PrintPrescription.View;
using PrintPrescription.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrintPrescription.Presenter
{
    class PrescriptionPresenter
    {
        private readonly IPrescriptionForm _form;
        private PatientData currentPatient;
        private Dictionary<string, bool> ErrorDict;
        
        public PrescriptionPresenter(IPrescriptionForm PrescriptionForm)
        {
            _form = PrescriptionForm;
            currentPatient = new PatientData();
            SubscribeToFormEvents();
            SetupErrorDict();
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
            _form.DoctorNameChanged += this.DoctorNameChanged;
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

        private void SetupErrorDict()
        {
            ErrorDict = new Dictionary<string, bool>();
            string[] keys = { "PrescriptionNumber", "PatientName", "City", "Pesel" };
            ErrorDict.Add("Doctor", false);
            foreach (string x in keys)
            {
                ErrorDict.Add(x, true);
            }
        }

        private bool CheckForErrors()
        {
            if (ErrorDict.Values.Any(v => v == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PrescriptionNumberChanged(object sender, EventArgs<String> args)
        {
            if (args.value.Any(c => c != '0'))
            {
                _form.ClearError(sender);
                ErrorDict["PrescriptionNumber"] = false;
                currentPatient.prescriptionNumber = args.value;
            }
            else
            {
                _form.SetError(sender, "Numer recepty nie może zawierać samych zer");
                ErrorDict["PrescriptionNumber"] = true;
            }
        }

        private void PatientNameChanged(object sender, EventArgs<String> args)
        {
            if (args.value.All(c => Char.IsLetter(c) || c == ' ') && !String.IsNullOrEmpty(args.value))
            {
                _form.ClearError(sender);
                ErrorDict["PatientName"] = false;
                currentPatient.patientName = args.value;
            }
            else
            {
                _form.SetError(sender, "Imię i nazwisko nie może być puste i może zawierać tylko litery");
                ErrorDict["PatientName"] = true;
            }
        }

        private void CityChanged(object sender, EventArgs<String> args)
        {
            if (args.value.All(c => Char.IsLetter(c) || c == ' ') && !String.IsNullOrEmpty(args.value))
            {
                _form.ClearError(sender);
                ErrorDict["City"] = false;
                currentPatient.city = args.value;
            }
            else
            {
                _form.SetError(sender, "Miejscowość nie może być pusta i może zawierać tylko litery");
                ErrorDict["City"] = true;
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
                    ErrorDict["Pesel"] = false;
                    currentPatient.pesel = args.value;
                    return;
                }
            }
            _form.SetError(sender, "PESEL nie istnieje lub nie zawiera 11 cyfr");
            ErrorDict["Pesel"] = true;
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
            if (!CheckForErrors() && !String.IsNullOrEmpty((String)_form.GetChosenPrinter()))
            {
                _form.SetErrorLabel("Drukowanie rozpoczęte");

                PrintingAdapter adapter = new PrintingAdapter(currentPatient, (String)_form.GetChosenPrinter(),
                    _form.GetDoctorName());
                adapter.Printing();
                if (adapter.GetPrintingFinished())
                {
                    _form.ClearPatientData();
                    SetupErrorDict();
                    currentPatient = new PatientData();
                }
                else
                    _form.SetErrorLabel("");         
            }
            else
            {
                _form.SetErrorLabel("Nie można drukować - brak danych pacjenta lub brak wybranej drukarki");
            }
        }

        private void GetAvailablePrinters(object sender, EventArgs args)
        {
            if (PrinterSettings.InstalledPrinters.Count == 0)
            {
                MessageBox.Show("Brak drukarek w systemie. Zainstaluj drukarkę i uruchom ponownie program", "Błąd");
                return;
            }
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                _form.PopulatePrinterList(printer);
            }
        }

        private void DoctorNameChanged(object sender, EventArgs<String> args)
        {
            if (args.value.All(c => Char.IsLetter(c) || c == ' ') && !String.IsNullOrEmpty(args.value))
            {
                _form.ClearError(sender);
                ErrorDict["Doctor"] = false;
            }
            else
            {
                _form.SetError(sender, "Imię i nazwisko lekarza nie może być puste i może zawierać tylko litery");
                ErrorDict["Doctor"] = true;
            }
        }
    }
}
