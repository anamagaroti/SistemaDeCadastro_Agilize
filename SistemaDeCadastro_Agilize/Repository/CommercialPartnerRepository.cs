using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class CommercialPartnerRepository : ICommercialPartnerRepository
    {
        private readonly SistemasCadastroDBContex _dbContext;

        public CommercialPartnerRepository(SistemasCadastroDBContex sistemasCadastroDBContex)
        {
            _dbContext = sistemasCadastroDBContex;
        }
        public async Task<CommercialPartnerModel> BuscarPorIdCP(long IdCP)
        {
            return await _dbContext.CP.FirstOrDefaultAsync(x => x.IdCP == IdCP);
        }

        public async Task<List<CommercialPartnerModel>> BuscarTodosCP()
        {
            return await _dbContext.CP.ToListAsync();
        }
        public async Task<CommercialPartnerModel> CadastrarCP(CommercialPartnerModel cp)
        {
            await _dbContext.AddAsync(cp);
            await _dbContext.SaveChangesAsync();

            return cp;
        }

        public async Task<CommercialPartnerModel> EditarCP(CommercialPartnerModel cp, long IdCP)
        {
            CommercialPartnerModel CPPorId = await BuscarPorIdCP(IdCP);

            if (CPPorId == null)
            {
                throw new Exception("O funcionario que deseja encontrar não esta cadastrado em nossa base de dados.");
            }
            CPPorId.NamePerson = cp.NamePerson;
            CPPorId.TelPerson = cp.TelPerson;
            CPPorId.EmailPerson = cp.EmailPerson;
            CPPorId.CpfPerson = cp.CpfPerson;
            CPPorId.SexoPerson = cp.SexoPerson;
            CPPorId.RgPerson = cp.RgPerson;
            CPPorId.DateBornPerson = cp.DateBornPerson;
            CPPorId.NationalityPerson = cp.NationalityPerson;
            CPPorId.StreetPerson = cp.StreetPerson;
            CPPorId.CepPerson = cp.CepPerson;
            CPPorId.NumberPerson = cp.NumberPerson;
            CPPorId.ComplementPerson = cp.ComplementPerson;
            CPPorId.NeighborhoodPerson = cp.NeighborhoodPerson;
            CPPorId.CityPerson = cp.CityPerson;
            CPPorId.StatePerson = cp.StatePerson;
            CPPorId.IdPosition = cp.IdPosition;

            _dbContext.CP.Update(CPPorId);

            await _dbContext.SaveChangesAsync();

            return CPPorId;
        }

        public async Task<bool> ExcluirCP(long IdCP)
        {
            CommercialPartnerModel CPPorId = await BuscarPorIdCP(IdCP);

            if (CPPorId == null)
            {
                throw new Exception("O parceiro comercial que deseja encontrar não esta cadastrado em nossa base de dados.");
            }

            _dbContext.CP.Remove(CPPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
