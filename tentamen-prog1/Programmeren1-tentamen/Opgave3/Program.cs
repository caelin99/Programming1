// using System.Reflection.Metadata.Ecma335;

namespace Opgave3
{
    public class Program
    {
        int _amountFilms = 3;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            string[] filmNames = new string[_amountFilms];
            int[] filmScores = new int[_amountFilms];
            
            ReadFilms(filmNames, filmScores);
            Console.Write("Enter a film name to search for: ");
            string searchName = Console.ReadLine();
            int filmIndex = GetFilmIndex(searchName, filmNames);
            Console.WriteLine($"{filmNames[filmIndex]} has a score of {filmScores[filmIndex]}/10.");
        }

        public void ReadFilms(string[] filmNames, int[] filmScores)
        {
            for (int i = 0; i < _amountFilms; i++)
            {
                Console.Write($"Name of film {i+1}: ");
                filmNames[i] = Console.ReadLine();
                Console.Write($"Score for {filmNames[i]} (0-10): ");
                filmScores[i] = int.Parse(Console.ReadLine());
            }
        }

        public int GetFilmIndex(string filmName, string[] filmNames)
        {
            int filmIndex = 0;
            for (int i = 0; i < filmNames.Length; i++)
            {
                if (filmName == filmNames[i])
                {
                    filmIndex = i;
                }
            }

            return filmIndex;
        }
    }
}
