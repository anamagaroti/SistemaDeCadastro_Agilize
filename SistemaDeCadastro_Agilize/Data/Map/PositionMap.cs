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
            builder.HasAlternateKey(x => x.IdTask);
            builder.Property(X => X.NamePosition);

        }
    }
}
