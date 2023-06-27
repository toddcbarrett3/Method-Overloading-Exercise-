namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(1, 0));
            Console.WriteLine(Methods.Add(1.65, 8.23));
            Console.WriteLine(Methods.Add(1, 0, true));
        }
    }
}
