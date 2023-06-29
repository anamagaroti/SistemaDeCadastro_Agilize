using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface ICommercialPartnerRepository
    {
        Task<List<CommercialPartnerModel>> BuscarTodosFuncionarios();
        Task<CommercialPartnerModel> BuscarPorId(long IdCP);
        Task<CommercialPartnerModel> Adicionar(CommercialPartnerModel CP);
        Task<CommercialPartnerModel> Atualizar(CommercialPartnerModel CP, long IdCP);
        Task<bool> Excluir(long IdCP);
    }
}
