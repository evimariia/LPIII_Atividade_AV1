using DunderMifflin;

class Program
{
    static void Main(string[] args)
    {
        Vendedor dwight = new Vendedor("Dwight Schrute", 0539, "999998888");
        Console.WriteLine(dwight.ToString());
        Produto FA4 = new Produto("A4", 500);
        Produto FA3 = new Produto("A3", 1000);
        Cliente bob = new Cliente(2, "Bob Vance do Refrigerações Vance", "4002-8922", "vance.bob@refrigeracoes.com", "Rua dos Bobos, 0. Squanton/Pennsylvania");
        Console.WriteLine(bob.ToString());
        Pedido p1 = new Pedido(2, "01/10/2024", 10, 3, dwight, bob, FA4);
        Console.WriteLine(p1.ToString());
    }
}
