using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Models
{
    public class ImagesVehicleModel
    {
        public long IdImageVehicle { get; set; }
        public long IdAssociate { get; set; } 
        public DadosVehicleModel? Vehicle { get; set; }
        public string? NameImageVehicle { get; set; }
        public DateOnly DateImageVehicle { get; set; }
    }
}
