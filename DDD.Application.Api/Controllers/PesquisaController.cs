using DDD.Application.Service;
using DDD.Domain.PicContext;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PesquisaController : ControllerBase
    {
        private readonly PesquisaAppService _pesquisaAppService;

        public PesquisaController(PesquisaAppService pesquisaAppService)
        {
            _pesquisaAppService = pesquisaAppService;
        }

        [HttpPost("cadastrarPesquisador")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CadastrarPesquisador([FromBody] Pesquisador pesquisador)
        {
            try
            {
                _pesquisaAppService.CadastrarPesquisador(pesquisador);
                return Ok(pesquisador);
            }
            catch (PesquisaAppService.BusinessException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("cadastrarProjeto")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult CadastrarProjeto([FromBody] Projeto projeto)
        {
            try
            {
                _pesquisaAppService.CadastrarProjeto(projeto);
                return Ok(projeto);
            }
            catch (PesquisaAppService.BusinessException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
