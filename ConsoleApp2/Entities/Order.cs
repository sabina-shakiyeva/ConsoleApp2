namespace ConsoleApp2.Entities;

public class Order
{
    public int Id { get; set; }
    public string Adress { get; set; }

    public ICollection<Product> Products { get; set;}

}
