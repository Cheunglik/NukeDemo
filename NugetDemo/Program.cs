using NukeDemo;

namespace NugetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var test = "1/2";
            var value = test.ParseToDouble();
            Console.WriteLine($"{test} value :{value}");
        }
    }
}
