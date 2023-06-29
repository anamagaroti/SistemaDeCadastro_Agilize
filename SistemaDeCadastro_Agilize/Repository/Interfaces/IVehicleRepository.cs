using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<VehicleModel>> BuscarTodosVeiculos();
        Task<VehicleModel> BuscarPorPlacaVehicle(string Plate, long IdAssociate);
        Task<VehicleModel> BuscarVehiclePorId(long IdVehicle);
        Task<AssociateModel> AdicionarNovoVeiculo(long CpfPerson, List<VehicleModel> vehicle);
        Task<VehicleModel> AtualizarVehicle(VehicleModel vehicle, long IdVehicle);
        Task<bool> ExcluirVehicle(long IdVehicle);
    }
}
