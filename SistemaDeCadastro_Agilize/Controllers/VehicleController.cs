using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro_Agilize.Models;
using SistemaDeCadastro_Agilize.Repository.Interfaces;

namespace SistemaDeCadastro_Agilize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleModel>>> BuscarTodosVeiculos()
        {
            List<VehicleModel> vehicle = await _vehicleRepository.BuscarTodosVeiculos();

            return Ok(vehicle);
        }

        [HttpGet("{placa}/associate/{id}")]
        public async Task<ActionResult<List<VehicleModel>>> BuscarPorId(string placa, long id)
        {
            VehicleModel vehicle = await _vehicleRepository.BuscarPorPlacaVehicle(placa, id);

            return Ok(vehicle);
        }

        [HttpPost("associado/{cpf}/vehicles")]
        public async Task<ActionResult> AdicionarNovoVeiculo(long cpf, [FromBody] List<VehicleModel> vehicles)
        {
            await _vehicleRepository.AdicionarNovoVeiculo(cpf, vehicles);

            return Ok();
        }

        [HttpPut("{idVehicle}")]
        public async Task<ActionResult<VehicleModel>> AtualizarVehicle([FromBody] VehicleModel vehicle, long IdVehicle)
        {
            vehicle.IdVehicle = IdVehicle;

            VehicleModel updatedVehicle = await _vehicleRepository.AtualizarVehicle(vehicle, IdVehicle);

            return Ok(updatedVehicle);
        }

        [HttpDelete("{idVehicle}")]
        public async Task<ActionResult> ExcluirVehicle(long idVehicle)
        {
            bool apagado = await _vehicleRepository.ExcluirVehicle(idVehicle);

            return Ok(apagado);
        }
    }
}
