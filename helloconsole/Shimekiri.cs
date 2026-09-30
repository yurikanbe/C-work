using System.Drawing;

namespace MyApp;

class Shimekirimajika
{
//     static void Main(string[] args)
//     {

//         List<int> score = new List<int>();
//         int a = ReadInt("点数を入力してください(終了は-1)");
//         while (a >= 0)
//         {
//             score.Add(a);
//             a = ReadInt("点数を入力してください（終了は-1)");

//         }
//         int count = score.Count;
//         if (count == 0)
//         {
//             Console.WriteLine("点数が入力されていません");
//             return;
//         }
//         double max = Maxcheck(score);
//         double average = Average(score);
//         Console.WriteLine("人数" + count);
//         Console.WriteLine("最大点数" + max);
//         Console.WriteLine("平均" + average);
//     }

//     static int ReadInt(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             string? input = Console.ReadLine();
//             if (!int.TryParse(input, out int output))
//             {
//                 Console.WriteLine("整数を入力してください");
//             }
//             else
//             {
//                 return output;
//             }
//         }
//     }
//     static double Average(List<int> score)
//     {

//         int sum = 0;
//         foreach (int point in score)
//         {
//             sum += point;
//         }
//         return (double)sum / score.Count;
//     }
//     static double Maxcheck(List<int> score)
//     {
//         int max = 0;
//         foreach (int cheke in score)
//         {
//             if (max < cheke)
//             {
//                 max = cheke;
//             }
//         }
//         return max;
//     }
}
