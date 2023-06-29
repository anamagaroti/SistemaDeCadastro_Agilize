namespace SistemaDeCadastro_Agilize.Models
{
    public class AssociateModel : PersonModel
    {
        public long IdAssociate { get; set; }
        public long ChnAssociate { get; set; }
        public string? ValidadeAssociate { get; set; }
        public string? CategoryAssociate { get; set; }
        public string? FirstLicenseAssociate { get; set; }
        public string? NationalityAssociate { get; set; }
        public List<VehicleModel>? Vehicle { get; set; }
    }
}
