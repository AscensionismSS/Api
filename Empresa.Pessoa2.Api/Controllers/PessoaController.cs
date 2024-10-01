using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work.Pessoa.Service;

namespace Empresa.Pessoa2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        [HttpGet(), Route("cpf-valido")]

        public IActionResult ObterCpfValido(string cpf)
        {
            /*chamando método referente a sua service*/
            bool cpfValido = new CpfService().IsCpf(cpf);

            return Ok(new { cpf, cpfValido });
        }


        [HttpGet(), Route("maioridade/cpf-valido")]


		public IActionResult ObterCpfValido(DateTime dataNascimento, string cpf)
        {
            /*chamando métodos referente a sua service*/
            var (idade, MaiorIdade) = new IdadeService().MaiorIdade(dataNascimento);
            bool cpfValido = new CpfService().IsCpf(cpf);

            return Ok(new { idade, MaiorIdade, cpf, cpfValido });
        }
    }
}
