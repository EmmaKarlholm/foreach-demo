namespace foreach_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foods = ["pizza", "kebab", "kebab pizza", "curry", "falafel"];

            foreach (string dish in foods)
            {
                Console.WriteLine($"I love {dish}!");
            }
            // Note how short and simple that foreach loop is! It goes through all elements in foods and loops
            // with no need of using any index (i) variables or anything like that. It applies logic using
            // every element in an array or list.
        }
    }
}
