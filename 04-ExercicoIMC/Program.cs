// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola Burro Instaciemos!!!!");

Pessoa p = new Pessoa();
Console.WriteLine(" Digite seu Peso! ");
p.peso = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite sua Altura! ");
p.altura = double.Parse(Console.ReadLine());
p.mensagen();