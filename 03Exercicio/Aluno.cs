using System;

class Aluno
{

    // Atributos
    public string nome;
    public double nota1, nota2;


    // Média
    public  double media()
    {
        return (nota1+nota2)/2;
    } 

    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "reprovado";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter a situação
        string obterSituação = situacao(obterMedia);

        // Mensagem
        Console.WriteLine($"{nome} está {obterSituação} com media {obterMedia}.");
    }

}