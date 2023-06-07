using System.Text;

namespace _05_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strT = "hello";
            strT += ", world";

            var b = new StringBuilder();

            Console.WriteLine("Cap: " + b.Capacity);
            b.Append(12345678901627345);

            Console.WriteLine("String length: {0}", b.Length);
            Console.WriteLine("String capacity: {0}", b.Capacity);  //memmory used
            Console.WriteLine("Value: {0}", b.ToString());
            Console.WriteLine();
            Console.ReadKey();

            var sb = new StringBuilder("Hello world!");
            Console.WriteLine("String length: {0}", sb.Length);
            Console.WriteLine("String capacity: {0}", sb.Capacity);  //memmory used

            sb.Append("bla");
            sb.Append("bla");
            sb.Append("bla");
            sb.AppendLine();
            //sb.Append('\n');
            sb.Append("bla");
            sb.Append("bla");

            Console.WriteLine("String length: {0}", sb.Length);
            Console.WriteLine("String capacity: {0}", sb.Capacity);  //memmory used
            Console.ReadKey();

            StringBuilder sb1 = new StringBuilder(20);
            Console.WriteLine("String length: {0}", sb1.Length);
            Console.WriteLine("String capacity: {0}", sb1.Capacity);  //memmory used

            sb1.Append("bla");
            sb1.Append("bla");
            sb1.Append("bla");
            sb1.AppendLine();
            sb1.AppendLine();
            sb1.Append("bla");
            sb1.Append("bla");
            sb1.Append("bla");

            Console.WriteLine("String length: {0}", sb1.Length);
            Console.WriteLine("String capacity: {0}", sb1.Capacity);  //memmory used

            string result = sb1.ToString();
            Console.WriteLine(result);

            Console.WriteLine($"MachineName: {Environment.MachineName}");
            Console.WriteLine($"UserName: {Environment.UserName}");
            Console.WriteLine($"OSVersion: {Environment.OSVersion}");
            Console.WriteLine($"CommandLine: {Environment.CommandLine}");
            Console.WriteLine($"Desktop Path: {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}");

            Console.ReadKey();
        }
    }
}