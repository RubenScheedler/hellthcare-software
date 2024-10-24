
using Hellthcare.Domain.Appointments;

namespace Hellthcare.Domain;

public class Patient {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Address { get; set; }
    public List<string> Notes { get; }
    public List<Appointment> Appointments { get; }

    public Patient(Guid id, string name, string phoneNumber, string address) {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
        Notes = [];
        Appointments = [];
    }

    /// <summary>
    /// Goes over the appointments of the patients and finds the ones that overlap with the 
    /// interval passed to this method.
    /// </summary>
    /// <param name="from">Lower bound of the interval</param>
    /// <param name="to">Upper bound</param>
    /// <returns></returns>
    public List<Appointment> GetOverlappingPlanningItems(DateTimeOffset lowerBound, DateTimeOffset upperBound) { // BAD: bad generic name, not about domain concept
        // Left as an exercise to the reader ;-)
        return [];
    }
}