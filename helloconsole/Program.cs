namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        int a = ReadInt("1つ目の整数: ");
        int b = ReadInt("2つ目の整数: ");
        string op = ReadOperator();

        if (op == "/" && b == 0)
        {
            Console.WriteLine("0では割れません");
            return;
        }

        int result = Calc(a, b, op);
        Console.WriteLine(result);
    }

    static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            Console.WriteLine("整数を入力してください");
        }
    }

    static string ReadOperator()
    {
        while (true)
        {
            Console.Write("演算子(+ - * /): ");
            string? input = Console.ReadLine();
            if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                return input;
            }
            Console.WriteLine("+ - * / のいずれかを入力してください");
        }
    }

    static int Calc(int a, int b, string op)
    {
        if (op == "+")
        {
            return a + b;
        }
        if (op == "-")
        {
            return a - b;
        }
        if (op == "*")
        {
            return a * b;
        }
        return a / b;
    }

    // 数字当てゲーム
    // static void Main(string[] args)
    // {
    //     int anser = Random.Shared.Next(1, 101);
    //     int count = 1;
    //
    //     Console.WriteLine("1 ~ 100までの整数を入力してください");
    //     String? input = Console.ReadLine();
    //     if (!int.TryParse(input, out int first))
    //     {
    //         Console.WriteLine("整数を入力して下さい");
    //         return;
    //     }
    //
    //     while (anser != first)
    //     {
    //         if (first < anser)
    //         {
    //             Console.WriteLine(input + "よりも大きいです");
    //             count++;
    //         }
    //         else
    //         {
    //             Console.WriteLine(input + "よりも小さいです");
    //             count++;
    //         }
    //
    //         Console.WriteLine("もう一度整数を入力してください");
    //         input = Console.ReadLine();
    //         if (!int.TryParse(input, out first))
    //         {
    //             Console.WriteLine("整数を入力して下さい");
    //             return;
    //         }
    //     }
    //
    //     Console.WriteLine("おめでとうございます！正解です");
    //     Console.WriteLine(count + "回間違えました");
    // }

    // ５の倍数の判定
    // Console.WriteLine("整数を入力してください");
    // String? input0 = Console.ReadLine();
    // if (!int.TryParse(input0, out int first))
    // {
    //     Console.WriteLine("整数を入力して下さい");
    //     return;
    // }
    // Console.WriteLine("整数を入力して下さい");
    // String? input1 = Console.ReadLine();
    // if (!int.TryParse(input1, out int second))
    // {
    //     Console.WriteLine("整数2を入力して下さい");
    //     return;
    // }
    //
    // for (int i = first; i <= second; i++)
    //     if (i % 15 == 0)
    //     {
    //         Console.WriteLine("BuzzFizz");
    //     }
    //     else if (i % 3 == 0)
    //     {
    //         Console.WriteLine("Fizz");
    //     }
    //     else if (i % 5 == 0)
    //     {
    //         Console.WriteLine("Buzz");
    //     }
    //     else
    //     {
    //         Console.WriteLine(i);
    //     }
}
