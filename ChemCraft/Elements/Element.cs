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

   public class Sodium : Metal
   {
       public Sodium()
       {
           elementSymbol = "Na";
           atomicNumber = 11;
           valenceElectrons = 1;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Magnesium : Metal
   {
       public Magnesium()
       {
           elementSymbol = "Mg";
           atomicNumber = 12;
           valenceElectrons = 2;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Aluminum : Metal
   {
       public Aluminum()
       {
           elementSymbol = "Al";
           atomicNumber = 13;
           valenceElectrons = 3;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Silicon : Metalloid
   {
       public Silicon()
       {
           elementSymbol = "Si";
           atomicNumber = 14;
           valenceElectrons = 4;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }

   public class Phosphorus : NonMetal
   {
       public Phosphorus()
       {
           elementSymbol = "P";
           atomicNumber = 15;
           valenceElectrons = 5;
           valenceShell = 8;
           state = GAS;
           ion = ANION;
       }

       public bool isDiatomic() { return false; }
   }

   public class Sulphur : NonMetal
   {
       public Sulphur()
       {
           elementSymbol = "S";
           atomicNumber = 16;
           valenceElectrons = 6;
           valenceShell = 8;
           state = gas;
           ion = ANION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Chlorine : NonMetal
   {
       public Chlorine()
       {
           elementSymbol = "Cl";
           atomicNumber = 17;
           valenceElectrons =7;
           valenceShell = 8;
           state = GAS;
           ion = ANION;
       }

       public bool isDiatomic() { return true; }
   }

   public class Argon : NonMetal
   {
       public Argon()
       {
           elementSymbol = "Ar";
           atomicNumber = 18;
           valenceElectrons = 8;
           valenceShell = 8;
           state = GAS;
           ion = NOT;
       }

       public bool isDiatomic() { return true; }
   }

   public class Potassium : Metal
   {
       public Potassium()
       {
           elementSymbol = "K";
           atomicNumber = 19;
           valenceElectrons = 1;
           valenceShell = 8;
           state = solid;
           ion = CATION;
       }
   }

   public class Calcium : Metal
   {
       public Calcium()
       {
           elementSymbol = "Ca";
           atomicNumber = 20;
           valenceElectrons = 2;
           valenceShell = 8;
           state = SOLID;
           ion = CATION;
       }
   }
}
