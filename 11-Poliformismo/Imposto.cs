using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine(" Desconto padrão do Vale alimentação R$" + (salario * 0.1));
    }

    public void ValeTransporte(double salario)
    {
        Console.WriteLine(" Desconto padrão do Vale alimentação R$" + (salario * 0.06));
    }
    
}