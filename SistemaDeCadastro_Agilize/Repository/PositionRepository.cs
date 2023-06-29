using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class PositionRepository : IPositionRepository
    {
        public Task<PositionModel> ConsultPosition(PositionModel NamePosition)
        {
            throw new NotImplementedException();
        }

        public Task<PositionModel> DeletePosition(PositionModel positionModel, PositionModel IsPosition)
        {
            throw new NotImplementedException();
        }

        public Task<PositionModel> FetchPositionId(PositionModel IdPosition)
        {
            throw new NotImplementedException();
        }

        public Task<PositionModel> ListPosition(PositionModel positionModel)
        {
            throw new NotImplementedException();
        }

        public Task<PositionModel> RegisterPosition(PositionModel positionModel)
        {
            throw new NotImplementedException();
        }

        public Task<PositionModel> UpdatePosition(PositionModel positionModel, PositionModel IdPosition)
        {
            throw new NotImplementedException();
        }
    }
}
