using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IPositionRepository 
    {
        Task<PositionModel> RegisterPosition(PositionModel positionModel);
        Task<PositionModel> FetchPositionId(PositionModel IdPosition);
        Task<PositionModel> UpdatePosition(PositionModel positionModel, PositionModel IdPosition);
        Task <List<PositionModel>> ListPosition(PositionModel positionModel);
        Task<PositionModel> ConsultPosition(PositionModel NamePosition);
        Task<PositionModel> DeletePosition(PositionModel positionModel, PositionModel IsPosition);
    }
}
