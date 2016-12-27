using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrescription.Model
{
    class PatientData
    {
        private String _prescriptionNumber;

        public String prescriptionNumber
        {
            get { return _prescriptionNumber; }
            set { _prescriptionNumber = value; }
        }

        private String _patientName;

        public String patientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }

        private String _city;

        public String city
        {
            get { return _city; }
            set { _city = value; }
        }

        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private String _pesel;

        public String pesel
        {
            get { return _pesel; }
            set { _pesel = value; }
        }

        private int _nfzNumber;

        public int nfzNumber
        {
            get { return _nfzNumber; }
            set { _nfzNumber = value; }
        }

        private bool _priviliges;

        public bool priviliges
        {
            get { return _priviliges; }
            set { _priviliges = value; }
        }

        private bool _illness;

        public bool illness
        {
            get { return _illness; }
            set { _illness = value; }
        }

        private String _prescriptionText;

        public String prescriptionText
        {
            get { return _prescriptionText; }
            set { _prescriptionText = value; }
        }

        public PatientData()
        {
            prescriptionNumber = "0000000000000000000000";
            patientName = "";
            city = "";
            age = 1;
            pesel = "";
            nfzNumber = 1;
            priviliges = false;
            illness = false;
            prescriptionText = "";
        }

        public bool PatientDataNotFilled()
        {
            return String.IsNullOrEmpty(patientName) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(pesel);
        }
    }
}
