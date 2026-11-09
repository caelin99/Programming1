using System.Security.Cryptography;

namespace Assignment7
{
    public class Program
    {
        char Symbol = 'X';
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start() 
        {
            Console.Write("Enter dimension size: ");
            int readDimensionSize = int.Parse(Console.ReadLine());
            PrintSquare(readDimensionSize);
        }

        public void PrintSquare(int dimensionSize)
        {
            for(int i = 1; i <= dimensionSize; i++)
            {
                for(int j = 1; j <= dimensionSize; j++)
                {
                    if(i == 1 || i == dimensionSize) Console.Write(Symbol);
                    else if(i > 1 && i < dimensionSize)
                    {
                        if (j == 1 || j == dimensionSize) Console.Write(Symbol);
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
