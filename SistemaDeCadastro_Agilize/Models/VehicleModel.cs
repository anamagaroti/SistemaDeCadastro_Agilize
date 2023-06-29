namespace SistemaDeCadastro_Agilize.Models
{
    public class VehicleModel
    {
        public long IdVehicle { get; set; }
        public long IdAssociate { get; set; }
        public string? Brand { get; set; }
        public string? Version { get; set; }
        public string? Fuel { get; set; }
        public string? NF { get; set; }
        public string? Plate { get; set; }
        public int Year { get; set; }
        public string? Model { get; set; }
        public int NumberDoors { get; set; }
        public string? Color { get; set; }
        public long Renavam { get; set; }
        public string? Chassi { get; set; }
        public long FipeCode { get; set; }
        public decimal FipeValue { get; set; }
        public string? VehicleNationality { get; set; }
    }
}
