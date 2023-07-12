using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IOwnerRepository
    {
        Task<OwnerModel> CadastroOwner (OwnerModel owner);
        Task<OwnerModel> EditarOwner(OwnerModel owner, long IdOwner);
        Task<OwnerModel> BuscarPorIdOwner(long IdOwner);
        Task<List<OwnerModel>> ListOwner();
        Task<bool> ExcluirOwner(long IdOwner);
    }
}
