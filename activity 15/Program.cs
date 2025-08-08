internal class Program
{
    private static void Main(string[] args)
    {
        List<string> courses = new List<string>();
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Enter course code: ");
            string code = Console.ReadLine();
            if (code.Length != 5)
            {
                Console.WriteLine("Error: Course code must be 5 characters.");
                continue;
            }
            if (courses.Contains(code))
            {
                Console.WriteLine("Error: Duplicate course code.");
            }
            else
            {
                courses.Add(code);
            }
        }
    }
}