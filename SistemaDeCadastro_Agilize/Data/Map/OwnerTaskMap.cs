using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class OwnerTaskMap : IEntityTypeConfiguration<OwnerTaskModel>
    {
        public void Configure(EntityTypeBuilder<OwnerTaskModel> builder)
        {
            builder.HasKey(x => new {x.IdOwner, x.IdTask});
            builder.HasOne(x => x.Owner).WithMany(x => x.OwnerTasks).HasForeignKey(x => x.IdOwner);
            builder.HasOne(x => x.Task).WithMany(x => x.OwnerTasks).HasForeignKey(x => x.IdTask);
        }
    }
}
