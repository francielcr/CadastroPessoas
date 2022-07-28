using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)){//TryParse tenta converter e colocar na saida out
                //Console.WriteLine($"{dataConvertida}");
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays/365;
                if (anos>=18){
                    return true;
                }
                return false;
            }
            return false;
                
        }            
           
    }
}