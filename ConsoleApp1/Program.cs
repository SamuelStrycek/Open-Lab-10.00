using System;

namespace OpenLab1005;

class Program
{

    static void Main(string[] args)
    {
        Book Lotr = new Book();
        Book Lotr2 = new Book();
        Book Lotr3 = new Book("Lord of the Rings 3", 420);
        Book Hobbit = new Book("Hobbit", 289, "Tolkien", "Fantasy", 1938);
        Lotr.Title = "Lord of the Rings";
        Lotr.Pages = 458;
        Lotr.Category = "fantast";
        Lotr.Autor = "J.R.R. Tolkien";
        Lotr.ReleaseDate = 1954;
        Lotr.WriteParameters();

    }

    class Book
    {
        /// <summary>
        /// created list with categories
        /// <summary>
        public static List<string> categorylist = new List<string>
            {"detské", "romantické", "náučné", "sci-fi", "dobrodružné"};



        public string Title { get; set; }
        public string Category { private get; set; }
        public string Autor { get; set; }
        public Book()
        {
            Title = "-1";
            Pages = -1;
            Autor = "-1";
            Category = "-1";
            ReleaseDate = -1;
        }
        public Book(string titleAtC, int pagesAtC)
        {
            Title = titleAtC;
            Pages = pagesAtC;
            Autor = "-1";
            Category = "-1";
            ReleaseDate = -1;
        }
        public Book(string titleAtC, int pagesAtc, string AutorAtC, string CategoryAtC, int RealeaseDateAtC)
        {
            Title = titleAtC;
            Pages = pagesAtc;
            Autor = AutorAtC;
            Category = CategoryAtC;
            ReleaseDate = RealeaseDateAtC;



        }


        private int pages;
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }

        private int releaseDate;
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1450 && value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }

        public void WriteParameters()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Pages);
            Console.WriteLine(Category);
            Console.WriteLine(Autor);
            Console.WriteLine(ReleaseDate);


        }
    }

}
