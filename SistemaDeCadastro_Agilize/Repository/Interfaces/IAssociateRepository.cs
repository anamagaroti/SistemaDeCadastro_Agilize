using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IAssociateRepository
    {
        Task<AssociateModel> FeathIdAssociate(long IdAssociate);
        Task<AssociateModel> FeathAssociateCPF(long CpfPerson);
        Task<AssociateDadosVehicleModel> RegisterAssociateAndVehicle(AssociateDadosVehicleModel associateDados);
        Task<List<AssociateModel>> ListAssociate(); 
        Task<List<AssociateDadosVehicleModel>> FeathDadosVehicle(long IdAssociate);
        Task<AssociateModel> UpdateAssociate(AssociateModel associate, long IdAssociate);
    }
}
