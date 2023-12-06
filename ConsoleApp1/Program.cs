// See https://aka.ms/new-console-template for more information
using ConsoleApp1.SOLID;

Console.WriteLine("Hello, World!");
//List<string> strings = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne", "Maximilian" };

//for (int i = 0; i < strings.Count; i++)
//{
//    if (strings[i].Length >= strings.Count)
//    {
//        Console.WriteLine(strings[i]);
//    }
//}

//for (int i = 2; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine( "even nums " + i);
//    } 
//}

//void Even (int a, int b)
//{
//   if   (a % 2 == 0 || b % 2 == 0)
//    {
//        if (a >=2 || a <= 100 && b <=2 || b <=100)
//        {
//            if(a == b)
//            {
//                Console.WriteLine("true");
//            }
//            else
//            {
//                Console.WriteLine("False");
//            }
//        }
//    }
//}

//Even(2, 3);
//Console.WriteLine();


Rectangle rectangle = new Square();
rectangle.Width = 10;
rectangle.Height = 5;
var test = Calculate.CalculateArea(rectangle);
Console.WriteLine(test);