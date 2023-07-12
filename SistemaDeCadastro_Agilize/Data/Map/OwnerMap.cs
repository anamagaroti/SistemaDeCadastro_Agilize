using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class OwnerMap : IEntityTypeConfiguration<OwnerModel>
    {
        public void Configure(EntityTypeBuilder<OwnerModel> builder)
        {
            builder.HasKey(x => x.IdOwner);
            builder.Property(x => x.NamePerson).IsRequired();
            builder.Property(x => x.TelPerson).IsRequired();
            builder.Property(x => x.EmailPerson).IsRequired();
            builder.Property(x => x.CpfPerson).IsRequired();
            builder.Property(x => x.SexoPerson).IsRequired();
            builder.Property(x => x.RgPerson).IsRequired();
            builder.Property(x => x.DateBornPerson).IsRequired();
            builder.Property(x => x.NationalityPerson).IsRequired();
            builder.Property(x => x.StreetPerson).IsRequired();
            builder.Property(x => x.CepPerson).IsRequired();
            builder.Property(x => x.NumberPerson).IsRequired();
            builder.Property(x => x.ComplementPerson).IsRequired();
            builder.Property(x => x.NeighborhoodPerson).IsRequired();
            builder.Property(x => x.CityPerson).IsRequired();
            builder.Property(x => x.StatePerson).IsRequired();
            builder.Property(x => x.PasswordOwner).IsRequired();
        }
    }
}
