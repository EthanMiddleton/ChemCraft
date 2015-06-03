using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
   abstract partial class Element : Card
    {
     enum elementStates {SOLID, LIQUID, GAS, AQUEOUS};
     enum ionType {ANION, CATION, NOT};

        abstract Element transmute;
        abstract void attack;
        abstract void defense;

        String elementSymbol;
        int atomicNumber, valenceElectrons, valenceShell, ion, state;

    }

   abstract class Metal : Element
   {
       abstract void reactWithNonMetal;
   }

   abstract class NonMetal : Element
   {
       abstract bool isDiatomic;
   }

   abstract class Metalloid : Element
   {
   }

   public class Hydrogen : NonMetal
   {
       public Hydrogen()
       {
           elementSymbol = "H";
           atomicNumber = 1;
           valenceElectrons = 1;
           valenceShell = 2;
           state = GAS;
           ion = CARTION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Helium : NonMetal
   {
       public Helium()
       {
           elementSymbol = "He";
           atomicNumber = 2;
           valenceElectrons = 2;
           valenceShell = 2;
           state = GAS;
           ion = NOT;
       }

       public bool isDiatomic() { return false; }
   }

   public class Lithium : Metal
   {
       public Lithium()
       {
           elementSymbol = "Li";
           atomicNumber = 3;
           valenceElectrons = 1;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Beryllium : Metal
   {
       public Beryllium()
       {
           elementSymbol = "Be";
           atomicNumber = 4;
           valenceElectrons = 2;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Boron : Metalloid
   {
       public Boron()
       {
           elementSymbol = "B";
           atomicNumber = 5;
           valenceElectrons = 3;
           valenceShell = 8;
           state = SOLID;
           ion = NOT;
       }
   }

   public class Carbon : NonMetal
   {
       public Carbon()
       {
           elementSymbol = "C";
           atomicNumber = 6;
           valenceElectrons = 4;
           valenceShell = 8;
           state = SOLID;
           ion = NOT;
       }
       public bool isDiatomic() { return false; }
   }

   public class Nitrogen : NonMetal
   {
       public Nitrogen()
       {
           elementSymbol = "N";
           atomicNumber = 7;
           valenceElectrons = 5;
           valenceShell = 8;
           state = GAS;
           ion = ANION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Oxygen : NonMetal
   {
       public Oxygen()
       {
           elementSymbol = "O";
           atomicNumber = 8;
           valenceElectrons = 6;
           valenceShell = 8;
           state = GAS;
           ion = ANION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Fluorine : NonMetal
   {
       public Fluorine()
       {
           elementSymbol = "F";
           atomicNumber = 9;
           valenceElectrons = 7;
           valenceShell = 8;
           state = GAS;
           ion = ANION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Neon : NonMetal
   {
       public Neon()
       {
           elementSymbol = "Ne";
           atomicNumber = 10;
           valenceElectrons = 8;
           valenceShell = 8;
           state = GAS;
           ion = NOT;
       }
       public bool isDiatomic() { return false; }
   }
}
