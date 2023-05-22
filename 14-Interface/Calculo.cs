using System;

class Calculo : IPadrao
{
    public void somar(int n1, int n2)
    {
        Console.WriteLine(" A Soma e " + ( n1 + n2 ));
    }

    public void substrair(int n1,int n2)
    {
         Console.WriteLine(" A substração é " + (n1 -n2));
    }
}