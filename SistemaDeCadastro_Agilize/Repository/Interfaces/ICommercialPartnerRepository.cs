using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface ICommercialPartnerRepository
    {
        Task<List<CommercialPartnerModel>> BuscarTodosCP();
        Task<CommercialPartnerModel> BuscarPorIdCP(long IdCP);
        Task<CommercialPartnerModel> CadastrarCP(CommercialPartnerModel CP);
        Task<CommercialPartnerModel> EditarCP(CommercialPartnerModel CP, long IdCP);
        Task<bool> ExcluirCP(long IdCP);
    }
}
