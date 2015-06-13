using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemCraft
{
    public class Deck
    {
      //  List<Token> deck = new List<Token>();

        Hydrogen hydro = new Hydrogen();
        Helium helo = new Helium();
        Lithium lith = new Lithium();
        Beryllium bery = new Beryllium();
        Boron bor = new Boron();
        Carbon car = new Carbon();
        Nitrogen nitro = new Nitrogen();
        Oxygen oxy = new Oxygen();
        Fluorine fluoro = new Fluorine();

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
                    list.Add(hydro);
                }
                if(slot >= 50 && slot < 80)
                {
                    list.Add(helo);
                }
                if(slot >= 80 && slot < 110)
                {
                    list.Add(lith);
                }
                if(slot >= 110 && slot < 150)
                {
                    list.Add(bery);
                }
                if(slot >= 150 && slot < 190)
                {
                    list.Add(bor);
                }
                if(slot >= 190 && slot < 200)
                {
                    list.Add(car);
                }
                if(slot >= 200 && slot < 230)
                {
                    list.Add(nitro);
                }
                if(slot>= 230 && slot < 280)
                {
                    list.Add(oxy);
                }
                if(slot>= 280 && slot < 300)
                {
                    list.Add(fluoro);
                }
                
                list[i].ID = i;
            }
            // Shuffle();
        }

        public void Shuffle()
        {
            CurrentCard = 0;
            for (int first = 0; first < 100; first++)
            {
                int Second = RandomNumber.Next(AmountofCards);
                Element temp = list[first];
                list[first] = list[Second];
                list[Second] = temp;
            }
        }

        //draws a single card from the deck that hasn't previously been drawn
        private Element Draw()
        {
            //boolean that ensures you find a card that hasn't been found
            Boolean check = false;
            //random card that is selected
            Random rnd = new Random();
            //loops until card is found that hasn't bee picked
            while (check == false)
            {
                int rand = rnd.Next(52);
                if (List[rand].state == 1)
                {
                    List[rand].state = 2;
                    check = true;
                    return List[rand];
                }
            }
            return null;
        }

        public List<Element> List{
            set { list = value; }
            get { return list;  }
        }
    }
}
    
