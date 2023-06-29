using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class CommercialPartnerMap : IEntityTypeConfiguration<CommercialPartnerModel>
    {
        public void Configure(EntityTypeBuilder<CommercialPartnerModel> builder)
        {
            builder.HasKey(x => x.IdCommercialPartner);
            builder.HasAlternateKey(x => x.IdPosition);
            builder.Property(x => x.NamePerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelPerson).IsRequired();
            builder.Property(x => x.EmailPerson).HasMaxLength(255);
            builder.Property(x => x.CpfPerson).IsRequired();
            builder.Property(x => x.SexoPerson).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RgPerson).IsRequired();
            builder.Property(x => x.DateBornPerson).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NeighborhoodPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NumberPerson).IsRequired();
            builder.Property(x => x.UFPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CepPerson).IsRequired();
            builder.Property(x => x.Password).IsRequired().HasMaxLength(255);
        }
    }
}
