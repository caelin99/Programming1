namespace Assignment4
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
            Console.Write("Enter book title: ");
            string readTitle = Console.ReadLine();
            Console.Write("Enter book author: ");
            string readAuthor = Console.ReadLine();
            Book book = new Book(readTitle, readAuthor);
            book.DisplayBookInfo();
        }
    }
}
