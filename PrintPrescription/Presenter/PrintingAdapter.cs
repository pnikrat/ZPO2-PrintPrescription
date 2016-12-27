using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using PrintPrescription.Model;
using System.Drawing;
using System.Windows.Forms;

namespace PrintPrescription.Presenter
{
    class PrintingAdapter
    {
        private PatientData _dataToPrint;
        private String _usedPrinter;
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public PrintingAdapter(PatientData dataToPrint, String usedPrinter)
        {
            _dataToPrint = dataToPrint;
            _usedPrinter = usedPrinter;
        }

        public void Printing()
        {
            PrintDocument document = new PrintDocument();
            document.PrinterSettings.PrinterName = _usedPrinter;
            document.PrintPage += new PrintPageEventHandler(ev_PrintPage);
            printPreview.Document = document;
            printPreview.ShowDialog();
           // document.Print();
        }

        private void ev_PrintPage(object sender, PrintPageEventArgs args)
        {
            Graphics g = args.Graphics;
            Font font = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(_dataToPrint.prescriptionNumber, font, brush, new Point(2, 3));
        }

    }
}
