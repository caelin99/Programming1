namespace Opgave2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            string text = "";
            string mostLetters = "";
            int mostCount = 0;
            int count = 0;
            do
            {
                Console.Write($"Enter a text (stop to finish): ");
                text = Console.ReadLine();
                if (text.ToLower() == "stop")
                {
                    Console.WriteLine($"Text with most letters: {mostLetters} ({mostCount} letters)");
                    break;
                }

                count = CountLetters(text);
                Console.WriteLine($"{text} has {count} letters.");

                if (count > mostCount)
                {
                    mostCount = count;
                    mostLetters = text;
                }
                
            } while (text != "stop");
        }

        public int CountLetters(string text)
        {
            int count = 0;
            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
