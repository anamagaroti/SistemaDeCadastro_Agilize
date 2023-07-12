using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models.Tasks;
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
        public async Task<AssociateModel> FeathIdAssociate(long IdAssociate)
        {
            return await _dbContext.Associate.FirstOrDefaultAsync(x => x.IdAssociate == IdAssociate);
        }

        public async Task<AssociateModel> FeathAssociateCPF(long CpfPerson)
        {
            return await _dbContext.Associate.FirstOrDefaultAsync(x => x.CpfPerson == CpfPerson);
        }

        public async Task<AssociateDadosVehicleModel> RegisterAssociateAndVehicle(AssociateDadosVehicleModel associateDados)
        {
            AssociateModel asso = new AssociateModel();

            asso.IdAssociate = associateDados.AssociateModel.IdAssociate;
            asso.IdTask = 1;
            asso.CpfResponsible = associateDados.AssociateModel.CpfResponsible;
            asso.NamePerson = associateDados.AssociateModel?.NamePerson;
            asso.TelPerson = associateDados.AssociateModel.TelPerson;
            asso.EmailPerson = associateDados.AssociateModel.EmailPerson;
            asso.CpfPerson = associateDados.AssociateModel.CpfPerson;
            asso.SexoPerson = associateDados.AssociateModel?.SexoPerson;
            asso.RgPerson = associateDados.AssociateModel.RgPerson;
            asso.DateBornPerson = associateDados.AssociateModel.DateBornPerson;
            asso.NationalityPerson = associateDados.AssociateModel.NationalityPerson;
            asso.StreetPerson = associateDados.AssociateModel.StreetPerson;
            asso.CepPerson = associateDados.AssociateModel.CepPerson;
            asso.NumberPerson = associateDados.AssociateModel.NumberPerson;
            asso.ComplementPerson = associateDados.AssociateModel.ComplementPerson;
            asso.NeighborhoodPerson = associateDados.AssociateModel.NeighborhoodPerson;
            asso.CityPerson = associateDados.AssociateModel.CityPerson;
            asso.StatePerson = associateDados.AssociateModel.StatePerson;
            asso.ChnAssociate = associateDados.AssociateModel.ChnAssociate;
            asso.ValidadeCnh = associateDados.AssociateModel.ValidadeCnh;
            asso.CategoryCnh = associateDados.AssociateModel.CategoryCnh;
            asso.FirstLicenseCnh = associateDados?.AssociateModel.FirstLicenseCnh;
            asso.NationalityCnh = associateDados?.AssociateModel.NationalityCnh;

            await _dbContext.Associate.AddAsync(asso);
            await _dbContext.SaveChangesAsync();

            foreach (var vehicle in associateDados.DadosVehicle)
            {
                DadosVehicleModel dados = new DadosVehicleModel();

                dados.IdAssociate = associateDados.AssociateModel.IdAssociate;
                dados.IdRegisterVehicle = vehicle.IdRegisterVehicle;
                dados.IdTask = 2;
                dados.CpfResponsible = vehicle.CpfResponsible;
                dados.NF = vehicle?.NF;
                dados.Placa = vehicle?.Placa;
                dados.Renavam = vehicle.Renavam;
                dados.Chassi = vehicle.Chassi;
                dados.Color = vehicle?.Color;

                if (vehicle.IdRegisterVehicle == null)
                {
                    var registerVehicle = associateDados.registerVehicle;

                    RegisterVehicleModel register = new RegisterVehicleModel();

                    register.IdVehicle = vehicle.IdRegisterVehicle;
                    register.IdTask = 3;
                    register.TypeVehicle = registerVehicle.TypeVehicle;
                    register.Brand = registerVehicle.Brand;
                    register.Version = registerVehicle.Version;
                    register.Fuel = registerVehicle.Fuel;
                    register.Year = registerVehicle.Year;
                    register.Model = registerVehicle.Model;
                    register.NumberDoors = registerVehicle.NumberDoors;
                    register.FipeCode = registerVehicle.FipeCode;
                    register.FipeValue = registerVehicle.FipeValue;
                    register.VehicleValue = registerVehicle.VehicleValue;
                    register.VehicleNationality = registerVehicle.VehicleNationality;

                    await _dbContext.AddAsync(register);
                    await _dbContext.SaveChangesAsync();
                }

                await _dbContext.Dados.AddAsync(vehicle);
                await _dbContext.SaveChangesAsync();
            }

            await _dbContext.SaveChangesAsync();

            return associateDados;
        }

        public async Task<List<AssociateModel>> ListAssociate()
        {
            return await _dbContext.Associate.ToListAsync();
        }

        public async Task<List<AssociateDadosVehicleModel>> FeathDadosVehicle(long IdAssociate)
        {
            AssociateDadosVehicleModel associateDados = new AssociateDadosVehicleModel();

            var IdAsso = associateDados.AssociateModel = await _dbContext.Associate.FirstOrDefaultAsync(x => x.IdAssociate == IdAssociate);

            if (IdAsso == null)
            {
                throw new Exception("Esse associado não está mais cadastrado na base de dados.");
            }

            List<DadosVehicleModel> dados = await _dbContext.Dados.Where(x => x.IdAssociate == IdAsso.IdAssociate).ToListAsync();
            associateDados.ListVehicle = dados;



            return new List<AssociateDadosVehicleModel> { associateDados };
        }


        public async Task<AssociateModel> UpdateAssociate(AssociateModel associate, long IdAssociate)
        {
            AssociateModel existingAssociate = await FeathIdAssociate(IdAssociate);

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
