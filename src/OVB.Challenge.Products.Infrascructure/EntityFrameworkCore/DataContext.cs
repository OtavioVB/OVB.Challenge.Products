using Microsoft.EntityFrameworkCore;
using OVB.Challenge.Products.Domain.CustomerContext.DataTransferObject;
using OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Mappings;

namespace OVB.Challenge.Products.Infrascructure.EntityFrameworkCore;

public sealed class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerMapping());
        base.OnModelCreating(modelBuilder);
    }

}
