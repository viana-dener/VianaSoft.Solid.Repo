public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public abstract decimal CalculateTax();
}

public class Book : Product
{
    public override decimal CalculateTax()
    {
        return Price * 0.05m;
    }
}

public class Electronics : Product
{
    public override decimal CalculateTax()
    {
        return Price * 0.15m;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Product book = new Book { Name = "Programming Book", Price = 30 };
        Product electronics = new Electronics { Name = "Smartphone", Price = 500 };

        Console.WriteLine($"Tax for {book.Name}: {book.CalculateTax()}");
        Console.WriteLine($"Tax for {electronics.Name}: {electronics.CalculateTax()}");
    }
}