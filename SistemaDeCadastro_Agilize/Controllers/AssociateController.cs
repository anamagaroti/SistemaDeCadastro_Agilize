using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro_Agilize.Models.Tasks;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateController : ControllerBase
    {
        private readonly IAssociateRepository _associateRepository;
        public AssociateController(IAssociateRepository associateRepository)
        {
            _associateRepository = associateRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<AssociateModel>>> BuscarTodosAssociados()
        {
            List<AssociateModel> associateEvehicle = await _associateRepository.BuscarTodosAssociados();
            return Ok(associateEvehicle);
        }

        [HttpGet("id{id}")]
        public async Task<ActionResult<List<AssociateModel>>> BuscarPorId(long id)
        {
            AssociateModel associate = await _associateRepository.BuscarPorId(id);

            return Ok(associate);
        }

        [HttpGet("buscar{cpf}")]
        public async Task<ActionResult<List<AssociateModel>>> BuscarAssociadoPorCpf(long cpf)
        {
            AssociateModel associate = await _associateRepository.BuscarAssociadoPorCpf(cpf);

            return Ok(associate);
        }

        [HttpPut("{idAssociate}")]
        public async Task<ActionResult<AssociateModel>> AtualizarAssociate([FromBody] AssociateModel associate, long IdAssociate)
        {
            associate.IdAssociate = IdAssociate;

            AssociateModel updatedAssociate = await _associateRepository.AtualizarAssociate(associate, IdAssociate);

            return Ok(updatedAssociate);
        }
    }
}
