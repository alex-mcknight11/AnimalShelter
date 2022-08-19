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
        
      );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}