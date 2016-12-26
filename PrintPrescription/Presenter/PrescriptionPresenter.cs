using PrintPrescription.View;
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
        
        public PrescriptionPresenter(IPrescriptionForm PrescriptionForm)
        {
            _form = PrescriptionForm;
            SubscribeToFormEvents();
        } 

        private void SubscribeToFormEvents()
        {
            _form.PrescriptionNumberChanged += this.PrescriptionNumberChanged;
            _form.GetAvailablePrinters += this.GetAvailablePrinters;
        }

        private void PrescriptionNumberChanged(object sender, EventArgs<String> args)
        {
            
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
