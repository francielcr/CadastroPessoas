using CadastroPessoas.Interfaces;
using System.Text.RegularExpressions;

namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }
        
        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        
        
        public override float PagarImposto(float rendimento)
        {
            if (rendimento<=1500){
                return (rendimento/100)*3;
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento/100)*5;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return (rendimento/100)*7;
            }
            else{
                return (rendimento/100)*9;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length ==18)
                {
                    if (cnpj.Substring(11,4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length ==14)
                {
                    if (cnpj.Substring(8,4) == "0001")
                    {
                            return true;
                    }  
                }
            }
        return false;
        }
        public void Inserir(PessoaJuridica pj)
        {
            verificarPastaArquivo(caminho);

            string[] pjstring = {$"{pj.nome},{pj.cnpj},{pj.razaoSocial}"}; 
            
            File.AppendAllLines(caminho, pjstring);
        }

        public List<PessoaJuridica> Ler(){
            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

            String[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPJ.Add(cadaPj);

            }
            return listaPJ;
        }
    
    }

}