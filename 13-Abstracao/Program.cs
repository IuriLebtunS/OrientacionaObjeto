using System;

namespace _13Abstracao
{
    class program
    {
        static void Main(string[] args)
        {
            PessoaFisica Pf = new PessoaFisica();
            Pf.TaxaEmprestimo(1000);

            PessoaJuridica Pj = new PessoaJuridica();
            Pj.TaxaEmprestimo(1000);
        }
    }
}
