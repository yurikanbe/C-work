namespace ShoppingApp;

class ItemList
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<ItemList> items = new List<ItemList>();
        Readitems(items);
    }

    static void Readitems(List<ItemList> items)
    {
        while (true)
        {
            Console.WriteLine("商品を入力してください,終了する場合はおわりと入力してください");
            string? item = Console.ReadLine();
            if (item == null)
            {
                Console.WriteLine("文字を入力してください");
                return;
            }
            if (item == "おわり")
            {
                Subtotal(items);
                break;
            }
            
            Console.WriteLine("価格を入力してください");
            string? price = Console.ReadLine();
            if (price == null || !int.TryParse(price, out int priceInt) || priceInt <= 0)
            {
                Console.WriteLine("数字を入力してください");
                return;
            }
            
            Console.WriteLine("数量を入力してください");
            string? quantity = Console.ReadLine();
            if (quantity == null || !int.TryParse(quantity, out int quantityInt) || quantityInt <= 0)
            {
                Console.WriteLine("数字を入力してください");
                return;
            }
            
            ItemList entry = new ItemList();
            entry.Name = item;
            entry.Price = priceInt;
            entry.Quantity = quantityInt;
            items.Add(entry);
        }

    }

    static void Subtotal(List<ItemList> items)
    {
        int total = 0;
        foreach (ItemList item in items)
        {
            int subtotal = item.Price * item.Quantity;
            total += subtotal;
            Console.WriteLine($"{item.Name} {item.Price}円 x {item.Quantity} = {subtotal}円");
        }
        Console.WriteLine($"合計金額: {total}円");
    }

}
