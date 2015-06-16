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
            for (int i = 0; i < 100; i++)
            {
                int slot = RandomNumber.Next(300);
                if (slot >= 0 && slot < 50)
                {
                    list.Add(new Hydrogen());
                }
                if (slot >= 50 && slot < 80)
                {
                    list.Add(new Helium());
                }
                if (slot >= 80 && slot < 110)
                {
                    list.Add(new Lithium());
                }
                if (slot >= 110 && slot < 150)
                {
                    list.Add(new Beryllium());
                }
                if (slot >= 150 && slot < 190)
                {
                    list.Add(new Boron());
                }
                if (slot >= 190 && slot < 200)
                {
                    list.Add(new Carbon());
                }
                if (slot >= 200 && slot < 230)
                {
                    list.Add(new Nitrogen());
                }
                if (slot >= 230 && slot < 280)
                {
                    list.Add(new Oxygen());
                }
                if (slot >= 280 && slot < 300)
                {
                    list.Add(new Fluorine());
                }
                list[i].ID = i;
            }
        }

        public List<Element> List{
            set { list = value; }
            get { return list;  }
        }
    }
}
    
