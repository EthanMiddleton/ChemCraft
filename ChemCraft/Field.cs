using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ChemCraft
{
    partial class Field
    {
        /// <summary>
        /// Variables
        /// </summary>
        #region
        // General field objects
        public Player[] player;

        // Turn taking variables
        enum TurnPos { attackActive, other, crafting };
        static int turnPosB;
        static TurnPos turnPos;
        int active, turnCount;

        // Variables for changing selected card
        MouseState mouse;
        int selected;
        string selectedString;
        Boolean go;

        // Variables for attack/defend
        enum compType { Acid = 1, Base }

        // Variables for isWon()
        int victor;

        // Variables for drawing
        Vector2 drawPos;

        // Variables for consoleDraw
        string say;

        #endregion

        public Field()
        {
            player = new Player[2] { new Player(), new Player() };
            turnCount = 0;
            turnPos = TurnPos.other;
        }

        /// <summary>
        /// Tests if a player has won
        /// </summary>
        /// <returns>
        /// The state of victory
        /// 0 = no victor yet
        /// 1 = player 1
        /// 2 = player 2
        /// </returns>
        public int isWon()
        {
            victor = 0;
            // Determine victor
            if (player[0].Health == 0)
            {
                victor = 2;
            }
            else if (player[1].Health == 0)
            {
                victor = 1;
            }

            // Return victor
            return victor;
        }

        /// <summary>
        /// Runs every tick
        /// </summary>
        public void cycle()
        {
            turn();
        }

        /// <summary>
        /// Run a player's turn
        /// </summary>
        /// <param name="active">The active player</param>
        public void turn()
        {
            if (turnPosB == 1)
            {
                active = turnCount % 2;
                turnPosB++;
            }
            if (turnPosB == 2)
            {
                player[active].income();
                turnPosB++;
            }
            if (turnPosB == 3)
            {
                turnPos = TurnPos.crafting;
                turnPosB++;
            }
            if (turnPosB == 4)
            {
                turnPosB = 0;
                player[active].useCrucible();
            }
            if (turnPosB == 5)
            {
                player[active].DrawCards(turnCount/2 - turnCount%2);
                turnCount++;
                turnPosB = 1;
            }
        }

        /// <summary>
        /// Take and compare the players attack with the enemy's defense
        /// </summary>
        /// <param name="active">The active player</param>
        private void attack(int active)
        {
            if (player[0].Compounds.Count > 0)
            {
                player[active].Energy -= 2 * player[active].Compounds[selected].elementnum;
                // Test if the opponent has a shield for the current attack
                for (int i = 0; i < player[otherPlayer].Defense.Count; i++)
                {
                    if (player[otherPlayer].Compounds[i].type.Equals(Compound.Type.Acid) && player[active].Compounds[selected].type.Equals(Compound.Type.Base))
                    {
                        player[active].removeCompound(selected);
                        return;
                    }
                    if (player[otherPlayer].Compounds[i].type.Equals(Compound.Type.Base) && player[active].Compounds[selected].type.Equals(Compound.Type.Acid))
                    {
                        player[active].removeCompound(selected);
                        return;
                    }
                }
                player[otherPlayer].Health -= player[active].Compounds[selected].damage;
                player[active].removeCompound(selected);
            }
        }


        /// <summary>
        /// Play a defense
        /// </summary>
        /// <param name="active">The active player</param>
        private void defend(int selected)
        {

            player[active].Defense.Add(player[active].Compounds[selected]);
            player[active].Compounds.RemoveAt(selected);
        }

        /// <summary>
        /// Select the card to attack
        /// </summary>
        /// <typeparam name="Element"></typeparam>
        /// <param name="active">The active player's compounds</param>
        /// <param name="cPlayer">The array position fo the current player (not directly used, parameter only)</param>
        private void selectCard<Element>(List<Compound> activeHand, int cPlayer)
        {
            turnPos = TurnPos.attackActive;
            selectedString = " ";
            while (selectedString != "")
            {
                selectedString = Console.ReadLine();
                for (int i = 0; i < player[cPlayer].Compounds.Count; i++)
                {
                    try
                    {
                        selected = Convert.ToInt16(selectedString);
                        go = true;
                    }
                    catch (Exception)
                    {
                        go = false;
                    }
                    if (go)
                    {
                        if (selected == i + 1 && player[cPlayer].Compounds[i].elementnum * 2 <= player[cPlayer].Energy)
                        {
                            attack(cPlayer);
                        }
                        else if (selected == -(i + 1) && player[cPlayer].Compounds[i].elementnum * 2 <= player[cPlayer].Energy)
                        {
                            defend(-selected);
                        }
                    }
                }
            }
            turnPos = TurnPos.other;
        }

        /// <summary>
        /// Easy access to the inactive player
        /// </summary>
        int otherPlayer
        {
            get
            {
                if (active == 1)
                {
                    return 0;
                }
                return 1;
            }
        }

        /// <summary>
        /// Draw something
        /// </summary>
        /// <param name="spriteBatch"> spriteBatch to be used </param>
        /// <param name="texture">Image source location</param>
        /// <param name="position">Location of image</param>
        //public void Draw(SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        //{
        //    spriteBatch.Draw(texture, position, Color.White);
        //}

        /// <summary>
        /// Called by Crucible to continue the turn
        /// </summary>
        public static void craftingDone()
        {
            turnPosB = 5;
        }
    }
}
