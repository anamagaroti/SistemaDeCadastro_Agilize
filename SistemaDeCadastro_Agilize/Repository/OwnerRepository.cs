using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro_Agilize.Data;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly SistemasCadastroDBContex _DbContext;

        public OwnerRepository(SistemasCadastroDBContex context)
        {
             _DbContext = context;
        }
        public async Task<OwnerModel> BuscarPorIdOwner(long IdOwner)
        {
            return  await _DbContext.Owner.FirstOrDefaultAsync(x => x.IdOwner == IdOwner);
        }

        public async Task<OwnerModel> CadastroOwner(OwnerModel owner, List)
        {
            await _DbContext.Owner.AddAsync(owner);
            await _DbContext.SaveChangesAsync();

            OwnerTaskModel model = new OwnerTaskModel();

            model.IdOwner = owner.IdOwner;


            return owner;
        }

        public async Task<OwnerModel> EditarOwner(OwnerModel owner, long IdOwner)
        {
            OwnerModel ownerEdit = await BuscarPorIdOwner(IdOwner);

            if (ownerEdit != null)
            {
                throw new Exception("Não foi possível editar Proprietário");
            }

            ownerEdit.NamePerson = owner.NamePerson;
            ownerEdit.TelPerson = owner.TelPerson;
            ownerEdit.EmailPerson = owner.EmailPerson;
            ownerEdit.CpfPerson = owner.CpfPerson;
            ownerEdit.SexoPerson = owner.SexoPerson;
            ownerEdit.RgPerson = owner.RgPerson;
            ownerEdit.DateBornPerson = owner.DateBornPerson;
            ownerEdit.NationalityPerson = owner.NationalityPerson;
            ownerEdit.StreetPerson = owner.StreetPerson;
            ownerEdit.CepPerson = owner.CepPerson;
            ownerEdit.NumberPerson = owner.NumberPerson;
            ownerEdit.ComplementPerson = owner.ComplementPerson;
            ownerEdit.NeighborhoodPerson = owner.NeighborhoodPerson;
            ownerEdit.CityPerson = owner.CityPerson;
            ownerEdit.StatePerson = owner.StatePerson;

            _DbContext.Update(ownerEdit);
            _DbContext.SaveChanges();

            return ownerEdit;
        }
        public async Task<List<OwnerModel>> ListOwner()
        {
            return await _DbContext.Owner.ToListAsync();
        }
        public async Task<bool> ExcluirOwner(long IdOwner)
        {
            OwnerModel owner = await BuscarPorIdOwner(IdOwner);

            if(owner == null)
            {
                throw new Exception("Não foi possivel encontrar excluir este Proprietário");
            }

            _DbContext.Owner.Remove(owner);

             await _DbContext.SaveChangesAsync();

            return true;
        }
    }
}
