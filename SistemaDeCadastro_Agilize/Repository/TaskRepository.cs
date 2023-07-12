using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly SistemasCadastroDBContex _DbContext;
        public TaskRepository(SistemasCadastroDBContex DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<TaskModel> ConsultTask(string NameTask)
        {
            return await _DbContext.Task.FirstOrDefaultAsync(x => x.NameTask == NameTask);
        }

        public async Task<bool> DeleteTask(long IdTask)
        {
            TaskModel task = await FitchTask(IdTask);

            if(task == null) 
            {
                throw new Exception("Não foi possível excluir essa tarefa");
            }

            _DbContext.Task.Remove(task);
            _DbContext.SaveChanges();

            return true;

        }

        public async Task<TaskModel> FitchTask(long IdTask)
        {
           return await _DbContext.Task.FirstOrDefaultAsync(x => x.IdTask == IdTask);
        }

        public async Task<List<TaskModel>> ListTask()
        {
            return await _DbContext.Task.ToListAsync();
        }

        public async Task<TaskModel> RegisterTask(TaskModel task)
        {
            await _DbContext.Task.AddAsync(task);

            _DbContext.SaveChanges();

            return task;
        }

        public async Task<TaskModel> UpdateTask(TaskModel task, long IdTask)
        {
            TaskModel taskId = await FitchTask(IdTask);

            if(taskId == null)
            {
                throw new Exception($"{nameof(TaskModel)} Não existe");
            }

            taskId.NameTask = task.NameTask;

            _DbContext.Task.Update(taskId);
            _DbContext.SaveChanges();
            return taskId;
        }
    }
}
