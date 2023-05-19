using System;

class Atendente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine(" Desconto Atendente do Vale alimentação R$" + (salario * 0.12));
    }



}