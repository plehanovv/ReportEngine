using Microsoft.AspNetCore.Components.Endpoints;

namespace ReportEngine.Domain.Entitites;

public class Hotel : Entity
{
    public string Name { get; private set; }
    
    private readonly List<Room> _rooms = new();
    public IReadOnlyCollection<Room> Rooms => _rooms;
    
    private Hotel() { }

    public Hotel(string name)
    {
        Name = name;
    }

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }
}