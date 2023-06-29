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
        public async Task<CommercialPartnerModel> BuscarPorId(long IdEmployee)
        {
            return await _dbContext.Employee.FirstOrDefaultAsync(x => x.IdEmployee == IdEmployee);
        }

        public async Task<List<CommercialPartnerModel>> BuscarTodosFuncionarios()
        {
            return await _dbContext.Employee.ToListAsync();
        }
        public async Task<CommercialPartnerModel> Adicionar(CommercialPartnerModel employee)
        {
            await _dbContext.AddAsync(employee);
            await _dbContext.SaveChangesAsync();

            return employee;
        }

        public async Task<CommercialPartnerModel> Atualizar(CommercialPartnerModel employee, long IdEmployee)
        {
            CommercialPartnerModel employeePorId = await BuscarPorId(IdEmployee);

            if (employeePorId == null)
            {
                throw new Exception("O funcionario que deseja encontrar não esta cadastrado em nossa base de dados.");
            }
            employeePorId.NamePerson = employee.NamePerson;
            employeePorId.TelPerson = employee.TelPerson;
            employeePorId.EmailPerson = employee.EmailPerson;
            employeePorId.CpfPerson = employee.CpfPerson;
            employeePorId.SexoPerson = employee.SexoPerson;
            employeePorId.RgPerson = employee.RgPerson;
            employeePorId.DateBornPerson = employee.DateBornPerson;
            employeePorId.Address = employee.Address;
            employeePorId.NeighborhoodPerson = employee.NeighborhoodPerson;
            employeePorId.NumberPerson = employee.NumberPerson;
            employeePorId.UFPerson = employee.UFPerson;
            employeePorId.CepPerson = employee.CepPerson;

            _dbContext.Employee.Update(employeePorId);

            await _dbContext.SaveChangesAsync();

            return employeePorId;
        }

        public async Task<bool> Excluir(long IdEmployee)
        {
            CommercialPartnerModel employeePorId = await BuscarPorId(IdEmployee);

            if (employeePorId == null)
            {
                throw new Exception("O funcionario que deseja encontrar não esta cadastrado em nossa base de dados.");
            }

            _dbContext.Employee.Remove(employeePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
