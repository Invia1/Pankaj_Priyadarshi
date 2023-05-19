using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.IhospitalServices
{
    public interface ihospitalservices
    {
        void add(PatientDetails patient);
        List<PatientDetails> getPatient();
        PatientDetails getById(int id);
        void Update(PatientDetails updatedPatient);
        void Delete(int id);
    }
}
