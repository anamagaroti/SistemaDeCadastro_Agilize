using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;
using System.Drawing;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class AssociateVehicleRepository : IAssociateVehicleRepository
    {
        private readonly SistemasCadastroDBContex _dbContext;

        public AssociateVehicleRepository(SistemasCadastroDBContex sistemasCadastroDBContex)
        {
            _dbContext = sistemasCadastroDBContex;
        }

        /*esse é mais urgente*/

        /*repensar nesse codigo para suportar cadastrar 1 para n*/
        /*verificar o porque ele esta enviando chaves duplicadas, aparentemente eu não posso cadastrar IdAssociate com um mesmo valor*/
        /*verificar como eu consigo ver os valores que estam vindo no json*/
        public async Task<AssociateModel> AdicionarAssociadoComVeiculos(AssociateModel associateVehicle)
        {
            await _dbContext.Associate.AddAsync(associateVehicle);
            await _dbContext.SaveChangesAsync();

            var associate = await _dbContext.Associate.AsNoTracking().FirstOrDefaultAsync(a => a.IdAssociate == associateVehicle.IdAssociate);

            var id = associate.IdAssociate;
                var vehicles = associateVehicle.Vehicle;

                foreach (var vehicle in vehicles)
                {
                    vehicle.IdAssociate = id;
                    await _dbContext.Vehicle.AddAsync(vehicle);
                }

                await _dbContext.SaveChangesAsync();
            

            return associate;
        }


        /*analisar esse codigo, esta dizendo que ja foi excluido logo não esta achando o id*/

        public async Task<bool> ExcluirAssociadoVeiculo(long IdAssociate, long IdVehicle)
        {
            AssociateModel associate = await _dbContext.Associate.FirstOrDefaultAsync
                (x => x.IdAssociate == IdAssociate);

            VehicleModel vehicle = await _dbContext.Vehicle.FirstOrDefaultAsync
                (x => x.IdVehicle == IdVehicle);

            if (associate == null || vehicle == null)
            {
                throw new Exception("Veículo ou Associado já foi excluído");
            }


            _dbContext.Associate.Remove(associate);
            _dbContext.Vehicle.Remove(vehicle);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
