using Hellthcare.Entities;

namespace Hellthcare.Application;

public class DbContext
{
    public IEnumerable<Patient> GetPatients()
    {
        return [];
    }
    
    public IEnumerable<Doctor> GetDoctors()
    {
        return [];
    }

    public void Save(Appointment appointment)
    {
        
    }

    public void Save(Patient patient)
    {
    }
}