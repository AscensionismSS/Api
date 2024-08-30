using Microsoft.AspNetCore.Mvc;
using Work.Pessoa.Service;

namespace Empresa.Pessoa2.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeController : ControllerBase
    {
        [HttpGet(), Route("ObterIdade")]

        public  IActionResult ObterIdade(DateTime dataNascimento)
        {
            int idade = new IdadeService().BuscarIdade(dataNascimento);

            return Ok(idade);
        }


    }
}
