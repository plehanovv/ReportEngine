using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportEngine.Domain.Entitites;

namespace ReportEngine.Infrastructure.Persistence.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable("rooms");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Number).IsRequired().HasMaxLength(20);
        
        builder.Property(x => x.Capacity).IsRequired();
        
        builder.HasIndex(x => new { x.HotelId, x.Number }).IsUnique();
    }
}