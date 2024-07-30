using FestaDelivery.DTO;

namespace FestaDelivery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<User> Users = new List<User>();
        public static List<Produto> Produtos = new List<Produto>();
        public static List<Pedido> Pedidos = new List<Pedido>();
        public static List<Carrinho> Carrinhos = new List<Carrinho>();
        public static User currentUser;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InicializarDadosFicticios();
            Application.Run(new FormLogin());
        }
        static void InicializarDadosFicticios()
        {
            Users.Add(new User(1, "Admin User", "Admin", "admin@teste.com", "admin123"));
            Users.Add(new User(2, "Cliente User", "Cliente", "cliente@teste.com", "cliente1"));

            Carrinhos.Add(new Carrinho(2, true, 0));

            Produtos.Add(new Produto(1, "Salgados", "Coxinha de Frango", "Coxinha Com Recheio de Frango", 1.0, 1000));
            Produtos.Add(new Produto(2, "Salgados", "Bolinha de Queijo", "Bolinha Com Recheio de Queijo", 1.5, 1000));
            Produtos.Add(new Produto(3, "Salgados", "Enrolado de Presunto e Queijo", "Enrolado Com Recheio de Presunto e Queijo", 2.0, 200));
            Produtos.Add(new Produto(4, "Doces", "Brigadeiro", "Brigadeiro de Chocolate", 0.25, 3500));
            Produtos.Add(new Produto(5, "Doces", "Brigadeiro de Leite Ninho", "Brigadeiro feito com leite ninho e uva", 0.50, 2000));
            Produtos.Add(new Produto(6, "Doces", "Fatia de Pudim", "Fatia 50g", 3.5, 100));
            Produtos.Add(new Produto(7, "Doces", "Pudim", "Pudim completo", 10, 20));

            Produtos.Add(new Produto(8, "Doces", "Bolo Red Velvet", "Bolo de 1Kg", 100, 100));


            var pedido1 = new Pedido(1, 2, DateTime.Now, 1.0, "Pendente");
            pedido1.Produtos.Add(new ItemPedido(1, 1, 1));

            var pedido2 = new Pedido(2, 2, DateTime.Now, 5, "Pendente");
            pedido2.Produtos.Add(new ItemPedido(2, 1, 2));
            pedido2.Produtos.Add(new ItemPedido(2, 2, 2));

            Pedidos.Add(pedido1);
            Pedidos.Add(pedido2);

            // Atualizar os produtos para refletir a relação muitos-para-muitos
            foreach (var pedido in Pedidos)
            {
                foreach (var itemPedido in pedido.Produtos)
                {
                    var produto = Produtos.Find(p => p.Id == itemPedido.ProdutoId);
                    if (produto != null)
                    {
                        produto.Pedidos.Add(itemPedido);
                    }
                }
            }
        }
    }
}