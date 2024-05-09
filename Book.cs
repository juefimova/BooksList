using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69003_Yuliya_Yafimava_T6
{
    class Book
    {
        private string _title;
        private string _author;
        private string _category;
        private string _type;

        public Book(string title, string author, string category, string type)
        {
            Title = title;
            Author = author;
            Category = category;
            Type = type;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if ((value.Length > 0) && (!String.IsNullOrEmpty(value.Trim())))
                {
                    _title = value;
                }
                else
                {
                    throw new Exception("The book name cannot be empty");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if((value.Length > 0) && (!String.IsNullOrEmpty(value.Trim())))
                {
                    _author = value;
                }
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                if((value.Length > 0) && (!String.IsNullOrEmpty(value.Trim()))) {
                    _category = value;
                }
            }
        }

        public string Type
        {
            get { return _type; }

            set { _type = value; }
            
        }

        public virtual string GetData()
        {
            return $"{Title}|{Author}|{Category}|{Type}";
        }
    }
}
