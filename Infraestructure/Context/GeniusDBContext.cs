using Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Context;

public class GeniusDBContext :DbContext
{
    public GeniusDBContext()
    {
        
    }
    
    public GeniusDBContext(DbContextOptions<GeniusDBContext> options) : base(options)
    {
    }
    
    public  DbSet<Service> Service { get; set; }
    public  DbSet<Mechanic> Mechanic { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql("Server=localhost,3306;Uid=root;Pwd=FamiliaYenQ01|;Database=GeniusDB;", serverVersion);
        }
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);

        builder.Entity<Mechanic>().ToTable("Mechanics");
        builder.Entity<Mechanic>().HasKey(p => p.Id);
        builder.Entity<Mechanic>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Mechanic>().Property(c => c.Name).IsRequired().HasMaxLength(20);
        builder.Entity<Mechanic>().Property(e => e.Email).HasMaxLength(30);
        builder.Entity<Mechanic>().Property(n => n.Phone).HasMaxLength(9);


        builder.Entity<Service>().ToTable("Services");
        builder.Entity<Service>().HasKey(p => p.Id);
        builder.Entity<Service>().Property(n => n.Name).HasMaxLength(25);
        builder.Entity<Service>().Property(a => a.Amount).HasPrecision(4, 2);
        builder.Entity<Service>().Property(d => d.Description).HasMaxLength(50);
        builder.Entity<Mechanic>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();


    }



}