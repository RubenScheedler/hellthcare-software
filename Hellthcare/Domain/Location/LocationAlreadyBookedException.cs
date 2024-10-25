namespace Hellthcare.Domain.Location;

public class LocationAlreadyBookedException(string message) : Exception(message);