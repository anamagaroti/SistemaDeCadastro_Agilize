namespace SistemaDeCadastro_Agilize.Models
{
    public class PositionModel
    {
       public long IdPosition { get; set; }
       public ICollection<CommercialPartnerModel>? Partners { get; set; }
        public ICollection<PositionTaskModel>? PositionTask { get; set; }
        public string? NamePosition { get; set; }

    }
}
