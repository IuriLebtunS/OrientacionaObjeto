using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine(" Desconto padrão do Vale alimentação R$" + (salario * 0.1));
    }

    public virtual void ValeTransporte(double salario)
    {
        Console.WriteLine(" Desconto padrão do Vale Transporte R$" + (salario * 0.06));
    }
    
}