internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}

struct Check
{
    Adress a;
    DateOnly date;
    DateTime time;
    List<Product> p;
    int commision;
    int sum;
    public Check()
    {
        a = new Adress();
        date = new DateOnly();
        time = new DateTime();
        p = new List<Product>(0);
        commision = 0;
        sum = 0;
    }
    void AddProduct()
    { 
        Console.WriteLine("Enter the nane of a product");
        string s = Console.ReadLine();
        Console.WriteLine("Enter the price of a product");
        int prc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the amount of this product");
        int a = Convert.ToInt32(Console.ReadLine());
        Product pr = new Product(s, prc, a, 0);
        p.Add(pr);
        CountSum();
    }
    void ShowProducts()
    {
        for (int i = 0; i < p.Count; i++)
        {
            p[i].Print();
        }
    }
    void CountSum()
    {
        sum = 0;
        for(int i = 0; i < p.Count; i++)
        {
            sum += p[i].GetPrice();
        }
        sum += sum/100*commision;
    }
    void Print()
    {
        Console.WriteLine("Place: ", a);
        Console.WriteLine("Date: ", date, " ", time);
        ShowProducts();
        Console.WriteLine("Commision: ", commision);
        Console.WriteLine("Sum: ", sum);
    }
}

class Adress
{
    string city;
    string district;
    string street;
    int houseNum;

    public Adress()
    {
        city = "";
        district = "";
        street = "";
        houseNum = 0;
    }
    public void Init()
    {
        city = Console.ReadLine();
        district = Console.ReadLine();
        street = Console.ReadLine();
        houseNum = Convert.ToInt32(Console.ReadLine());
    }
}

class Product
{
    string name;
    int price;
    int amount;
    int discount;
    public Product()
    {
        name = "";
        price = 0;
        amount = 0;
        discount = 0;
    }
    public Product(string n, int p, int a, int d)
    {
        name = n;
        amount = a;
        if (d <= 0) discount = 0;
        else if (d >= 100) discount = 0;
        else discount = d;
        price = p - p/100*discount;
    }
    public void Print()
    {
        Console.WriteLine("Name: ", name);
        Console.WriteLine("Price: ", price);
        Console.WriteLine("Amount: ", amount);
        Console.WriteLine("Discount: ", discount, "%\n");
    }
    public int GetPrice()
    {
        return price;
    }

}