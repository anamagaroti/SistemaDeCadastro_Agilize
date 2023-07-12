using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IDadosVehicleRepository
    {
        Task <List<DadosVehicleModel>> RegisterDadosVehicle(List<DadosVehicleModel> model, int IdAssociate);
        Task<DadosVehicleModel> UpdateDadosVehicle(List<DadosVehicleModel> vehicle, List<long> IdDadosVehicle);
    }
}
