var products = new Repository<Product>();
var customers = new Repository<Customer>();

Console.WriteLine("Добавление двух товаров");
for (int id = 1; id <= 2; id++)
{
    Console.Write($"Название товара с Id {id}: ");
    string name = Console.ReadLine() ?? "";
    products.Add(new Product { Id = id, Name = name });
}

Console.WriteLine("Добавление двух покупателей");
for (int id = 1; id <= 2; id++)
{
    Console.Write($"Email покупателя с Id {id}: ");
    string email = Console.ReadLine() ?? "";
    customers.Add(new Customer { Id = id, Email = email });
}

Console.Write("Введите Id товара для поиска: ");
int productId = ReadId();
Product? product = products.GetById(productId);

if (product != null)
{
    Console.WriteLine($"Найден товар: Id {product.Id}, {product.Name}");
}
else
{
    Console.WriteLine("Товар не найден");
}

Console.Write("Введите Id покупателя для поиска: ");
int customerId = ReadId();
Customer? customer = customers.GetById(customerId);

if (customer != null)
{
    Console.WriteLine($"Найден покупатель: Id {customer.Id}, {customer.Email}");
}
else
{
    Console.WriteLine("Покупатель не найден");
}

Console.WriteLine("Проверка отсутствующего Id 0:");
Console.WriteLine($"Товары: GetById(0) == null: {products.GetById(0) == null}");
Console.WriteLine($"Покупатели: GetById(0) == null: {customers.GetById(0) == null}");

int ReadId()
{
    int id;
    while (!int.TryParse(Console.ReadLine(), out id))
    {
        Console.Write("Введите целое число: ");
    }

    return id;
}
