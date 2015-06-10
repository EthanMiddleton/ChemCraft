using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
   public abstract class Element : Card
    {
     public enum elementStates {SOLID, LIQUID, GAS, AQUEOUS};
     public enum ionType {ANION, CATION, NOT};

        /* public abstract Element transmute();
        public abstract void attack();
        public abstract void defense(); */

        String ElementSymbol;
        int AtomicNumber, ValenceElectrons, ValenceShell, State;
        ionType Ion;

        #region Properties
        public String elementSymbol
        {
            protected set { ElementSymbol = value; }
            get { return ElementSymbol;  }
        }

        public int atomicNumber
        {
            protected set { AtomicNumber = value; }
            get { return AtomicNumber; }
        }

        public int valenceElectrons
        {
            protected set { ValenceElectrons = value; }
            get { return ValenceElectrons;  }
        }

        public int valenceShell
        {
            protected set { ValenceShell = value; }
            get { return ValenceShell;  }
        }

        public new int state
        {
            set { State = value; }
            get { return State; }
        }

        public ionType ion
        {
            protected set { Ion = value; }
            get { return Ion; }
        }
        #endregion
    }

    public abstract class Metal : Element
   {
       public abstract void reactWithNonMetal();
   }

    public abstract class NonMetal : Element
   {
       public abstract bool isDiatomic();
   }

   public abstract class Metalloid : Element
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
           state = 1;
           ion = ionType.CATION;
       }

       public override bool isDiatomic() { return true; }
   }

   public class Helium : NonMetal
   {
       public Helium()
       {
           elementSymbol = "He";
           atomicNumber = 2;
           valenceElectrons = 2;
           valenceShell = 2;
           state = 1;
           ion = ionType.NOT;
       }

       public override bool isDiatomic() { return false; }
   }

   public class Lithium : Metal
   {
       public Lithium()
       {
           elementSymbol = "Li";
           atomicNumber = 3;
           valenceElectrons = 1;
           valenceShell = 8;
           state = 1;
           ion = ionType.CATION;
       }

        public override void reactWithNonMetal()
        {
            throw new NotImplementedException();
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
           state = 1;
           ion = ionType.CATION;
       }

        public override void reactWithNonMetal()
        {
            throw new NotImplementedException();
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
           state = 1;
           ion = ionType.NOT;
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
           state = 1;
           ion = ionType.NOT;
       }
       public override bool isDiatomic() { return false; }
   }

   public class Nitrogen : NonMetal
   {
       public Nitrogen()
       {
           elementSymbol = "N";
           atomicNumber = 7;
           valenceElectrons = 5;
           valenceShell = 8;
           state = 1;
           ion = ionType.ANION;
       }

       public override bool isDiatomic() { return true; }
   }

   public class Oxygen : NonMetal
   {
       public Oxygen()
       {
           elementSymbol = "O";
           atomicNumber = 8;
           valenceElectrons = 6;
           valenceShell = 8;
           state = 1;
           ion = ionType.ANION;
       }

       public override bool isDiatomic() { return true; }
   }

   public class Fluorine : NonMetal
   {
       public Fluorine()
       {
           elementSymbol = "F";
           atomicNumber = 9;
           valenceElectrons = 7;
           valenceShell = 8;
           state = 1;
           ion = ionType.ANION;
       }

       public override bool isDiatomic() { return true; }
   }

   public class Neon : NonMetal
   {
       public Neon()
       {
           elementSymbol = "Ne";
           atomicNumber = 10;
           valenceElectrons = 8;
           valenceShell = 8;
           state = 1;
           ion = ionType.NOT;
       }
       public override bool isDiatomic() { return false; }
   }
}
