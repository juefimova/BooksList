using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69003_Yuliya_Yafimava_T6
{
    class AudioBook : Book
    {
        private string _narrator;
        private double _duration;

        public AudioBook(string title, string author, string category, string type, string narrator, int duration) :
            base(title, author, category, "Audio Book")
        {
            Narrator = narrator;
            Duration = duration;
        }

        public string Narrator
        {
            get { return _narrator; }
            set
            {
                if((value.Length > 0) && !String.IsNullOrEmpty(value.Trim())) {
                    _narrator = value;
                } else
                {
                    throw new Exception("The narrator cannot  be empty");
                }
            }
        }

        public double Duration
        {
            get { return _duration; }
            set
            {
                if(value > 0)
                {
                    _duration = value;
                } else
                {
                    throw new Exception("The duration of a book cannot be less than 0");
                }
            }
        }

        public override string GetData()
        {
            return $"{base.GetData()}|{Narrator}|{Duration}";
        }

    }
}
