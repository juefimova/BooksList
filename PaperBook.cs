using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69003_Yuliya_Yafimava_T6
{
    class PaperBook : Book
    {
        private string _isbn;
        private int _pages;


        public PaperBook(string title, string author, string category, string type, string isbn, int pages) :
           base(title, author, category, "Paper Book")
        {
            Isbn = isbn;
            Pages = pages;
        }
        
        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if((value.Length > 0) && (!String.IsNullOrEmpty(value.Trim())))
                {
                    _isbn = value;
                } else
                {
                    throw new Exception("ISBN cannot be empty");
                }
            }
        }

        public int Pages { 
            get { return _pages; }
            set
            {
                if(value > 0)
                {
                    _pages = value;
                } else
                {
                    throw new Exception("Number of pages cannot be less than 0");
                }
            }
        
        }

        public override string GetData()
        {
            return $"{base.GetData()}|{Isbn}|{Pages}";
        }
    }
}
