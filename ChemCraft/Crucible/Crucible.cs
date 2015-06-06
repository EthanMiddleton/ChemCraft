using System;
using System.Collections;
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
        private Player player;
        private List<Element> hand;
        private List<Compound> compounds;
        private List<Compound> newCompounds;
        private List<Element> deck;//unimplemented

        int[] totalElements = new int[118];
        int energy;

        public Crucible(Player myPlayer)
        {
            //initialize variables
            player = myPlayer;

            hand = player.Hand;
            compounds = player.Compounds;
            energy = player.getEnergy;
            deck = player.deck;

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
            totalElements = new int[118];

            for (int i = 0; i < hand.Count; i++)
            {
                //add the elements to the menu
                comboBoxElements.Items.Add(hand[i].name);
                //add the elements to the array
                totalElements[hand[i].number]++;
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
                for(int j = 0; j > totalElements[i]; j++)
                {
                    //add the element the the hand
                   hand.Add(createElement(i+1));
                }
            }
        }

        //needs to be updated
        private void updateNewComp()
        {
            if (totalElements[11 - 1] >= 1 && totalElements[1 - 1] >= 1 && totalElements[6 - 1] >= 1 && totalElements[8 - 1] >= 3)
            {
                newCompounds.Add(new NaHCO3);
            }
            if (totalElements[11 - 1] >= 1 && totalElements[17 - 1] >=1 && totalElements[8 - 1] >= 1)
            {
                newCompounds.Add(new NaClO);
            }
            if (totalElements[7 - 1] >= 2 && totalElements[8 - 1] >= 1)
            {
                newCompounds.Add(new N2O);
            }
            if (totalElements[20 - 1] >= 1 && totalElements[6 - 1] >= 1 && totalElements[8 - 1] >= 3)
            {
                newCompounds.Add(new CaCO3);
            }
            if (totalElements[8 - 1] >= 3 && totalElements[1 - 1] >= 8 && totalElements[8 - 1] >= 1)
            {
                newCompounds.Add(new (CH3)2CHOH);
            }
            if (totalElements[6 - 1] >= 12 && totalElements[1 - 1] >= 22 && totalElements[8 - 1] >= 11)
            {
                newCompounds.Add(new C12H22O11);
            }
            if (totalElements[14 - 1] >= 1 && totalElements[8 - 1] >= 2)
            {
                newCompounds.Add(new SiO2);
            }
            if (totalElements[1 - 1] >= 1 && totalElements[17 - 1] >= 1)
            {
                newCompounds.Add(new HCl);
            }
            if (totalElements[11 - 1] >= 1 && totalElements[17 - 1] >= 1)
            {
                newCompounds.Add(new NaCl);
            }
            if (totalElements[11 - 1] >= 1 && totalElements[8 - 1] >= 1 && totalElements[1 - 1] >= 1)
            {
                newCompounds.Add(new NaOH);
            }
            if (totalElements[6 - 1] >= 8 && totalElements[1 - 1] >= 9 && totalElements[7 - 1] >= 1 && totalElements[8 - 1] >= 2)
            {
                newCompounds.Add(new C8H9NO2);
            }
            if (totalElements[1 - 1] >= 2 && totalElements[8 - 1] >= 1)
            {
                newCompounds.Add(new H2O);
            }
            if (totalElements[1 - 1] >= 2 && totalElements[8 - 1] >= 2)
            {
                newCompounds.Add(new H2O2);
            }
            if (totalElements[19 - 1] >= 1 && totalElements[8 - 1] >= 1 && totalElements[1 - 1] >= 1)
            {
                newCompounds.Add(new KOH);
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
                totalElements[tmpFormula[i]]--;
            }

            //update
            updateHand();
            updateExistComp();
            updateNewComp();
        }

        //destroy
        private void button2_Click(object sender, EventArgs e)
        {
            //for each element inside the compound
            int[] tmp = compounds[comboBoxComp.SelectedIndex].elements;
            if (tmp.Length >= energy)
            {
                for (int i = 0; i < tmp.Length; i++)
                {
                    //add the element to the hand
                    hand.AddRange(createElement(tmp[i + 1]));
                    //take away energy
                    energy--;
                }

                //remove the compound from the array
                compounds.Remove(comboBoxComp.SelectedIndex);

                //update
                updateElements();
                updateExistComp();
                updateNewComp();
            }
        }

        public int findInDeck(Element atom)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                if (deck[i].
            }
            return 0;
        }

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
            player.getEnergy = energy;
            player.deck = deck;

            player.craftingDone();
            this.Close();
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
            else if (name == "(CH3)2CHOH")
            {
                return new CH32CHOH();
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
