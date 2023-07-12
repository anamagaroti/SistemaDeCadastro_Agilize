using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data.Map;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Data
{
    public class SistemasCadastroDBContex : DbContext
    {
            public SistemasCadastroDBContex(DbContextOptions<SistemasCadastroDBContex> options) : base(options){ }
            public DbSet<AssociateModel>? Associate { get; set; }
            public DbSet<Models.CommercialPartnerModel>? CP{ get; set; }
            public DbSet<Models.OwnerModel>? Owner { get; set; }
            public DbSet<Models.PositionModel>? Position { get; set; }
            public DbSet<RegisterVehicleModel>? Vehicle { get; set; }
            public DbSet<TaskModel> Task { get; set; }
            public DbSet<PositionTaskModel> PositionAndTask { get; set; }
            public DbSet<OwnerTaskModel> OwnerAndTasks { get; set; }
            public DbSet<ImagesVehicleModel> ImagesVehicles { get; set; }
            public DbSet<SignaturesModel> Signatures { get; set; }
            public DbSet<DadosVehicleModel> Dados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssociateMap());
            modelBuilder.ApplyConfiguration(new CommercialPartnerMap());
            modelBuilder.ApplyConfiguration(new OwnerMap());
            modelBuilder.ApplyConfiguration(new PositionMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            modelBuilder.ApplyConfiguration(new PositionTaskMap());
            modelBuilder.ApplyConfiguration(new OwnerTaskMap());
            modelBuilder.ApplyConfiguration(new ImagesVehicleMap());
            modelBuilder.ApplyConfiguration(new SignaturesMap());
            modelBuilder.ApplyConfiguration(new DadosVehicleMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
