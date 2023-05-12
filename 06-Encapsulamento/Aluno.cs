using System;

class Aluno
{
    // Atributos
    private double nota1, nota2;

    // Media

    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    // Mensagem
    public void mensagem()
    {
        Console.WriteLine(" digite a sua primeira nota! ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" digite a sua segunda nota! ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" A media é " + media() );
    }

}