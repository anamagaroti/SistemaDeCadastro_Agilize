namespace SistemaDeCadastro_Agilize.Models.Tasks
{
    public class AssociateDadosVehicleModel
    {
        public int IdAssociate { get; set; }
        public AssociateModel? AssociateModel { get; set; }
        public List<DadosVehicleModel>? DadosVehicle { get; set; }
        public DadosVehicleModel? dadosVehicleModel { get; set; }
        public RegisterVehicleModel? registerVehicle { get; set; }
        public List<RegisterVehicleModel>? ListVehicle { get; set; }
    }
}
