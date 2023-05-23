using System;

namespace _13Abstracao
{
    class program
    {
        static void Main(string[] args)
        {
            
            PessoaFisica Pf = new PessoaFisica();
            Pf.TaxaEmprestimo(1000);
            Pf.Nome = "Iuri";
            PessoaJuridica Pj = new PessoaJuridica();
            Pj.Nome = "Tiago";
            Console.WriteLine(Pj.Nome);
            //Pj.TaxaEmprestimo(1000);
        }
    }
}
