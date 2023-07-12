using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class CommercialPartnerMap : IEntityTypeConfiguration<CommercialPartnerModel>
    {
        public void Configure(EntityTypeBuilder<CommercialPartnerModel> builder)
        {
            builder.HasKey(x => x.IdCP);
            builder.HasOne(x => x.Position).WithMany(x => x.Partners).HasForeignKey(x => x.IdCP);
            builder.Property(x => x.NamePerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelPerson).IsRequired();
            builder.HasAlternateKey(x => x.EmailPerson);
            builder.HasAlternateKey(x => x.CpfPerson);
            builder.Property(x => x.SexoPerson).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RgPerson);
            builder.Property(x => x.DateBornPerson).IsRequired();
            builder.Property(x => x.NationalityPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.StreetPerson).HasMaxLength(255);
            builder.Property(x => x.CepPerson).IsRequired();
            builder.Property(x => x.NumberPerson);
            builder.Property(x => x.ComplementPerson).HasMaxLength(255);
            builder.Property(x => x.NeighborhoodPerson).HasMaxLength(255);
            builder.Property(x => x.CityPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.StatePerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(255);
        }
    }
}
