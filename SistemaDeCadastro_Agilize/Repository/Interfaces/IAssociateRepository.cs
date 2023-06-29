using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IAssociateRepository
    {
        Task<List<AssociateModel>> BuscarTodosAssociados();
        Task<AssociateModel> BuscarAssociadoPorCpf(long CpfPerson);
        Task<AssociateModel> BuscarPorId(long IdAssociate);
        Task<List<VehicleModel>> BuscarAssociadosComVeiculos(long CpfPerson);
        Task<AssociateModel> AtualizarAssociate(AssociateModel associate, long IdAssociate);
    }
}
