using System;

class Pessoa
{
    //metodo 01
    public void apresentar()
    {
        Console.WriteLine("Ola!!!");
    }
    //metodo 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Ola!!" + nome);
    }
    //metodo 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine(" Ola " + nome + " você tem " + idade + " Anos ");
    }

}