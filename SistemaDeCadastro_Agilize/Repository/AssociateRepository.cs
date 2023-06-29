using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class AssociateRepository : IAssociateRepository
    {
        private readonly SistemasCadastroDBContex _dbContext;

        public AssociateRepository(SistemasCadastroDBContex sistemasCadastroDBContex)
        {
            _dbContext = sistemasCadastroDBContex;
        }
        public async Task<AssociateModel> BuscarPorId(long IdAssociate)
        {
            return await _dbContext.Associate.FirstOrDefaultAsync(x => x.IdAssociate == IdAssociate);
        }
        public async Task<AssociateModel> BuscarAssociadoPorCpf(long CpfPerson)
        {
            return await _dbContext.Associate.FirstOrDefaultAsync(x => x.CpfPerson == CpfPerson);
        }

        /*analisar esse codigo, veiculo esta retornando null*/
        public async Task<List<VehicleModel>> BuscarAssociadosComVeiculos(long CpfPerson)
        {
            AssociateModel associate = await _dbContext.Associate.FirstOrDefaultAsync(x => x.CpfPerson == CpfPerson);

            if (associate == null)
            {
                throw new Exception("Esse associado não esta mais cadastrado na base de dados.");
            }

            List<VehicleModel> vehicles = await _dbContext.Vehicle.Where(x => x.IdAssociate == associate.IdAssociate).ToListAsync();

            return (vehicles);
        }
        public async Task<List<AssociateModel>> BuscarTodosAssociados()
        {
            return await _dbContext.Associate.ToListAsync();
        }

        /*analisar esse codigo para tentar fazer a logica de cadastrar 1 para n*/
        public async Task<AssociateModel> AdicionarAssociadoComVeiculos(AssociateModel associate, List<VehicleModel> vehicles)
        {
            await _dbContext.Associate.AddAsync(associate);
            await _dbContext.SaveChangesAsync();

            foreach (var vehicle in vehicles)
            {
                vehicle.IdAssociate = associate.IdAssociate;
                await _dbContext.Vehicle.AddAsync(vehicle);
            }

            await _dbContext.SaveChangesAsync();

            return associate;
        }

        /*verificar o porque do erro 400*/
        public async Task<AssociateModel> AtualizarAssociate(AssociateModel associate, long IdAssociate)
        {
            AssociateModel existingAssociate = await BuscarPorId(IdAssociate);

            if (existingAssociate == null)
            {
                throw new Exception("O associado ou veículo que deseja atualizar não existe mais em nossa base de dados.");
            }

            existingAssociate.NamePerson = associate.NamePerson;
            existingAssociate.TelPerson = associate.TelPerson;
            existingAssociate.EmailPerson = associate.EmailPerson;
            existingAssociate.CpfPerson = associate.CpfPerson;
            existingAssociate.SexoPerson = associate.SexoPerson;
            existingAssociate.RgPerson = associate.RgPerson;
            existingAssociate.DateBornPerson = associate.DateBornPerson;
            existingAssociate.Address = associate.Address;
            existingAssociate.NeighborhoodPerson = associate.NeighborhoodPerson;
            existingAssociate.NumberPerson = associate.NumberPerson;
            existingAssociate.UFPerson = associate.UFPerson;
            existingAssociate.CepPerson = associate.CepPerson;
            existingAssociate.ChnAssociate = associate.ChnAssociate;
            existingAssociate.ValidadeAssociate = associate.ValidadeAssociate;
            existingAssociate.CategoryAssociate = associate.CategoryAssociate;
            existingAssociate.FirstLicenseAssociate = associate.FirstLicenseAssociate;
            existingAssociate.NationalityAssociate = associate.NationalityAssociate;

            await _dbContext.SaveChangesAsync();

            return existingAssociate;
        }
    }
}
