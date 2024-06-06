namespace ProjetoPedido.Entities;
using System.Globalization;
public class OrderItem
{
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product{ get; set; }
    public OrderItem(){
    }
    public OrderItem(int quantity, double price, Product product){
        Quantity = quantity;
        Price = price;
        Product = product;
    }
    
    public OrderItem(int quantity){
        Quantity = quantity;
       
    }
    public double SubTotal(){
        return Quantity * Price;
    }
    public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


}
