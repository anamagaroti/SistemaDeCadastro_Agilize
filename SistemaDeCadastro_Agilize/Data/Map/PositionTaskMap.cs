

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class PositionTaskMap : IEntityTypeConfiguration<PositionTaskModel>
    {
        public void Configure(EntityTypeBuilder<PositionTaskModel> builder)
        {
            builder.HasKey(x => new {x.IdPosition, x.IdTask});
            builder.HasOne(x => x.Position).WithMany(x => x.PositionTask).HasForeignKey(x => x.IdPosition);
            builder.HasOne(x => x.Task).WithMany(x => x.PositionTask).HasForeignKey(x => x.IdTask);
        }
    }
}
