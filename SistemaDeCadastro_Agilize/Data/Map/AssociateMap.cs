using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class AssociateMap : IEntityTypeConfiguration<AssociateModel>
    {
        public void Configure(EntityTypeBuilder<AssociateModel> builder)
        {
            builder.HasKey(x => x.IdAssociate);
            builder.HasOne(x => x.Task).WithOne(x => x.Associate).HasForeignKey<AssociateModel>(x => x.IdTask);
            builder.Property(x => x.CpfResponsible).IsRequired();
            builder.Property(x => x.NamePerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TelPerson).IsRequired();
            builder.HasAlternateKey(x => x.EmailPerson);
            builder.HasAlternateKey(x => x.CpfPerson);
            builder.Property(x => x.SexoPerson).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RgPerson).IsRequired();
            builder.Property(x => x.DateBornPerson).IsRequired();
            builder.Property(x => x.NationalityPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.StreetPerson).IsRequired();
            builder.Property(x => x.CepPerson).IsRequired();
            builder.Property(x => x.NumberPerson).IsRequired();
            builder.Property(x => x.ComplementPerson).IsRequired();
            builder.Property(x => x.NeighborhoodPerson).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CityPerson).IsRequired();
            builder.Property(x => x.StatePerson).IsRequired();
            builder.Property(x => x.ChnAssociate).IsRequired();
            builder.Property(x => x.ValidadeCnh).IsRequired();
            builder.Property(x => x.CategoryCnh).IsRequired().HasMaxLength(10);
            builder.Property(x => x.FirstLicenseCnh);
            builder.Property(x => x.NationalityCnh).IsRequired().HasMaxLength(255);
        }
    }
}
