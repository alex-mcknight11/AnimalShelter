using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }
    protected override async void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Type = "Dog", Name = "Dingo", Gender = "Male", Breed = "Jindo", AdmissionDate = new DateTime(2022, 08, 26)},
        new Animal { AnimalId = 1, Type = "Dog", Name = "Beau", Gender = "Male", Breed = "AussieDoodle", AdmissionDate = new DateTime(2022, 08, 26) }
      );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}