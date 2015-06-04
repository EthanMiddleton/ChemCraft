using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    class Player
    {
        //variables the player may need
        //hand is the elements currently in the player's hand
        private ArrayList hand;
        //compounds is the list of compounds the player owns
        private List<Compound> compounds;
        //the player's deck
        private List<Element> deck;
        //the crucible where elements will combine
        private Crucible crucible;
        //how much energy the player has
        private int energy, health;
        //shield array list
        private ArrayList shield;

        //player constructor
        public Player()
        {
            deck = new List<Element>();
            hand = new ArrayList();
            compounds = new List<Compound>();
            shield = new ArrayList();
            energy = 0;
            health = 10;
        }
        //draw cards until the plaer hand has 6 cards
        public void DrawCards()
        {
            while (hand.Count < 6)
                hand.Add(Draw());
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
                if (deck[rand].state == 0)
                {
                    deck[rand].state = 1;
                    check = true;
                    return deck[rand];
                }
            }
            return null;
        }

        //method to determine amount of income
        public void income(int active) // how energy is gained from the compounds made
        {
            for (int i = 0; i < compounds.Count; i++)
            {
               energy += compounds[i].value;
            }
        }

        public void useCrucible()
        {
            //cruicble.(Method)(hand, compounds);
        }

        //removes a compound (needs to be improved so that you send the compound sent)
        public void removeCompound(int n)
        {
            Compound tempC = new Compound();
            tempC = compounds[n];
            compounds.RemoveAt(n);
        }
        //Setters and Getters for hand, compounds (what compounds are in possession of the player, and crucible
        #region Setters/Getters
        public ArrayList Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public List<Compound> Compounds
        {
            get { return compounds; }
            set { compounds = value; }
        }

        public Crucible Crucible
        {
           get { return crucible; }
           set { crucible = value; }
        }
        
        public int health
        {
            get { return health; }
            set { health = value; }
        }

        #endregion
    }
}
