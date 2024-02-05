using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public class MedicineCommand : ICommand
    {
        private readonly Patient _patient;
        private readonly Nurse _nurse;
        private  Prescription _prescription;
        private  Prescription _previousPrescription;

        public MedicineCommand(Patient patient, Nurse nurse, Prescription prescription)
        {
            _patient = patient;
            _nurse = nurse;
            _prescription = prescription;
            _previousPrescription = patient.prescription;
        }

        public void Execute()
        {
            _previousPrescription = _patient.prescription;
            _patient.prescription = _prescription;
            if (_prescription == Prescription.MEDICINE)
            {
                _nurse.ProvideMedicine("Антибиотики");
            }
        }

        public void Undo()
        {
            _patient.prescription = _previousPrescription;
        }
    }
}
