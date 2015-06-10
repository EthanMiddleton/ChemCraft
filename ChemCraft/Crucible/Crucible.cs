using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemCraft
{
    public partial class Crucible : Form
    {
        private List<Element>[] elements;
        private Player player;
        private List<Element> hand;
        private List<Compound> compounds;
        private List<Compound> newCompounds;

        private int energy;

        public Crucible(Player myPlayer)
        {
            //initialize variables
            player = myPlayer;

            hand = player.Hand;
            compounds = player.Compounds;
            energy = player.Energy;

            for(int i = 0; i < 118; i++)
            {
                elements[i] = new List<Element>();
            }

            InitializeComponent();

            //update
            updateElements();
            updateExistComp();
            updateNewComp();
        }

        private void updateElements()
        {
            //clear variables
            comboBoxElements.Items.Clear();

            for (int i = 0; i < hand.Count; i++)
            {
                //add the elements to the menu
                comboBoxElements.Items.Add(hand[i].symbol);
                //add the elements to the array
                elements[hand[i].atomicNumber].Add(hand[i]);
            }
        }

        private void updateHand()
        {
            //clear variable
            hand.Clear();

            //for each kind of element
            for(int i = 0; i < 118; i++)
            {
                //for each amount that kind of element
                for(int j = 0; j > elements[i].Count; j++)
                {
                    //add the element the the hand
                   hand.Add(elements[i][j]);
                }
            }
        }

       
        private void updateNewComp()
        {
            if (elements[11 - 1].Count >= 1 && elements[1 - 1].Count >= 1 && elements[6 - 1].Count >= 1 && elements[8 - 1].Count >= 3)
            {
                newCompounds.Add(new NaHCO3());
            }
            if (elements[11 - 1].Count >= 1 && elements[17 - 1].Count >= 1 && elements[8 - 1].Count >= 1)
            {
                newCompounds.Add(new NaClO());
            }
            if (elements[7 - 1].Count >= 2 && elements[8 - 1].Count >= 1)
            {
                newCompounds.Add(new N2O());
            }
            if (elements[20 - 1].Count >= 1 && elements[6 - 1].Count >= 1 && elements[8 - 1].Count >= 3)
            {
                newCompounds.Add(new CaCO3());
            }
            if (elements[8 - 1].Count >= 3 && elements[1 - 1].Count >= 8 && elements[8 - 1].Count >= 1)
            {
                newCompounds.Add(new C3H8O());
            }
            if (elements[6 - 1].Count >= 12 && elements[1 - 1].Count >= 22 && elements[8 - 1].Count >= 11)
            {
                newCompounds.Add(new C12H22O11());
            }
            if (elements[14 - 1].Count >= 1 && elements[8 - 1].Count >= 2)
            {
                newCompounds.Add(new SiO2());
            }
            if (elements[1 - 1].Count >= 1 && elements[17 - 1].Count >= 1)
            {
                newCompounds.Add(new HCl());
            }
            if (elements[11 - 1].Count >= 1 && elements[17 - 1].Count >= 1)
            {
                newCompounds.Add(new NaCl());
            }
            if (elements[11 - 1].Count >= 1 && elements[8 - 1].Count >= 1 && elements[1 - 1].Count >= 1)
            {
                newCompounds.Add(new NaOH());
            }
            if (elements[6 - 1].Count >= 8 && elements[1 - 1].Count >= 9 && elements[7 - 1].Count >= 1 && elements[8 - 1].Count >= 2)
            {
                newCompounds.Add(new C8H9NO2());
            }
            if (elements[1 - 1].Count >= 2 && elements[8 - 1].Count >= 1)
            {
                newCompounds.Add(new H2O());
            }
            if (elements[1 - 1].Count >= 2 && elements[8 - 1].Count >= 2)
            {
                newCompounds.Add(new H2O2());
            }
            if (elements[19 - 1].Count >= 1 && elements[8 - 1].Count >= 1 && elements[1 - 1].Count >= 1)
            {
                newCompounds.Add(new KOH());
            }
        }

        private void updateExistComp()
        {
            //for each compound
            for (int i = 0; i > compounds.Count; i++)
            {
                //add the compound to the menu
                comboBoxComp.Items.Add(compounds[i].name);
            }
        }

        //create
        private void button1_Click(object sender, EventArgs e)
        {
            //add the compound to the array
            compounds.Add(createCompound(comboBoxNewComp.Text));

            //for each element required in the compound
            int[] tmpFormula = newCompounds[newCompounds.Count].elements;
            for(int i = 0; i < tmpFormula.Length; i++)
            {

                //remove the elements from the array
                elements[tmpFormula[i]].RemoveAt(0);
            }

            //update
            updateHand();
            updateExistComp();
            updateNewComp();
        }

        //destroy
        private void button2_Click(object sender, EventArgs e)
        {
            //tmp variables
            int[] tmpComp = compounds[comboBoxComp.SelectedIndex].elements;
            List<Element>[] tempEle = elements;

            //for each element inside the compound
            if (tmpComp.Length >= energy)
            {
                for (int i = 0; i < tmpComp.Length; i++)
                {
                    //add the element to the hand
                    hand.Add(tempEle[tmpComp[i]][0]);
                    tempEle[tmpComp[i]].RemoveAt(0);
                    //take away energy
                    energy--;
                }

                //remove the compound from the array
                compounds.RemoveAt(comboBoxComp.SelectedIndex);

                //update
                updateElements();
                updateExistComp();
                updateNewComp();
            }
        }
        /*
        //unfinished
        public int findInDeck(Element atom)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                if (deck[i].
            }
            return 0;
        }
        */
        //update formula text
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxNewComp.Text = newCompounds[comboBoxNewComp.SelectedIndex].formula;
        }

        //update the formula text
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxComp.Text = compounds[comboBoxComp.SelectedIndex].formula;
        }

        //Close the crucible and update the player
        private void buttonFinish_Click(object sender, EventArgs e)
        {

            player.Hand = hand;
            player.Compounds = compounds;
            player.Energy = energy;
            player.Deck = updateDeck();

            Field.craftingDone();
            this.Close();
        }

        private List<Element> updateDeck()
        {
            return null;
        }

        /*public Element createElement(int number)
        {
            if (number == 1)
            {
                return new Hydrogen();
            }
            if (number == 2)
            {
                return new Helium();
            }
            if (number == 3)
            {
                return new Lithium();
            }
            if (number == 4)
            {
                return new Beryllium();
            }
            if (number == 5)
            {
                return new Boron();
            }
            if (number == 6)
            {
                return new Carbon();
            }
            if (number == 7)
            {
                return new Nitrogen();
            }
            if (number == 8)
            {
                return new Oxygen();
            }
            if (number == 9)
            {
                return new Fluorine();
            }
            if (number == 10)
            {
                return new Neon();
            }
            return null;
        }*/

        //needs to be updated
        public Compound createCompound(String name)
        {
            if (name == "NaHCO3")
            {
                return new NaHCO3();
            }
            else if (name == "NaClO")
            {
                return new NaClO();
            }
            else if (name == "N2O")
            {
                return new N2O();
            }
            else if (name == "CaCO3")
            {
                return new CaCO3();
            }
            else if (name == "C3H8O")
            {
                return new C3H8O();
            }
            else if (name == "C12H22O11")
            {
                return new C12H22O11();
            }
            else if (name == "SiO2")
            {
                return new SiO2();
            }
            else if (name == "HCl")
            {
                return new HCl();
            }
            else if (name == "NaCl")
            {
                return new NaCl();
            }
            else if (name == "NaOH")
            {
                return new NaOH();
            }
            else if (name == "C8H9NO2")
            {
                return new C8H9NO2();
            }
            else if (name == "H2O")
            {
                return new H2O();
            }
            else if (name == "H2O2")
            {
                return new H2O2();
            }
            else if (name == "KOH")
            {
                return new KOH();
            }
            return null;
        }
    }
}
