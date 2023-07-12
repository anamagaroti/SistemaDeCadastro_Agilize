using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class PositionRepository : IPositionRepository
    {
        private readonly SistemasCadastroDBContex _DbContext;

        public PositionRepository(SistemasCadastroDBContex DbContext)
        {
            _DbContext = DbContext;
        }

        //precisa terminar a logica de buscar um cargo e trazer a lista de tarefas
        public async Task<PositionModel> ConsultPosition(int IdPosition, List<string> NameTask)
        {
           await _DbContext.Position.FirstOrDefaultAsync(x => x.IdPosition == IdPosition);


            TaskModel task = new TaskModel();
           
           foreach (var item in NameTask)
            {

            }
            
        }

        public async Task<bool> DeletePosition(long IsPosition)
        {
            PositionModel Id = await FetchPositionId(IsPosition);

            if(Id == null)
            {
                throw new Exception("Não foi possível deletar essa posição");
            }

            _DbContext.Position.Remove(Id);
            _DbContext.SaveChanges();

            return true;
        }

        public async Task<PositionModel> FetchPositionId(long IdPosition)
        {
            return await _DbContext.Position.FirstOrDefaultAsync(x => x.IdPosition == IdPosition);
        }

        public async Task<List<PositionModel>> ListPosition()
        {
            return await _DbContext.Position.ToListAsync();
        }

        public async Task<PositionModel> RegisterPosition(PositionModel positionModel, List<int> ListIdTask)
        {
            await _DbContext.Position.AddAsync(positionModel);
            await _DbContext.SaveChangesAsync();

            PositionTaskModel positionTask = new PositionTaskModel();

            foreach (var task in ListIdTask){  
                positionTask.IdPosition = positionModel.IdPosition;
                positionTask.IdTask = task;

                await _DbContext.PositionAndTask.AddAsync(positionTask);
                await _DbContext.SaveChangesAsync();
            }

            return positionModel;
        }

        public async Task<PositionModel> UpdatePositionAndTask(PositionModel positionModel, long IdPosition, List<int> IdTask)
        {
            PositionModel position = await FetchPositionId(IdPosition);

            position.NamePosition = positionModel.NamePosition;
            _DbContext.Update(position);
            await _DbContext.SaveChangesAsync();

            PositionTaskModel positionTask = new PositionTaskModel();

            foreach (var task in IdTask) {

                await _DbContext.PositionAndTask.FirstOrDefaultAsync(x => x.IdPosition == IdPosition);
                positionTask.IdTask = task;

                if (task == null)
                {
                    positionTask.IdPosition = positionModel.IdPosition;
                    positionTask.IdTask = task;

                    _DbContext.PositionAndTask.AddAsync(positionTask);
                    await _DbContext.SaveChangesAsync();
                }
                else
                {
                    _DbContext.Update(positionTask);
                    await _DbContext.SaveChangesAsync();
                }
            }

            return positionModel;
        }
    }
}
