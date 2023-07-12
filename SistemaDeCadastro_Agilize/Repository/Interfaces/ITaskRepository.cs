using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskModel> RegisterTask(TaskModel task);
        Task<TaskModel> ConsultTask(string NameTask);
        Task<List<TaskModel>> ListTask();
        Task<TaskModel> FitchTask(long IdTask);
        Task<TaskModel> UpdateTask(TaskModel task, long IdTask);
        Task<bool> DeleteTask(long IdTask);
    }
}
