namespace SistemaDeCadastro_Agilize.Models
{
    public class OwnerModel : PersonModel
    {
        public long IdOwner { get; set; }
        public ICollection<OwnerTaskModel>? OwnerTasks { get; set; }
        public ICollection<SignaturesModel>? Signatures { get; set; }
        public string? PasswordOwner { get; set; }
    }
}
