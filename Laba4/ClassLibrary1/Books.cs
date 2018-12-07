using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Books : Object
    {
        string yearofpubl;
        string type;
        int numbofpage;
        public override string AsText()
        {
            return ID + " : "+ Name  + " Автор :"+ From +" написанно в " + Yearofpubl + " "+Type+" Произведение "+ NumbOfPage+" страниц";
        }
        public string Yearofpubl
        {
            get { return yearofpubl; }
            set { yearofpubl = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int NumbOfPage
        {
            get { return numbofpage; }
            set { numbofpage = value; }
        }
        public Books(int id,string name,string from,string year,string type,int numbofpage)
        {
            ID = id; Name = name; From = from; Yearofpubl = year; Type = type; NumbOfPage = numbofpage;
        }
    }
}
