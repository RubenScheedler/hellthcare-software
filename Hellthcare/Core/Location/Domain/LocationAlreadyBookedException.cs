namespace Hellthcare.Core.Location.Domain;

public class LocationAlreadyBookedException(string message) : Exception(message);