namespace FestaDelivery.DTO
{
    public class User
    {
        private int _id;
        private string _nome;
        private string _tipo;
        private string _email;
        private string _senha;
        private string? _endereco;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public User(int id, string nome, string tipo, string email, string senha, string? endereco = null)
        {
            _id = id;
            _nome = nome;
            _tipo = tipo;
            _email = email;
            _senha = senha;
            _endereco = endereco;
        }
    }
}
