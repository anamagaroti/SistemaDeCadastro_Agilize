using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
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
        /*esta funcionando porem, tem que devolver o corpo do associado*/
        public async Task<VehicleModel> BuscarPorPlacaVehicle(string Plate, long IdAssociate)
        {
            return await _dbContext.Vehicle.FirstOrDefaultAsync
                (x => x.Plate == Plate & x.IdAssociate == IdAssociate);
        }
        public async Task<List<VehicleModel>> BuscarTodosVeiculos()
        {
            return await _dbContext.Vehicle.ToListAsync();
        }
        public async Task<VehicleModel> BuscarVehiclePorId(long IdVehicle)
        {
            return await _dbContext.Vehicle.FirstOrDefaultAsync(x => x.IdVehicle == IdVehicle);
        }

        /*aqui tambem não deixa eu atribuir um valor para IdAssociate, diz que é chave duplicada*/
        public async Task<AssociateModel> AdicionarNovoVeiculo(long CpfPerson, List<VehicleModel> vehicles)
        {
            AssociateModel associate = await _dbContext.Associate.FirstOrDefaultAsync(x => x.CpfPerson == CpfPerson);

            if (associate == null)
            {
                throw new Exception("Associado não encontrado.");
            }

            foreach (var vehicle in vehicles)
            {
                vehicle.IdAssociate = associate.IdAssociate;

                await _dbContext.Vehicle.AddAsync(vehicle);
            }
            await _dbContext.SaveChangesAsync();

            return associate;
        }
        public async Task<VehicleModel> AtualizarVehicle(VehicleModel vehicle, long IdVehicle)
        {
            VehicleModel vehicles = await BuscarVehiclePorId(IdVehicle);

            if (vehicles == null)
            {
                throw new Exception("Esse veículo não existe mais em nossa base de dados.");
            }

            vehicle.IdAssociate = vehicle.IdAssociate;
            vehicles.Brand = vehicle.Brand;
            vehicle.Version = vehicle.Version;
            vehicle.Fuel = vehicle.Fuel;
            vehicle.NF = vehicle.NF;
            vehicle.Plate = vehicle.Plate;
            vehicle.Year = vehicle.Year;
            vehicle.Model = vehicle.Model;
            vehicle.NumberDoors = vehicle.NumberDoors;
            vehicle.Color = vehicle.Color;
            vehicle.Renavam = vehicle.Renavam;
            vehicle.Chassi = vehicle.Chassi;
            vehicle.FipeCode = vehicle.FipeCode;
            vehicle.FipeValue = vehicle.FipeValue;
            vehicle.VehicleNationality = vehicle.VehicleNationality;

            await _dbContext.SaveChangesAsync();
            return vehicle;
        }
        public async Task<bool> ExcluirVehicle(long IdVehicle)
        {
            VehicleModel vehicle = await BuscarVehiclePorId(IdVehicle);

            if (vehicle == null)
            {
                throw new Exception("Esse veículo não esta cadastrado em nossa base de dados.");
            }

            _dbContext.Vehicle.Remove(vehicle);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
