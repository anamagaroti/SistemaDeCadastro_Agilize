using SistemaDeCadastro_Agilize.Models;

namespace SistemaDeCadastro_Agilize.Models.Tasks
{
    public class AssociateModel : PersonModel
    {
        public long IdAssociate { get; set; }
        public int IdTask { get; set; }
        public TaskModel? Task { get; set; }
        public ICollection<DadosVehicleModel>? Vehicles { get; set; }
        public int CpfResponsible { get; set; }
        public long ChnAssociate { get; set; }
        public string? ValidadeCnh { get; set; }
        public string? CategoryCnh { get; set; }
        public string? FirstLicenseCnh { get; set; }
        public string? NationalityCnh { get; set; }
        public ICollection<SignaturesModel>? Signatures { get; set; }

    }
}
