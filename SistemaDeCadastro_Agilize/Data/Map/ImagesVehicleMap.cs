using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class ImagesVehicleMap : IEntityTypeConfiguration<ImagesVehicleModel>
    {
        public void Configure(EntityTypeBuilder<ImagesVehicleModel> builder)
        {
            builder.HasKey(x => x.IdImageVehicle);
            builder.HasOne(x => x.Vehicle).WithMany(x => x.Images).HasForeignKey(x => x.IdAssociate);
            builder.Property(x => x.NameImageVehicle).IsRequired();
            builder.Property(x => x.DateImageVehicle).IsRequired().HasColumnType("date");
        }
    }
}
