using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69003_Yuliya_Yafimava_T6
{
    class EBook : Book
    {
        private string _format;
        private double _size;


        public EBook(string title, string author, string category, string type, string format, int size) :
            base(title, author, category, "E-Book")
        {
            Format = format;
            Size = size;
        }
        public string Format
        {
            get { return _format; }
            set
            {
                if((value.Length > 0) && (!String.IsNullOrEmpty(value.Trim()))) {
                    _format = value;
                } else
                {
                    throw new Exception("The format of a book cannot be empty");
                }
            }
        }

        public double Size
        {
            get { return _size; }
            set
            {
                if(value > 0)
                {
                    _size = value;
                } else
                {
                    throw new Exception("The size of a book cannot be less than 0");
                }
            }
        }

        public override string GetData()
        {
            return $"{base.GetData()}|{Format}|{Size}";
        }
    }
}
