namespace SistemaDeCadastro_Agilize.Models
{
    public class CommercialPartnerModel : PersonModel
    {
        public long IdCP { get; set; }
        public long IdPosition { get; set; }
        public string? Password { get; set; }
    }
}
