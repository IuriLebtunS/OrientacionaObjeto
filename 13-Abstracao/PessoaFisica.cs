using System;

class PessoaFisica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine(" Taxa de Emprestimo para pessoa Fisica R$ " + (valor * 0.1));
    }
}

