using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class PositionMap : IEntityTypeConfiguration<PositionModel>
    {
        public void Configure(EntityTypeBuilder<PositionModel> builder)
        {
            builder.HasKey(x => x.IdPosition);
            builder.HasMany(x => x.Partners).WithOne(x => x.Position).HasForeignKey(x => x.IdCP);
            builder.Property(X => X.NamePosition);

        }
    }
}
