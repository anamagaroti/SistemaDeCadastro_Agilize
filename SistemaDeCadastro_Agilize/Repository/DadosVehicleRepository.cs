using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models.Tasks;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class DadosVehicleRepository : IDadosVehicleRepository
    {
        private readonly SistemasCadastroDBContex _DbContext;

        public DadosVehicleRepository(SistemasCadastroDBContex DbContext) {
            DbContext = _DbContext;
        }
        //aqui ele vai cadastrar mais de 1 veiculo e os dados dele.
        public Task<List<DadosVehicleModel>> RegisterDadosVehicle(List<DadosVehicleModel> model, int IdAssociate)
        {
            throw new NotImplementedException();
        }

        // aqui ele vai editar somente os dados do veiculo, e pode ser que seja mais de um veiculo editado
        public Task<DadosVehicleModel> UpdateDadosVehicle(List<DadosVehicleModel> vehicle, List<long> IdDadosVehicle)
        {
            throw new NotImplementedException();
        }
    }
}
