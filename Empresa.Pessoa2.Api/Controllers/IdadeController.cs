using Microsoft.AspNetCore.Mvc;
using Work.Pessoa.Service;
using static System.Net.Mime.MediaTypeNames;

namespace Empresa.Pessoa2.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeController : ControllerBase
    {
        [HttpGet]

        public IActionResult ObterIdade(DateTime dataNascimento)
        {
            int idade = new IdadeService().BuscarIdade(dataNascimento);

            return Ok (idade);
        }


        [HttpGet(), Route("detalhada")]

        public IActionResult ObterIdadeDetatalhada(DateTime dataNascimento)
        {
            /*chamando método referente a sua service*/
            var (IdadeEmMeses, IdadeEmDias) = new IdadeService().BuscarIdadeDetalhada(dataNascimento);

            return Ok(new { IdadeEmMeses, IdadeEmDias});
        }


    }
}
