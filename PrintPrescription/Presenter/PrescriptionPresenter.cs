using PrintPrescription.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void PrescriptionNumberChanged(object sender, EventArgs<String> args)
        {
            _form.SetPatientAgeTest(args.value);
        }
    }
}
