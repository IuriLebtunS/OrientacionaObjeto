using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //media
    public double media()
    {
        return (nota1 + nota2) / 2;
    }
    //Situação
    public string Situacao(double media)
    {
        return media >= 7 ? " APROVADO " : " REPROVADO ";
    }
    //Mensagem
    public void Mensagem()
    {
        //Criar Variaves
        double obterMedia = media();
        string obterSituacao = Situacao(obterMedia);
        //Mensagem
        Console.WriteLine( nome + " Esta " + obterSituacao + " com uma media de " + obterMedia);
    }

}