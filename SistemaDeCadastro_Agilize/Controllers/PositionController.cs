using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastro_Agilize.Data;

namespace SistemaDeCadastro_Agilize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly SistemasCadastroDBContex _DbContext;
        public PositionController (SistemasCadastroDBContex dbContext)
        {
            _DbContext = dbContext;
        }

    }
}
