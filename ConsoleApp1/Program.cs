using System;

namespace Open_Lab__10._03
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Lotr.Title = "Lord of the Rings";
            Lotr.Pages = 458;
            Lotr.Category = "fantast";
            Lotr.Autor = "J.R.R. Tolkien";
            Lotr.ReleaseDate = 1954;
            Lotr.WriteParameters();


        }

        class Book
        {
            public string Title { get; set; }
            public string Category { get; set; }
            public string Autor { get; set; }


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
}
