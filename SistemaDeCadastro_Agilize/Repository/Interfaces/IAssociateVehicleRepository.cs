﻿using SistemaDeCadastro_Agilize.Models.Tasks;

namespace SistemaDeCadastro_Agilize.Repository.Interfaces
{
    public interface IAssociateVehicleRepository
    {
        Task<AssociateModel> AdicionarAssociadoComVeiculos
            (AssociateModel associate);
        Task<bool> ExcluirAssociadoVeiculo(long IdAssociate, long IdVehicle);
    }
}
