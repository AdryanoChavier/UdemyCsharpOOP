using System.Globalization;
using ProjetoPedido.Entities;
using ProjetoPedido.Entities.Enum;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


            Client client = new Client(name, email,birthDate);
            Order order = new Order(DateTime.Now,status,client); 


        
            Console.Write("How Many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n;i++){
              Console.WriteLine($"Enter #{i} item data: ");
              Console.Write("Product name: ");
              string Pname = Console.ReadLine();
              Console.Write("Product price: ");
              double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            
              Product product = new Product(Pname,price);

              Console.Write("Quantity: ");
              int quantity = int.Parse(Console.ReadLine());

            OrderItem ordemItem =  new OrderItem(quantity,price,product);
              

              order.AddItem(ordemItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}