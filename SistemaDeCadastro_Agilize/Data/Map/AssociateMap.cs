using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class AssociateMap : IEntityTypeConfiguration<AssociateModel>
    {
        public void Configure(EntityTypeBuilder<AssociateModel> builder)
        {
            builder.HasKey(x => x.IdAssociate);
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
            builder.Property(x => x.ChnAssociate).IsRequired();
            builder.Property(x => x.ValidadeAssociate).IsRequired();
            builder.Property(x => x.CategoryAssociate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.FirstLicenseAssociate);
            builder.Property(x => x.NationalityAssociate).IsRequired().HasMaxLength(255);
        }
    }
}
