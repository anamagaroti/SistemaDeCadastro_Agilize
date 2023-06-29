using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateVehicleController : ControllerBase
    {
        private readonly IAssociateVehicleRepository _associateVehicleRepository;
        public AssociateVehicleController(IAssociateVehicleRepository associateVehicleRepository)
        {
            _associateVehicleRepository = associateVehicleRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarNovoVeiculo([FromBody] AssociateModel associateEvehicle)
        {
            AssociateModel associadoEveiculo = await _associateVehicleRepository.AdicionarAssociadoComVeiculos(associateEvehicle);

            return Ok(associadoEveiculo);
        }

        [HttpDelete("{idVehicle}/{idAssociate}")]
        public async Task<ActionResult> ExcluirVehicle(long idVehicle, long idAssociate)
        {
            bool apagados = await _associateVehicleRepository.ExcluirAssociadoVeiculo(idVehicle, idAssociate);

            return Ok(apagados);
        }
    }
}
