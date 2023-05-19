using System;

abstract class Padrao
{
    //Metodo Obrigatorio

     public abstract void TaxaEmprestimo(double valor);


    //Metodo Opcional
    public void calculoPoupanca(double valor, double taxa)
    {

       Console.WriteLine(" Ganhos Obtidos pela Poupança " + ( valor * taxa ));

    }
}