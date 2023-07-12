using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IAssociateRepository
    {
        Task<AssociateModel> FeathIdAssociate(long IdAssociate);
        Task<AssociateModel> FeathAssociateCPF(long CpfPerson);
        Task<AssociateDadosVehicleModel> RegisterAssociateAndVehicle(AssociateDadosVehicleModel associateDados);
        Task<List<AssociateModel>> ListAssociate(); 
        Task<List<RegisterVehicleModel>> FeathAssociateAndVehicle(long CpfPerson);
        Task<AssociateModel> UpdateAssociate(AssociateModel associate, long IdAssociate);
    }
}
