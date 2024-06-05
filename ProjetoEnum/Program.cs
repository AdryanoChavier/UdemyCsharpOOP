using System;
using ProjetoEnum.Entities;
using ProjetoEnum.Entities.Enum;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id=1080,
                Moment = DateTime.Now,
                Status= ProjetoEnum.Entities.Enum.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }       
}