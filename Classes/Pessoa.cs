using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public string ?endereco { get; set; }
        public string ?rendimento { get; set; }

                        
        public abstract float PagarImposto(float rendimento);
    }
}