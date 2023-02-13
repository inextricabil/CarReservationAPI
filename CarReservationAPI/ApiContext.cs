using CarReservationAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CarReservationAPI;

public class ApiContext : DbContext
{
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "CarDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Reservation>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

}
