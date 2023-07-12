﻿namespace SistemaDeCadastro_Agilize.Models
{
    public class CommercialPartnerModel : PersonModel
    {
        public long IdCP { get; set; }
        public long IdPosition { get; set; }
        public PositionModel? Position { get; set; }
        public string? Password { get; set; }
    }
}
