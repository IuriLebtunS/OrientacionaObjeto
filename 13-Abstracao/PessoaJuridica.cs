using System;

class PessoaJuridica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
      
      Console.WriteLine(" Taxa de Emprestimo para pessoa juridica R$ " + (valor * 0.2) );
      Console.WriteLine(Nome);
    }
     
   
}