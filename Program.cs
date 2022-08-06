// See https://aka.ms/new-console-template for more information


using CadastroPessoas.Classes;
/*
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
*/



/*
novaPf.nome = "Franciel";
Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/
//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime("01,01,2000")));
//Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));


PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
novaPj.cnpj = "00000000000000";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.Numero = 539;
novoEndPj.complemento = "Senai Informatica";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}

");
