Console.Write("Введите количество товаров:");
int n = int.Parse(Console.ReadLine());
Product[] products = new Product[n];
decimal[] cost = new decimal[n]; 
try
{
    for (int i = 0; i < products.Length; i++)
    {
        Console.WriteLine($"Введите данные об {i + 1} товаре:");
        Console.Write("Введите наименование товара:");
        products[i].name = Console.ReadLine();
        Console.Write("Введите количество товара:");
        products[i].count = int.Parse(Console.ReadLine());
        Console.Write("Введите цену товара:");
        products[i].price = decimal.Parse(Console.ReadLine());
        Console.Write("Введите производителя товара:");
        products[i].manufactor = Console.ReadLine();
        Console.Write("Введите дату выпуска товара:");
        products[i].date = DateTime.Parse(Console.ReadLine());
        
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
decimal x = 0;
foreach (Product product in products)
{
    int i = 0;
    x+= product.price * product.count;
    cost[i] = x;
    i++;
    x = 0;
}
decimal max = cost[0];
int index1 = 0;
for (int i = 1; i < cost.Length; i++)
    if (cost[i] > max)
    {
        max = cost[i];
        index1 = i;
    }
string maxname;
foreach (Product product in products)
{
    if (max == product.price * product.count)
    {
        maxname=product.name;
        Console.WriteLine($"Товар с максимальной общей стоимостью: {maxname} . Общая стоимость товара: {max}");
    }
}
struct Product
{
    public string name;
    public string manufactor;
    public DateTime date;
    public int count;
    public decimal price;
}