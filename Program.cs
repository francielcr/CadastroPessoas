﻿// See https://aka.ms/new-console-template for more information


using CadastroPessoas.Classes;

Console.WriteLine(@$"
=========================================================================================================
|                                     Bem vindo ao sistema de cadastro de                                |
|                                         Pessoas Físicas e jurídicas                                    |
=========================================================================================================

");

BarraCarregamento("Carregando", 100);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();

    Console.WriteLine(@$"
    =========================================================================================================
    |                                        Escolha uma das opções a seguir                                 |
    |________________________________________________________________________________________________________|
    |                                                                                                        |
    |                                               1 - Pessoa Física                                        |
    |                                               2 - Pessoa Jurídica                                      |
    |                                                                                                        |
    |                                               0 - Sair                                                 |
    |                                                                                                        |
    =========================================================================================================
    ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            =========================================================================================================
            |                                        Escolha uma das opções a seguir                                 |
            |________________________________________________________________________________________________________|
            |                                                                                                        |
            |                                        1 - Cadastrar Pessoa Física                                     |
            |                                        2 - Mostrar Pessoa Física                                       |
            |                                                                                                        |
            |                                               0 - Sair                                                 |
            |                                                                                                        |
            =========================================================================================================
            ");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");               
                        novaPf.nome = Console.ReadLine();

                        /*
                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento ex.: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);

                            if (dataValida){
                                novaPf.dataNascimento = dataNasc;
                            }
                            else{
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é inválida, por favor digite uma data válida");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);
                        
                        
                        */
                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();
                        /*
                        Console.WriteLine($"Digite o rendimento mensal (apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEnd.numero = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"Digite o complemento(Aperte ENTER para vazio)");
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.WriteLine($"Este endereço é comercial? 'S' ou 'N'");
                        string endCom = Console.ReadLine().ToUpper();
                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;
                        }
                        else
                        {
                            novoEnd.endComercial = false;
                        }

                        novaPf.endereco = novoEnd;

                        //listaPf.Add(novaPf);
                        */

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine($"{novaPf.nome}");
                            sw.WriteLine($"{novaPf.cpf}");
                        }
                        ;

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        break;
                    case "2":
                        Console.Clear();
                            /*
                            if (listaPf.Count > 0){
                                foreach (PessoaFisica cadaPessoa in listaPf)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                    Data de Nascimento: {cadaPessoa.dataNascimento}
                                    Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                    ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                                }
                            }
                            else{
                                Console.WriteLine($"Lista Vazia!!!");
                                Thread.Sleep(3000);
                            }
                            */
                        using (StreamReader sr = new StreamReader($"Luiz.txt"))
                        {
                            String linha;
                            while ((linha = sr.ReadLine())!= null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                            Console.WriteLine($"Aperte 'Enter' para continuar...");
                            Console.ReadLine();
                        }
                        ;   
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                    break;
                
                }
            } while (opcaoPf != "0");
            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            
            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            =========================================================================================================
            |                                        Escolha uma das opções a seguir                                 |
            |________________________________________________________________________________________________________|
            |                                                                                                        |
            |                                        1 - Cadastrar Pessoa Juridica                                   |
            |                                        2 - Mostrar Pessoa Juridica                                     |
            |                                                                                                        |
            |                                               0 - Sair                                                 |
            |                                                                                                        |
            =========================================================================================================
            ");
                opcaoPj = Console.ReadLine();
                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa juridica que deseja cadastrar");               
                        novaPj.nome = Console.ReadLine();

                        //Console.WriteLine($"Digite o numero do cnpj"); 
                        //novaPj.cnpj = Console.ReadLine();

                        bool cnpjValido;

                        do
                        {
                            Console.WriteLine($"Digite o CNPJ");
                            string cnpj = Console.ReadLine();

                            cnpjValido = metodoPj.ValidarCnpj(cnpj);
                            //ValidarDataNascimento(dataNasc);

                            if (cnpjValido){
                                novaPj.cnpj = cnpj;
                            }
                            else{
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Cnpj inválido, por favor digite uma data válida");
                                Console.ResetColor();
                            }
                        } while (cnpjValido == false);



                        Console.WriteLine($"Digite a razão social da empresa");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento");
                        novoEndPj.complemento = Console.ReadLine();

                       Console.WriteLine($"Este endereço é comercial? 'S' ou 'N'");
                        string endCom = Console.ReadLine().ToUpper();
                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }
                        novaPj.endereco = novoEndPj;
                        listaPj.Add(novaPj);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(4000);

                        metodoPj.Inserir(novaPj);
                    break;
                    
                   
                    case "2":
                        Console.Clear();
                        List<PessoaJuridica>ListaPj = metodoPj.Ler();
                        //foreach (PessoaJuridica cadaPessoa in listaPj)
                        foreach (PessoaJuridica cadaItem in listaPj)

                            {
                                    Console.Clear();
                                    Console.WriteLine(@$"
                                    Nome: {cadaItem.nome}
                                    Razao Social: {cadaItem.razaoSocial}
                                    CNPJ: {cadaItem.cnpj}
                                    ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }

                            //if (listaPj.Count > 0){
                                
                                /*{
                                    Console.Clear();
                                    Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                    Razao Social: {cadaPessoa.razaoSocial}
                                    CNPJ: {cadaPessoa.cnpj}
                                    CNPJ é valido: {(metodoPj.ValidarCnpj(cadaPessoa.cnpj)? "sim": "Não")}
                                    
                                    Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                    ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                                }
                           }
                            else{
                                Console.WriteLine($"Lista Vazia!!!");
                                Thread.Sleep(3000);
                            }*/

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                    break;
                    
                }
            }while (opcaoPj != "0");

        

            break;




        /*
         
            novoEndPj.numero = 539;
            novoEndPj.complemento = "Senai Informatica";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;
            Console.WriteLine(@$"
                nome: {novaPj.nome}
                Razao Social: {novaPj.razaoSocial}
                CNPJ: {novaPj.cnpj}
                CNPJ é valido: {(metodoPj.ValidarCnpj(novaPj.cnpj)? "sim": "Não")}
                Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
                ");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        */
        
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");         
            BarraCarregamento("Finalizando", 200);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(3000);
            break;
    }   
}while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
     Console.BackgroundColor = ConsoleColor.White;
     Console.ForegroundColor = ConsoleColor.Black;
     Console.Write($"{texto}");
     for (var contador = 0; contador < 47; contador++)
        {
        Console.Write(". ");
        Thread.Sleep(tempo);
        }
    Console.ResetColor();
}

/*

*/



/*
novaPf.nome = "Franciel";
Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/
//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime("01,01,2000")));
//Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));

/*

*/