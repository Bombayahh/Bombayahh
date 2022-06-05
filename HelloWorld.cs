namespace CSHARP_PROJECTS
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var CurrentDate = DateTime.Now;
            Console.WriteLine($"User name is {name},and the date is {CurrentDate:d}");
            Console.WriteLine("come on Github");
        }
    }
}