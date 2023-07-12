using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IPositionRepository 
    {
        Task<PositionModel> RegisterPosition(PositionModel positionModel, List<int> listIdTask);
        Task<PositionModel> FetchPositionId(long IdPosition);
        Task<PositionModel> UpdatePositionAndTask(PositionModel positionModel, long IdPosition, List<int> IsTask);
        Task <List<PositionModel>> ListPosition();
        Task<PositionModel> ConsultPosition(string NamePosition, List<string> NameTask);
        Task<bool> DeletePosition(long IsPosition);
    }
}
