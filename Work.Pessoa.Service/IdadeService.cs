
using System;
using System.Diagnostics;

namespace Work.Pessoa.Service
{
    public class IdadeService
    {
        public int BuscarIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;

            if (dataNascimento.Date > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            /*Faz o mesmo que o código acima
             
            if (dataAtual.Month < dataNascimento.Month)
             {
                 idade--;
             }
             if (dataAtual.Day < dataNascimento.Day)
             {
                 idade--;
            }

            */

            return idade;
        }


        public (int meses, int dias) BuscarIdadeDetalhada(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            // usar o método BuscarIdade para obter a idade
            int idade = BuscarIdade(dataNascimento);

            // calcular o total de dias desde a data de nascimento

            TimeSpan contagemDias = dataAtual - dataNascimento;
            int dias = contagemDias.Days;
            int meses = idade * 12;

            /*faz quase o mesmo que o código acima

            int dias = idade * 365 + (idade/4);
            int meses = idade * 12;

            */

            return (meses, dias);

        }


        /*método com tupla*/
        public (int idade, bool MaiorIdade) MaiorIdade(DateTime dataNascimento)
        {
            int idade = BuscarIdade(dataNascimento);

            bool MaiorIdade = idade >= 18;
            return (idade, MaiorIdade);

            /* faz o mesmo que o código acima
            
            if (idade >= 18)
            {
                return (idade,true);
            }
            else 
            {
                return (idade,false);
            }
            
            */

        }
    }
}

