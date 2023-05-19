using System;

namespace _11Poliformismo
{
    class program
    {

        static void Main(string[] args)
        {
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.ValeTransporte(1000);
            Console.WriteLine("----------------------------------");

            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.ValeTransporte(5000);
            Console.WriteLine("----------------------------------");

            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.ValeTransporte(2000);
            Console.WriteLine("----------------------------------");


        }

    }

}