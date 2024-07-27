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
            Users.Add(new User(2, "Cliente User", "Cliente", "cliente@teste.com", "cliente123"));

            Produtos.Add(new Produto(1, "Eletrônicos", "Celular", "Smartphone", 1500.0, 10));
            Produtos.Add(new Produto(2, "Eletrônicos", "Notebook", "Laptop", 3500.0, 5));

            var pedido1 = new Pedido(1, 2, DateTime.Now, 1500.0, "Pendente");
            pedido1.Produtos.Add(new ItemPedido(1, 1, 1));

            var pedido2 = new Pedido(2, 2, DateTime.Now, 7000.0, "Pendente");
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