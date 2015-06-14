using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChemCraft;
using System.Windows.Forms;

namespace ChemCraft
{
    class Program
    {
        //static Field field = new Field();
        static string say;

       // [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
                Game1 myGame = new Game1();
        }


        //private static void ConsoleDraw()
        //{

        //    Console.SetWindowSize(100, 12);
        //    // Show health and energy
        //    say = "Health: " + myGame.field.player[0].Health + "         Energy: " + field.player[0].Energy;
        //    Console.WriteLine(say);

        //    // Show hand
        //    say = field.player[0].Hand[0].elementSymbol;
        //    for (int i = 1; i < field.player[0].Hand.Count; i++)
        //    {
        //        say += ", " + field.player[0].Hand[i].elementSymbol;
        //    }
        //    Console.WriteLine(say);

        //    // Show Compounds
        //    say = "";
        //    if (field.player[0].Compounds.Count > 0)
        //    {
        //        say = field.player[0].Compounds[0].GetName;
        //        for (int i = 1; i < field.player[0].Compounds.Count; i++)
        //        {
        //            say += ", " + field.player[0].Compounds[i].GetName;
        //        }
        //    }
        //    Console.WriteLine(say);

        //    // Show defenses
        //    say = "";
        //    if (field.player[0].Defense.Count > 0)
        //    {
        //        say = field.player[0].Defense[0].GetName;
        //        for (int i = 1; i < field.player[0].Defense.Count; i++)
        //        {
        //            say += ", " + field.player[0].Defense[i].GetName;
        //        }
        //    }
        //    Console.WriteLine(say);

        //    // Middle stuff
        //    Console.WriteLine("Player 1");
        //    Console.WriteLine("");
        //    Console.WriteLine("Player 2");

        //    // Show defenses
        //    say = "";
        //    if (field.player[1].Defense.Count > 0)
        //    {
        //        say = field.player[1].Defense[0].GetName;
        //        for (int i = 1; i < field.player[1].Defense.Count; i++)
        //        {
        //            say += ", " + field.player[1].Defense[i].GetName;
        //        }
        //    }
        //    Console.WriteLine(say);

        //    // Show Compounds
        //    say = "";
        //    if (field.player[1].Compounds.Count > 0)
        //    {
        //        say = field.player[1].Compounds[0].GetName;
        //        for (int i = 1; i < field.player[1].Compounds.Count; i++)
        //        {
        //            say += ", " + field.player[1].Compounds[i].GetName;
        //        }
        //    }
        //    Console.WriteLine(say);

        //    // Show hand
        //    say = "";
        //    say = field.player[1].Hand[0].elementSymbol;
        //    for (int i = 1; i < field.player[1].Hand.Count; i++)
        //    {
        //        say += ", " + field.player[1].Hand[i].elementSymbol;
        //    }
        //    Console.WriteLine(say);

        //    // Show health and energy
        //    say = "Health: " + field.player[1].Health + "         Energy: " + field.player[1].Energy;
        //    Console.WriteLine(say);
        //}

    }
}
