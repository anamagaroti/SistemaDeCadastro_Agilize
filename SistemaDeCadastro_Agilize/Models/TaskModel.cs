using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Models
{
    public class TaskModel
    {
        public long IdTask { get; set; }
        public string? NameTask { get; set; }
        public ICollection<PositionTaskModel>? PositionTask { get; set; }
        public ICollection<OwnerTaskModel>? OwnerTasks { get; set; }

        //TASKS//
        public AssociateModel? Associate { get; set; }
        public RegisterVehicleModel? Vehicle { get; set; }
        public DadosVehicleModel? DadosVehicle { get; set;}
    }
}
