using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Readers : Object
    {
        string bookshave;
        public string BooksHave
        {
            get { return bookshave; }
            set { bookshave = value; }
        }
        public Readers(string name,string from,int id,string bookshave)
        {
            Name = name; From = from; ID = id; BooksHave = BooksHave;
        }
    }
}
