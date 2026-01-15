namespace ReportEngine.Domain.Entitites;

public class Room : Entity
{
    public Guid HotelId { get; private set; }
    public string Number { get; private set; }
    public int Capacity { get; private set; }
    
    private Room() { }

    public Room(Guid hotelId, string number, int capacity)
    {
        HotelId = hotelId;
        Number = number;
        Capacity = capacity;
    }
    
}