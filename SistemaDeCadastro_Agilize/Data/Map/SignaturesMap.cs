using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Data.Map
{
    public class SignaturesMap : IEntityTypeConfiguration<SignaturesModel>
    {
        public void Configure(EntityTypeBuilder<SignaturesModel> builder)
        {
            builder.HasKey(x => new {x.IdOwner, x.IdAssociate});
            builder.HasOne(x => x.Owner).WithMany(x => x.Signatures).HasForeignKey(x => x.IdOwner);
            builder.HasOne(x => x.Associate).WithMany(x => x.Signatures).HasForeignKey(x => x.IdAssociate);
            builder.Property(x => x.NameImageSignatures).IsRequired();
            builder.Property(x => x.DateImageSignature).IsRequired().HasColumnName("date");

        }
    }
}
