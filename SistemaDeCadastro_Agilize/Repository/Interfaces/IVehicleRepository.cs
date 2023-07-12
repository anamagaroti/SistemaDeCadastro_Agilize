using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<RegisterVehicleModel>> ListVehicle();
        Task<RegisterVehicleModel> RegisterVehicle(RegisterVehicleModel vehicle);
        Task<RegisterVehicleModel> FitchVehicle(long IdVehicle);
        Task<RegisterVehicleModel> UpdateVehicle(RegisterVehicleModel vehicle, long IdVehicle);
        Task<bool> DeleteVehicle(long IdVehicle);
    }
}
