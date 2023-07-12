using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Models
{
    public class SignaturesModel
    {
        public int IdOwner { get; set; }
        public OwnerModel? Owner { get; set; }
        public int IdAssociate { get; set; }
        public AssociateModel? Associate { get; set; }
        public string? NameImageSignatures { get; set; }
        public DateOnly DateImageSignature { get; set; }
    }
}
