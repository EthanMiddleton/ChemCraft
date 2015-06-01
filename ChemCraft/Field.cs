using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ChemCraft
{
    partial class Field
    {
        /// <summary>
        /// Variables
        /// </summary>
        #region
        // General field objects
        Player[] player = new Player[2];

        // Variables for isWon() method
        int victor;

        #endregion

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
            if (player[0].health = 0)
            {
                victor = 2;
            }
            else if (player[1].health = 0)
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
        public void turn(int active)
        {
            activate(active);
            income(active);
        }

        /// <summary>
        /// Allow the player to activate/deactivate compounds
        /// </summary>
        /// <param name="active"></param>
        private void activate(int active)
        {
            for (int i = 0; i < player[active].compounds.length; i++)
            {
                if (Mouse.LeftButton == MouseButtonState.Pressed)
                {
                    
                }
            }
        }


        private void income(int active)
        {
            for (int i = 0; i < player[active].compounds.length; i++)
            {
                player[active].energy += player[active].compounds[i].value;
            }
        }
    }
}
