using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Drugs:Object
    {
        int cost;
        int numbofpack;
        public override string AsText()
        {
            return ID + " : " + Name + "  Произведено компанией: " + From +" "+ "стоит " + cost + " проданно по магазинам " + numbofpack;
        }
        public int Cost
        {
            set { cost = value; }
            get { return cost; }
        }
        public int NumbOfPack
        {
            set { numbofpack = value; }
            get { return numbofpack; }
        }
        public Drugs(string name,string from,int id,int cost, int numbofpack)
        {
            Name = name; From = from; ID = id; Cost = cost;NumbOfPack = numbofpack;
        }
    }
}
