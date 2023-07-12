namespace SistemaDeCadastro_Agilize.Models.Tasks
{
    public class RegisterVehicleModel
    {
        public long IdVehicle { get; set; }
        public int IdTask { get; set; }
        public TaskModel? Task { get; set; }
        public string? TypeVehicle { get; set; }
        public string? Brand { get; set; }
        public string? Version { get; set; }
        public string? Fuel { get; set; }
        public int Year { get; set; }
        public string? Model { get; set; }
        public int NumberDoors { get; set; }
        public long FipeCode { get; set; }
        public decimal FipeValue { get; set; }
        public decimal VehicleValue { get; set; }
        public string? VehicleNationality { get; set; }
        public ICollection<DadosVehicleModel>? DadosVehicles { get; set; }
    }
}
