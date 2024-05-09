using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _69003_Yuliya_Yafimava_T6
{
    class Library
    {
        public static List<Book> books = new List<Book>();
        private static string FilePath = "Books.txt";



        public static void WriteBook(string title, string author, string category, string type, string firstParametr, int secondParamentr)
        {
            string data = "";
            switch(type)
            {
                case "Paper Book":
                    PaperBook paperBook = new PaperBook(title, author, category, type, firstParametr, secondParamentr);
                    books.Add(paperBook);
                    data = paperBook.GetData();
                    break;

                case "E-Book":
                    EBook eBook = new EBook(title, author, category, type, firstParametr, secondParamentr);
                    data = eBook.GetData();
                    books.Add(eBook);
                    break;

                case "Audio Book":
                    AudioBook audioBook = new AudioBook(title, author, category, type, firstParametr, secondParamentr);
                    data = audioBook.GetData();
                    books.Add(audioBook);
                    break;
            }

            StreamWriter streamWriter = new StreamWriter("Books.txt", true);
            streamWriter.WriteLine(data);
            streamWriter.Close();


        }


        public static void WriteBooksToFile()
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (Book book in books)
                    {
                        writer.WriteLine(BookToLine(book));
                    }
                }
                Console.WriteLine("Books successfully written to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        private static string BookToLine(Book book)
        {
            string type = "";

            if (book is PaperBook)
            {
                type = "Paper";
                PaperBook paperBook = (PaperBook)book;
                return $"{type}\t{book.Title}\t{book.Author}\t{book.Category}\t{paperBook.Isbn}\t{paperBook.Pages}";
            }
            else if (book is EBook)
            {
                type = "E-Book";
                EBook eBook = (EBook)book;
                return $"{type}\t{book.Title}\t{book.Author}\t{book.Category}\t{eBook.Format}\t{eBook.Size}";
            }
            else if (book is AudioBook)
            {
                type = "Audio";
                AudioBook audioBook = (AudioBook)book;
                return $"{type}\t{book.Title}\t{book.Author}\t{book.Category}\t{audioBook.Narrator}\t{audioBook.Duration}";
            }

            return "";
        }


   
        public static void DeleteBook(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books.RemoveAt(index);
                SaveChangesToFile();
            }
        }


        private static void SaveChangesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (Book book in books)
                    {
                        writer.WriteLine(book.GetData());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }



    }

    
}

