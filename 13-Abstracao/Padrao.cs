using System;

abstract class Padrao
{
    //Metodo Obrigatorio

    public abstract void TaxaEmprestimo(double valor);

    //Metodo Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine(" Os ganhos obtidos pela poupança sao R$ " + (valor * taxa));
    }
}