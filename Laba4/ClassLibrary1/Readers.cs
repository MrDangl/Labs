using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Readers : Object
    {
        public override string AsText()
        {
            return Name + " с "  + From + " с паспартными данными " + ID + " Взял книги с индификационными номерами " + bookshave+" ";
        }
        string bookshave;
        public string BooksHave
        {
            get { return bookshave; }
            set { bookshave = value; }
        }
        public int[] IdBooks()
        {
            string[] numb;
            numb = bookshave.Split(',');
            int[] idbook = new int[numb.Length];
            for (int i = 0; i < numb.Length; i++)
            {
                if (int.TryParse(numb[i], out idbook[i]) == true) ;
                idbook[i] = Convert.ToInt16(numb[i]);
                    }
            return idbook;
        }
        public Readers(string name,string from,int id,string bookshave)
        {
            Name = name; From = from; ID = id; BooksHave = bookshave;
        }
    }
}
