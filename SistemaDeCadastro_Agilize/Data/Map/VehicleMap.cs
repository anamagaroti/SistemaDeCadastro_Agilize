using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class VehicleMap : IEntityTypeConfiguration<RegisterVehicleModel>
    {
        public void Configure(EntityTypeBuilder<RegisterVehicleModel> builder)
        {
            builder.HasKey(x => x.IdVehicle);
            builder.HasOne(x => x.Task).WithOne(x => x.Vehicle).HasForeignKey<RegisterVehicleModel>(x => x.IdTask);
            builder.Property(x => x.TypeVehicle).IsRequired();
            builder.Property(x => x.Brand).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Version).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Fuel).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Model).IsRequired().HasMaxLength(64);
            builder.Property(x => x.NumberDoors).IsRequired();
            builder.Property(x => x.FipeCode).IsRequired();
            builder.Property(x => x.FipeValue).IsRequired();
            builder.Property(x => x.VehicleNationality).IsRequired().HasMaxLength(64);
        }
    }
}
