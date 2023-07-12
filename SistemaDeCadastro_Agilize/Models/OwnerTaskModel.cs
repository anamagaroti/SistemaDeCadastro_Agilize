namespace SistemaDeCadastro_Agilize.Models
{
    public class OwnerTaskModel
    {
        public long IdOwner { get; set; }
        public long IdTask { get; set; }
        public OwnerModel? Owner { get; set; }
        public TaskModel? Task { get; set; }
    }
}
