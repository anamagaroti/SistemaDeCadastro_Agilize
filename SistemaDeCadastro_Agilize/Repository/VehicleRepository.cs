using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models.Tasks;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly SistemasCadastroDBContex _dbContext;

        public VehicleRepository(SistemasCadastroDBContex sistemasCadastroDBContex)
        {
            _dbContext = sistemasCadastroDBContex;
        }

        public async Task<bool> DeleteVehicle(long IdVehicle)
        {
            RegisterVehicleModel vehicle = await FitchVehicle(IdVehicle);
            
            if(vehicle == null)
            {
                throw new Exception("não foi possível excluir esse veículo");
            }

            _dbContext.Vehicle.Remove(vehicle);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<RegisterVehicleModel> FitchVehicle(long IdVehicle)
        {
            return await _dbContext.Vehicle.FirstOrDefaultAsync(x => x.IdVehicle == IdVehicle);
        }

        public async Task<List<RegisterVehicleModel>> ListVehicle()
        {
            return await _dbContext.Vehicle.ToListAsync();
        }

        public async Task<RegisterVehicleModel> RegisterVehicle(RegisterVehicleModel vehicle)
        {
            await _dbContext.Vehicle.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();

            return vehicle;
        }

        public async Task<RegisterVehicleModel> UpdateVehicle(RegisterVehicleModel vehicle, long IdVehicle)
        {
            RegisterVehicleModel vehicleModel = await FitchVehicle(IdVehicle);
            
            if( vehicleModel == null)
            {
                throw new Exception("Não foi possível editar esse veículo");
            }

            _dbContext.Vehicle.Update(vehicleModel);
            await _dbContext.SaveChangesAsync();

            return vehicleModel;
        }
    }
}
