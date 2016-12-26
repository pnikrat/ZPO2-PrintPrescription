using PrintPrescription.Presenter;
using PrintPrescription.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPrescription
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrescriptionForm view = new PrescriptionForm();
            PrescriptionPresenter presenter = new PrescriptionPresenter(view);
            view.InitializeForm();
            Application.Run(view);
        }
    }
}
