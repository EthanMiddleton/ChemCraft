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
        enum TurnPos { attackActive, other };
        TurnPos turnPos;
        int active;

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

        }

        /// <summary>
        /// Run a player's turn
        /// </summary>
        /// <param name="active">The active player</param>
        public void turn(int i)
        {
            if (turnPos == TurnPos.other)
            {
                active = i;
                player[active].income(active);
            }
            selectCard(active);
            if (turnPos == TurnPos.other)
            {
                attack(active);
                player[active].useCrucible();
                player[active].DrawCards();
            }
        }

        /// <summary>
        /// Take and compare the players attack with the enemy's defense
        /// </summary>
        /// <param name="active">The active player</param>
        private void attack(int active)
        {
            for (int i = 0; i < otherPlayer.Shield.Count; i++)
            {
                if (otherPlayer.Compounds[i].type == compType.Acid && player[active].Hand[selected].Type == compType.Base)
                {
                    player[active].removeCompound(selected);
                    return;
                }
            }
            otherPlayer.Health -= player[active].H.damage;
        }

        /// <summary>
        /// Selects the card to attack
        /// </summary>
        private void selectCard(int active)
        {
            turnPos = TurnPos.attackActive;
            mouse = Mouse.GetState();
            for (int i = 0; i < player[active].Hand.Count; i++)
            {
                if ((player[active].Hand[i].X < (int)mouse.X < player[active].Hand[i].X + 20) && (player[active].Hand[i].Y < (int)mouse.Y < player[active].hand[i].Y + 20))
                {

                    if (MOUSE PRESSED)
                    {
                attack(active);
                turnPos = TurnPos.other;
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
    }
}
