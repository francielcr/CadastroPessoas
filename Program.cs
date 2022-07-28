// See https://aka.ms/new-console-template for more information

using CadastroPessoas.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "Luiz"; 
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678900";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Alameda Barão de Limeira";
novoEnd.Numero = 539;
novoEnd.complemento = "Senai Informatica";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.Numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}

");




/*
novaPf.nome = "Franciel";
Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/
//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime("01,01,2000")));
//Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));


