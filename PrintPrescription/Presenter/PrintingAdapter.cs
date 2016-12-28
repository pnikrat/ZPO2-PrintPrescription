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
            document.OriginAtMargins = true;
            document.PrinterSettings.PrinterName = _usedPrinter;
            document.PrintPage += new PrintPageEventHandler(ev_PrintPage);
            printPreview.Document = document;
            printPreview.ShowDialog();
           // document.Print();
        }

        private void ev_PrintPage(object sender, PrintPageEventArgs args)
        {
            Graphics g = args.Graphics;
            Font fontMain = new Font("Arial", 10, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 8);
            Font fontPatientData = new Font("Arial", 9);
            Font fontNfz = new Font("Arial", 11);
            Font fontX = new Font("Arial", 18, FontStyle.Bold);
            Font fontFooter = new Font("Arial", 7);
            SolidBrush brush = new SolidBrush(Color.Black);

            Pen penRegular = new Pen(brush, 2);

            g.DrawString("Recepta", fontMain, brush, 0, 0);
            g.DrawString("Świadczeniodawca", fontRegular, brush, 0, 100);
            //linia górna
            g.DrawLine(penRegular, 0, 120, 300, 120);
            g.DrawString("Pacjent", fontRegular, brush, 0, 130);
            g.DrawString(_dataToPrint.patientName, fontPatientData, brush, 0, 145);
            g.DrawString(_dataToPrint.city.ToUpper(), fontPatientData, brush, 0, 190);
            g.DrawString("wiek - " + _dataToPrint.age + " lat", fontPatientData, brush, 0, 205);
            g.DrawString("PESEL " + _dataToPrint.pesel, fontPatientData, brush, 0, 250);
            //linia dolna
            g.DrawLine(penRegular, 0, 270, 300, 270);
            //linia pionowa
            g.DrawLine(penRegular, 200, 120, 200, 270);
            //środkowe linie
            g.DrawLine(penRegular, 200, 170, 300, 170);
            g.DrawLine(penRegular, 200, 220, 300, 220);

            g.DrawString("Oddział NFZ", fontRegular, brush, 215, 155);
            g.DrawString("Uprawnienia", fontRegular, brush, 215, 205);
            g.DrawString("Ch. przewlekłe", fontRegular, brush, 210, 255);

            g.DrawString(_dataToPrint.nfzNumber.ToString(), fontNfz, brush, 230, 135);
            if (_dataToPrint.priviliges)
                g.DrawString("X", fontX, brush, 230, 175);
            if (_dataToPrint.illness)
                g.DrawString("X", fontX, brush, 230, 225);

            g.DrawString("Rp.", fontRegular, brush, 0, 290);
            g.DrawString(_dataToPrint.prescriptionText, fontPatientData, brush, 20, 310);

            //barcode!!

            g.DrawLine(penRegular, 0, 650, 300, 650);
            g.DrawString("Data wystawienia", fontFooter, brush, 20, 660);
            g.DrawString("Dane id. i podpis lekarza", fontFooter, brush, 170, 660);
            g.DrawString(DateTime.Now.ToShortDateString(), fontPatientData, brush, 0, 675);
            g.DrawString("Imie i nazwisko lekarza", fontPatientData, brush, 150, 675);

            g.DrawLine(penRegular, 0, 700, 120, 700);
            g.DrawLine(penRegular, 0, 750, 120, 750);
            //dolna linia stopki
            g.DrawLine(penRegular, 0, 820, 300, 820);

            g.DrawString("Data realizacji od dnia", fontFooter, brush, 20, 710);
            g.DrawString("X", fontX, brush, 0, 720);

            g.DrawString("Dane podmiotu drukującego", fontFooter, brush, 170, 805);
            g.DrawString("Wydruk własny", fontFooter, brush, 190, 825);
        }
    }
}
