namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("country", "India");
            dictionary.Add("number", 123);
            dictionary.Add("date", DateTime.Now);
            dictionary.Add("isEmp", true);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key - {item.Key}, Value - {item.Value}");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}