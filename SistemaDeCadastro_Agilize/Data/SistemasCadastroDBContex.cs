using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data.Map;

namespace SistemaDeCadastro_Agilize.Data
{
    public class SistemasCadastroDBContex : DbContext
    {
            public SistemasCadastroDBContex(DbContextOptions<SistemasCadastroDBContex> options) : base(options){ }
            public DbSet<Models.AssociateModel>? Associate { get; set; }
            public DbSet<Models.CommercialPartnerModel>? CommercialPartner { get; set; }
            public DbSet<Models.PositionModel>? Position { get; set; }
            public DbSet<Models.VehicleModel>? Vehicle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssociateMap());
            modelBuilder.ApplyConfiguration(new CommercialPartnerMap());
            modelBuilder.ApplyConfiguration(new PositionMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
