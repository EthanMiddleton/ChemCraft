using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemCraft
{
    public class Deck
    { 
        Random RandomNumber = new Random();

        List<Element> list = new List<Element>(); 

        public int CurrentCard;
        public const int AmountofCards = 100;
       

        public Deck()
        {
            for (int i = 0; i < 26; i++)
            {
                list.Add(new Hydrogen());
                list[i].ID = i;
            }
            for (int a = 26; a < 52; a++)
            {
                list.Add(new Oxygen());
                list[a].ID = a;
            }
        }

        public List<Element> List{
            set { list = value; }
            get { return list;  }
        }
    }
}
    
