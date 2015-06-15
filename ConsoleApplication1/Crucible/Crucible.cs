using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemCraft;

namespace ChemCraft
{
    public partial class Crucible : Form
    {
        private List<List<Element>> elements;
        private Player player;
        private List<Element> hand;
        private Deck deck;
        private List<Compound> compounds;
        private List<Compound> newCompounds;

        private int energy;

        public Crucible(Player myPlayer)
        {
            //initialize variables
            player = myPlayer;

            hand = player.Hand;
            deck = player.Deck;
            compounds = player.Compounds;
            energy = player.Energy;

            newCompounds = new List<Compound>();

            elements = new List<List<Element>>();
            for (int i = 0; i < 20; i++)
                elements.Add(new List<Element>());

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

            elements = new List<List<Element>>();
            for (int i = 0; i < 118; i++)
                elements.Add(new List<Element>());

            for (int i = 0; i < hand.Count; i++)
            {
                //add the elements to the menu
                comboBoxElements.Items.Add(hand[i].elementSymbol);
                //add the elements to the array
                elements[hand[i].atomicNumber-1].Add(hand[i]);
            }
        }
       
        private void updateNewComp()
        {
            newCompounds.Clear();

            if (elements[11 - 1].Count >= 1 && elements[1 - 1].Count >= 1 && elements[6 - 1].Count >= 1 && elements[8 - 1].Count >= 3)
                newCompounds.Add(createCompound(new NaHCO3()));
            if (elements[11 - 1].Count >= 1 && elements[17 - 1].Count >= 1 && elements[8 - 1].Count >= 1)
                newCompounds.Add(createCompound(new NaClO()));
            if (elements[7 - 1].Count >= 2 && elements[8 - 1].Count >= 1)
                newCompounds.Add(createCompound(new N2O()));
            if (elements[20 - 1].Count >= 1 && elements[6 - 1].Count >= 1 && elements[8 - 1].Count >= 3)
                newCompounds.Add(createCompound(new CaCO3()));
            if (elements[8 - 1].Count >= 3 && elements[1 - 1].Count >= 8 && elements[8 - 1].Count >= 1)
                newCompounds.Add(createCompound(new C3H8O()));
            if (elements[6 - 1].Count >= 12 && elements[1 - 1].Count >= 22 && elements[8 - 1].Count >= 11)
                newCompounds.Add(createCompound(new C12H22O11()));
            if (elements[14 - 1].Count >= 1 && elements[8 - 1].Count >= 2)
                newCompounds.Add(createCompound(new SiO2()));
            if (elements[1 - 1].Count >= 1 && elements[17 - 1].Count >= 1)
                newCompounds.Add(createCompound(new HCl()));
            if (elements[11 - 1].Count >= 1 && elements[17 - 1].Count >= 1)
                newCompounds.Add(createCompound(new NaCl()));
            if (elements[11 - 1].Count >= 1 && elements[8 - 1].Count >= 1 && elements[1 - 1].Count >= 1)
                newCompounds.Add(createCompound(new NaOH()));
            if (elements[6 - 1].Count >= 8 && elements[1 - 1].Count >= 9 && elements[7 - 1].Count >= 1 && elements[8 - 1].Count >= 2)
                newCompounds.Add(createCompound(new C8H9NO2()));
            if (elements[1 - 1].Count >= 2 && elements[8 - 1].Count >= 1)
                newCompounds.Add(createCompound(new H2O()));
            if (elements[1 - 1].Count >= 2 && elements[8 - 1].Count >= 2)
                newCompounds.Add(createCompound(new H2O2()));
            if (elements[19 - 1].Count >= 1 && elements[8 - 1].Count >= 1 && elements[1 - 1].Count >= 1)
                newCompounds.Add(createCompound(new KOH()));

            comboBoxNewComp.Items.Clear();
            for (int i = 0; i < newCompounds.Count; i++)
            {
                comboBoxNewComp.Items.Add(newCompounds[i].GetName);
            }
        }

        private Compound createCompound(Compound newCompound)
        {
            int[] myIDs = new int[newCompound.elements.Length];
            int j =  0;
            for (int i = 0; i < myIDs.Length; i++)
            {
                myIDs[i] = elements[newCompound.elements[i] - 1][j].ID;
                try
                {
                    if(newCompound.elements[i] != newCompound.elements[i + 1])
                    {
                        j = 0;
                    }
                }catch(Exception e)
                {

                }
            }
            newCompound.IDs = myIDs;

            return newCompound;
        }

        private void updateExistComp()
        {
            comboBoxComp.Items.Clear();
            //for each compound
            for (int i = 0; i < compounds.Count; i++)
                //add the compound to the menu
                comboBoxComp.Items.Add(compounds[i].name);
        }

        //create
        private void button1_Click(object sender, EventArgs e)
        {
            Element tmpEle;
            Compound newCompound = newCompounds[comboBoxNewComp.SelectedIndex];
            //add the compound to the array
            compounds.Add(newCompound);

            //for each element required in the compound
            for (int i = 0; i < newCompound.elements.Length; i++)
            {
                tmpEle = deck.List[newCompound.IDs[i]];

                //remove the elements
                tmpEle.state = 4;
                hand.Remove(tmpEle);
                elements[tmpEle.atomicNumber - 1].Remove(tmpEle);
            }
            //remove the compound from the array
            newCompounds.RemoveAt(comboBoxNewComp.SelectedIndex);

            //update
            updateExistComp();
            updateElements();
            updateNewComp();
        }

        //destroy
        private void button2_Click(object sender, EventArgs e)
        {
            //tmp variables
            Element tmpEle;
            Compound tmpComp = compounds[comboBoxComp.SelectedIndex];

            //if you have enough energy to spend
            if (tmpComp.elements.Length >= energy)
            {
                energy -= tmpComp.elements.Length;
                //for each element inside the compound
                for (int i = 0; i < tmpComp.elements.Length; i++)
                {
                    //add the element to the hand
                    tmpEle = deck.List[tmpComp.IDs[i]];
                    hand.Add(tmpEle);
                    tmpEle.state = 2;
                }

                //remove the compound from the array
                compounds.RemoveAt(comboBoxComp.SelectedIndex);

                //update
                updateElements();
                updateExistComp();
                updateNewComp();
            }
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
            player.Energy = energy;
            player.Deck = deck;

            Field.craftingDone();
            this.Close();
        }
    }
}
