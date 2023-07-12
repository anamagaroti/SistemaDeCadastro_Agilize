using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class DadosVehicleMap : IEntityTypeConfiguration<DadosVehicleModel>
    {
        public void Configure(EntityTypeBuilder<DadosVehicleModel> builder)
        {
            builder.HasKey(x => new { x.IdAssociate, x.IdRegisterVehicle, x.Placa});
            builder.HasOne(x => x.AssociateModel).WithMany(x => x.Vehicles).HasForeignKey(x => x.IdAssociate);
            builder.HasOne(x => x.RegisterVehicle).WithMany(x => x.DadosVehicles).HasForeignKey(x => x.IdRegisterVehicle);
            builder.HasOne(x => x.TaskModel).WithOne(x => x.DadosVehicle).HasForeignKey<DadosVehicleModel>(x => x.IdTask);
            builder.Property(x => x.CpfResponsible);
            builder.Property(x => x.NF);
            builder.HasAlternateKey(x => x.Placa);
            builder.HasIndex(x => x.Renavam).IsUnique();
            builder.Property(x => x.Renavam).IsRequired();
            builder.HasIndex(x => x.Chassi).IsUnique();
            builder.Property(x => x.Chassi).IsRequired();
            builder.Property(x => x.Color).IsRequired();



        }
    }
}
