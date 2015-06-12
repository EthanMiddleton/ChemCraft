using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;*/

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
        static TurnPos turnPos;
        int active, turnCount;

        // Variables for changing selected card
        //MouseState mouse;
        int selected;
        string selectedString;

        // Variables for attack/defend
        enum compType { Acid = 1, Base }

        // Variables for isWon()
        int victor;

        // Variables for drawing
        //Vector2 drawPos;

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
           // if (turnPos != TurnPos.crafting)
            {
                if (turnPos == TurnPos.other)
                {
                    active = turnCount % 2;
                    player[active].income(active);
                }
                selectCard<Element>(player[active].Compounds, active);
                if (turnPos == TurnPos.other)
                {
                    attack(active);
                    turnPos = TurnPos.crafting;
                    player[active].useCrucible();
                    player[active].DrawCards();
                    turnCount++;
                }
            }
            //consoleDraw();
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
                for (int i = 0; i < otherPlayer.Defense.Count; i++)
                {
                    if (otherPlayer.Compounds[i].type.Equals(Compound.Type.Acid) && player[active].Compounds[selected].type.Equals(Compound.Type.Base))
                    {
                        player[active].removeCompound(selected);
                        return;
                    }
                    if (otherPlayer.Compounds[i].type.Equals(Compound.Type.Base) && player[active].Compounds[selected].type.Equals(Compound.Type.Acid))
                    {
                        player[active].removeCompound(selected);
                        return;
                    }
                }
                player[active].removeCompound(selected);
                otherPlayer.Health -= player[active].Compounds[selected].damage;
            }
        }


        /// <summary>
        /// Play a defense
        /// </summary>
        /// <param name="active">The active player</param>
        private void defend()
        {
            player[active].Compounds.Add(player[active].Compounds[selected]);
            player[active].removeCompound(selected);
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
            //mouse = Mouse.GetState();
            //if (mouse.MiddleButton == ButtonState.Pressed)
            //{
            //    turnPos = TurnPos.other;
            //    return;
            //}
            //for (int i = 0; i < activeHand.Count; i++)
            //{
            //    if ((activeHand[i].X < (int)mouse.X && (int)mouse.X < activeHand[i].X + 20) && (activeHand[i].Y < (int)mouse.Y && (int)mouse.Y < activeHand[i].Y + 20))
            //    {
            //        if (mouse.LeftButton == ButtonState.Pressed && activeHand[i].elementnum * 2 < player[cPlayer].Energy)
            //        {
            //            attack(cPlayer);
            //            turnPos = TurnPos.other;
            //        }
            //        if (mouse.RightButton == ButtonState.Pressed && activeHand[i].elementnum * 2 < player[cPlayer].Energy)
            //        {
            //            defend();
            //            turnPos = TurnPos.other;
            //        }
            //    }
            //}
            selectedString = Console.ReadLine();
            for (int i = 0; i < player[cPlayer].Compounds.Count; i++)
            {
                if (selectedString.Equals(i))
                {
                    selected = Convert.ToInt16(selectedString);
                    attack(cPlayer);
                    turnPos = TurnPos.other;
                }
            }
        }

        /// <summary>
        /// Easy access to the inactive player
        /// </summary>
        Player otherPlayer
        {
            get
            {
                if (active == 1)
                {
                    return player[0];
                }
                return player[1];
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
            turnPos = TurnPos.crafting;
        }


        private void consoleDraw()
        {

            Console.SetWindowSize(100, 11);
            // Show health and energy
            say = "Health: " + player[0].Health + "         Energy: " + player[0].Energy;
            Console.WriteLine(say);

            // Show hand
            say = player[0].Hand[0].elementSymbol;
            for (int i = 1; i < player[0].Hand.Count; i++)
            {
                say += ", " + player[0].Hand[i].elementSymbol;
            }
            Console.WriteLine(say);

            // Show Compounds
            say = player[0].Compounds[0].GetName;
            for (int i = 1; i < player[0].Compounds.Count; i++)
            {
                say += ", " + player[0].Compounds[i].GetName;
            }
            Console.WriteLine(say);

            // Show defenses
            say = player[0].Defense[0].GetName;
            for (int i = 1; i < player[0].Defense.Count; i++)
            {
                say += ", " + player[0].Defense[i].GetName;
            }
            Console.WriteLine(say);

            // Middle stuff
            Console.WriteLine("Player 1");
            Console.WriteLine("");
            Console.WriteLine("Player 2");

            // Show defenses
            say = player[1].Defense[0].GetName;
            for (int i = 1; i < player[1].Defense.Count; i++)
            {
                say += ", " + player[1].Defense[i].GetName;
            }
            Console.WriteLine(say);

            // Show Compounds
            say = player[1].Compounds[0].GetName;
            for (int i = 1; i < player[1].Compounds.Count; i++)
            {
                say += ", " + player[1].Compounds[i].GetName;
            }
            Console.WriteLine(say);

            // Show hand
            say = player[1].Hand[0].elementSymbol;
            for (int i = 1; i < player[1].Hand.Count; i++)
            {
                say += ", " + player[1].Hand[i].elementSymbol;
            }
            Console.WriteLine(say);

            // Show health and energy
            say = "Health: " + player[1].Health + "         Energy: " + player[1].Energy;
            Console.WriteLine(say);

        }
    }
}
