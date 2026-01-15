namespace ReportEngine.Domain.Entitites;

public class Booking : Entity
{
    public Guid RoomId { get; private set; }
    public DateOnly DateFrom { get; private set; }
    public DateOnly DateTo { get; private set; }
    
    private Booking() { }

    public Booking(Guid roomId, DateOnly from, DateOnly to)
    {
        if (from >= to)
        {
            throw new ArgumentException("Date from cannot be greater than date to.");
        }
        
        RoomId = roomId;
        DateFrom = from;
        DateTo = to;
    }
}