using PrintPrescription.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrescription.View
{
    public interface IPrescriptionForm
    {
        void ClearPatientData();
        void PopulatePrinterList(String printer);

        event EventHandler<EventArgs<String>> PrescriptionNumberChanged;
        event EventHandler GetAvailablePrinters;
        
    }
}
