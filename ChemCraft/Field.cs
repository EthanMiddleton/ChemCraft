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
        Player[] player;

        // Turn taking variables
        enum TurnPos { attackActive, other, crafting };
        static TurnPos turnPos;
        int active, turnCount;

        // Variables for changing selected card
        MouseState mouse;
        int selected;

        // Variables for attack/defend
        enum compType { Acid = 1, Base }

        // Variables for isWon()
        int victor;

        // Variables for drawing
        Vector2 drawPos;

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
            if (turnPos != TurnPos.crafting)
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
        }

        /// <summary>
        /// Take and compare the players attack with the enemy's defense
        /// </summary>
        /// <param name="active">The active player</param>
        private void attack(int active)
        {
            player[active].Energy -= 2 * player[active].Compounds[selected].elementnum;
            // Test if the opponent has a shield for the current attack
            for (int i = 0; i < otherPlayer.defense().Count; i++)
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
            mouse = Mouse.GetState();
            if (mouse.MiddleButton == ButtonState.Pressed)
            {
                turnPos = TurnPos.other;
                return;
            }
            for (int i = 0; i < activeHand.Count; i++)
            {
                if ((activeHand[i].X < (int)mouse.X && (int)mouse.X < activeHand[i].X + 20) && (activeHand[i].Y < (int)mouse.Y && (int)mouse.Y < activeHand[i].Y + 20))
                {
                    if (mouse.LeftButton == ButtonState.Pressed && activeHand[i].elementnum * 2 < player[cPlayer].Energy)
                    {
                        attack(cPlayer);
                        turnPos = TurnPos.other;
                    }
                    if (mouse.RightButton == ButtonState.Pressed && activeHand[i].elementnum * 2 < player[cPlayer].Energy)
                    {
                        defend();
                        turnPos = TurnPos.other;
                    }
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
        public void Draw(SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        /// <summary>
        /// Called by Crucible to continue the turn
        /// </summary>
        public static void craftingDone()
        {
            turnPos = TurnPos.crafting;
        }


        private void consoleDraw()
        {

        }
    }
}
