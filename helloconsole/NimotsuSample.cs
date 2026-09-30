namespace NimotsuSample;

class Parcel
{
    public string Address { get; set; } = "";
    public int Weight { get; set; }
    public int Count { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Parcel> parcels = new List<Parcel>();
        ReadParcels(parcels);
    }

    static void ReadParcels(List<Parcel> parcels)
    {
        while (true)
        {
            Console.WriteLine("宛名を入力してください。終了はおわり");
            string? address = Console.ReadLine();
            if (string.IsNullOrEmpty(address))
            {
                Console.WriteLine("宛名を入力してください");
                continue;
            }
            if (address == "おわり")
            {
                ShowTotal(parcels);
                return;
            }

            int weight = ReadPositiveInt("1個の重さ(g)を入力してください");
            int count = ReadPositiveInt("個数を入力してください");

            // ループのたびに新しい1件を作る。前に Add した荷物はそのまま残る
            Parcel parcel = new Parcel();
            parcel.Address = address;
            parcel.Weight = weight;
            parcel.Count = count;
            parcels.Add(parcel);
        }
    }

    static int ReadPositiveInt(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int number) || number <= 0)
            {
                Console.WriteLine("1以上の整数を入力してください");
                continue;
            }
            return number;
        }
    }

    static void ShowTotal(List<Parcel> parcels)
    {
        if (parcels.Count == 0)
        {
            Console.WriteLine("荷物がありません");
            return;
        }

        int total = 0;
        foreach (Parcel parcel in parcels)
        {
            int subtotal = parcel.Weight * parcel.Count;
            total += subtotal;
            Console.WriteLine($"{parcel.Address} {parcel.Weight}g x {parcel.Count} = {subtotal}g");
        }
        Console.WriteLine($"合計重量: {total}g");
    }
}
