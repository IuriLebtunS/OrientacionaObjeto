using System;

class Atendente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine(" Desconto Atendente do Vale alimentação R$" + (salario * 0.12));
    }
     public override void ValeTransporte(double salario)
    {
        Console.WriteLine(" Desconto padrão do Vale Transporte R$" + (salario * 0.12));
    }
    


}