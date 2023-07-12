namespace SistemaDeCadastro_Agilize.Models.Tasks
{
    public class DadosVehicleModel
    {
        public long IdAssociate { get; set; }
        public AssociateModel? AssociateModel { get; set; }
        public long IdRegisterVehicle { get; set; }
        public RegisterVehicleModel? RegisterVehicle { get; set; }
        public long IdTask { get; set; }
        public TaskModel? TaskModel { get; set; }
        public ICollection<ImagesVehicleModel>? Images { get; set; }
        public long CpfResponsible { get; set; }
        public string? NF { get; set; }
        public string? Placa { get; set; }
        public long Renavam { get; set; }
        public string? Chassi { get; set; }
        public string? Color { get; set; }
    }
}
