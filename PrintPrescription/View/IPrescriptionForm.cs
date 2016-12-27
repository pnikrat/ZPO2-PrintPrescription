using PrintPrescription.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPrescription.View
{
    public interface IPrescriptionForm
    {
        void ClearPatientData();
        void SetError(object control, String text);
        void ClearError(object control);
        void PopulatePrinterList(String printer);

        event EventHandler<EventArgs<String>> PrescriptionNumberChanged;
        event EventHandler<EventArgs<String>> PatientNameChanged;
        event EventHandler<EventArgs<String>> CityChanged;
        event EventHandler<EventArgs<int>> AgeChanged;
        event EventHandler<EventArgs<String>> PeselChanged;
        event EventHandler<EventArgs<int>> NfzNumberChanged;
        event EventHandler<EventArgs<bool>> PriviligesChanged;
        event EventHandler<EventArgs<bool>> IllnessChanged;
        event EventHandler<EventArgs<String>> PrescriptionTextChanged;
        event EventHandler GetAvailablePrinters;
        
    }
}
