using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportEngine.Domain.Entitites;

namespace ReportEngine.Infrastructure.Persistence.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("bookings");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.DateFrom).IsRequired();
        
        builder.Property(x => x.DateTo).IsRequired();
        
        builder.HasIndex(x => new { x.RoomId, x.DateFrom, x.DateTo });
    }
}