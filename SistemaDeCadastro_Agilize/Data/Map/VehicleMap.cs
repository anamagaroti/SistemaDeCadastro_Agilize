using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class VehicleMap : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.HasKey(x => x.IdVehicle);
            builder.HasAlternateKey(x => x.IdAssociate);
            builder.Property(x => x.Brand).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Version).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Fuel).IsRequired().HasMaxLength(64);
            builder.Property(x => x.NF).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Plate).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Model).IsRequired().HasMaxLength(64);
            builder.Property(x => x.NumberDoors).IsRequired();
            builder.Property(x => x.Color).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Renavam).IsRequired();
            builder.Property(x => x.Chassi).IsRequired().HasMaxLength(64);
            builder.Property(x => x.FipeCode).IsRequired();
            builder.Property(x => x.FipeValue).IsRequired();
            builder.Property(x => x.VehicleNationality).IsRequired().HasMaxLength(64);
        }
    }
}
