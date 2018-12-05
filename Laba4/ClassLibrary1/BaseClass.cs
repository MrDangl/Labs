using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Object
    {
        string name;
        int id;
        string from;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string From
        {
            set { from = value; }
            get { return from; }
        }
    }
}
