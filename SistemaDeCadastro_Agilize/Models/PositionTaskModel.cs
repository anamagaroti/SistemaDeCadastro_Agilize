namespace SistemaDeCadastro_Agilize.Models
{
    public class PositionTaskModel
    {
        public long IdPosition { get; set; }
        public long IdTask { get; set; }
        public PositionModel? Position { get; set; }
        public TaskModel? Task { get; set; }
    }
}
