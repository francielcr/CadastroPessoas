// See https://aka.ms/new-console-template for more information

using CadastroPessoas.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Franciel";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");

