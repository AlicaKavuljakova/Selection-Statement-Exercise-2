namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void FavSubject(string subject)
        {
            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("Numbers are fun");
                    break;
                case "english":
                    Console.WriteLine("cool");
                    break;
                case "biology":
                    Console.WriteLine("I guess you like cells");
                    break;
                case "chemistry":
                    Console.WriteLine("exciting");
                    break;
                case "pe":
                case "pt":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("exercise is good for you");
                    break;
                default:
                    Console.WriteLine($"I did not know they teach that in school");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine("What are 5 of your favorite subjects?");
                string input = Console.ReadLine();
                FavSubject(input);
                counter++;
            } while (counter < 5);
        }
    }
}