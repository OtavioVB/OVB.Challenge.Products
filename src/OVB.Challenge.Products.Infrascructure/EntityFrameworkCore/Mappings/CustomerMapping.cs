using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OVB.Challenge.Products.Domain.CustomerContext.DataTransferObject;

namespace OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Mappings;

public sealed class CustomerMapping : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        #region Table Configuration

        builder.ToTable("customers");

        #endregion

        #region Primary Key Configuration

        builder.HasKey(p => p.Id)
            .HasName("pk_customer_id");

        #endregion

        #region Index Key Configuration



        #endregion

        #region Properties Configuration

        builder.Property(p => p.Id)
            .IsRequired(true)
            .IsFixedLength(true)
            .HasMaxLength(36)
            .HasColumnName("id_customer")
            .HasColumnType("UUID")
            .ValueGeneratedNever();

        builder.Property(p => p.Name)
            .IsRequired(true)
            .IsFixedLength(true)
            .HasMaxLength(32)
            .HasColumnName("name")
            .HasColumnType("VARCHAR")
            .ValueGeneratedNever();
        builder.Property(p => p.Surname)
            .IsRequired(true)
            .IsFixedLength(true)
            .HasMaxLength(32)
            .HasColumnName("surname")
            .HasColumnType("VARCHAR")
            .ValueGeneratedNever();
        builder.Property(p => p.BirthDate)
            .IsRequired(true)
            .IsFixedLength(true)
            .HasColumnName("birth_date")
            .HasColumnType("DATE")
            .ValueGeneratedNever();

        #endregion
    }
}
