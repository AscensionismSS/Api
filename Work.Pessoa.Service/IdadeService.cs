
namespace Work.Pessoa.Service
{
    public class IdadeService
    {
        public int BuscarIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataAtual.Month < dataNascimento.Month)
                idade--;
            return idade;

        }

    }
}
