using System;

class Pessoa
{
    //Atributos 
    public double peso, altura;

    //Calculo 
    public double Calculo()
    {

        return peso / (altura * altura);

    }
    // Situação

    public string Situacao(double imc)
    {
        string retorno;

        if (imc <= 18.5)
        {
            retorno = " Abaixo do Peso ";
        }
        else if (imc < 25)
        {
            retorno = " Peso Normal ";
        }
        else if (imc <=30)
        {
            retorno = " Peso Normal ";
        }
        else if (imc > 35)
        {
            retorno = " Obesidade Nivel I ";
        }
        else if (imc > 40)
        {
            retorno = " Obesidade Nivel II ";
        }
        else
        {
            retorno = " Obesidade Nivel III ";
        }
        return retorno;
    }
       public void mensagen()
        {
          double obterCalculo = Calculo();
          string obterSituacao = Situacao(obterCalculo);
         
         Console.WriteLine(" Seu IMC é de "+ obterCalculo + " é sua situação e " + obterSituacao);
        }
}