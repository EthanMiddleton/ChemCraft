using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemCraft
{
    public class Player
    {
        //variables the player may need
        //hand is the elements currently in the player's hand
        private List<Element> hand;
        //compounds is the list of compounds the player owns
        private List<Compound> compounds;
        //the player's deck
        private Deck deck;
        //how much energy the player has
        private int energy;
        private int health;
        //shield array list
        private List <Compound> shield;
        //random card that is selected
        static Random rnd = new Random();
        // Random int
        int rand;

        //player constructor
        public Player()
        {
            deck = new Deck();
            hand = new List<Element>();
            compounds = new List<Compound>();
            shield = new List<Compound>();
            energy = 0;
            health = 10;
            DrawCards(0);
        }
        //draw cards until the plaer hand has 6 cards
        public void DrawCards(int turnCount)
        {
            while (hand.Count < 6)
               hand.Add(Draw(turnCount));
            //for (int i = 0; i < hand.Count; i++)
            //{
            //    hand.RemoveAt(0);
            //}
            //hand.Add(new Hydrogen());
            //hand.Add(new Hydrogen());
           // hand.Add(new Hydrogen());
            //hand.Add(new Hydrogen());
          //  hand.Add(new Oxygen());
         //   hand.Add(new Hydrogen());
        }

        //draws a single card from the deck that hasn't previously been drawn
        private Element Draw(int turnCount)
        {
            //boolean that ensures you find a card that hasn't been found
            Boolean check = false;
            
            //loops until card is found that hasn't bee picked
            while (check == false)
            {
                if (turnCount < 5)
                {
                    rand = rnd.Next(60+4*turnCount);
                }
                else
                {
                    rand = rnd.Next(80);
                }
                if (Deck.List[rand].state == 1)
                {
                    Deck.List[rand].state = 2;
                    check = true;
                    return Deck.List[rand];
                }
            }
            return null;
        }

        //method to determine amount of income
        public void income() // how energy is gained from the compounds made
        {
            energy = 0;
            for (int i = 0; i < compounds.Count; i++)
            {
               energy += compounds[i].elementnum;
            }
        }

        // use crucible
        public void useCrucible()
        {
            Application.Run(new Crucible(this));
        }

        //removes a compound (needs to be improved so that you send the compound sent)
        public void removeCompound(int n)
        {
            Compound tempC = compounds[n];
            compounds.RemoveAt(n);
        }
        //Setters and Getters for hand, compounds (what compounds are in possession of the player, and crucible
        #region Setters/Getters
        public Deck Deck
        {
            get { return deck; }
            set { deck = value; }
        }
        public List<Element> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public List<Compound> Compounds
        {
            get { return compounds; }
            set { compounds = value; }
        }

        //public Crucible Crucible
        //{
        //    get { return crucible; }
        //    set { crucible = value; }
        //}

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public List<Compound> Defense
        {
            get { return shield; }
            set { shield = value; }
        }
    
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        #endregion
    }
}
