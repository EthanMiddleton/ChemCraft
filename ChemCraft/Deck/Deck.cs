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
            int[] AtomicNumbers = new int[19];

            CurrentCard = 0;
            for (int i = 0; i < 30; i++)
                list.Add(new Hydrogen());
            for (int i = 0; i < 15; i++)
                list.Add(new Oxygen());
            for (int i = 0; i < 10; i++)
                list.Add(new Nitrogen());
            for (int i = 0; i < 5; i++)
                list.Add(new Calcium());
            for (int i = 0; i < 5; i++)
                list.Add(new Carbon());
            for (int i = 0; i < 10; i++)
                list.Add(new Sodium());
            for (int i = 0; i < 5; i++)
                list.Add(new Chlorine());

            for(int i = 0; i < list.Count; i++)
                list[i].ID = i;
        }

        public List<Element> List{
            set { list = value; }
            get { return list;  }
        }
    }
}
    
