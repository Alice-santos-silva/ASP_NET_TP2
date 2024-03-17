namespace WebAppTP2.Pages
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _cpf;

        public Pessoa(string nome, int idade, string cpf)
        {
            _nome = nome;
            _idade = idade;
            _cpf = cpf;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }

}

