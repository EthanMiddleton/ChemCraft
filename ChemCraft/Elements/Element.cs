using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public abstract class Element : Card
    {
        public enum elementStates { SOLID, LIQUID, GAS, AQUEOUS };
        public enum ionType { ANION, CATION, NOT };

        /* public abstract Element transmute();
        public abstract void attack();
        public abstract void defense(); */

        String ElementSymbol, ElementName;
        int AtomicNumber, ValenceElectrons, ValenceShell, State;
        ionType Ion;
        int id;

        #region Properties
        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public String elementSymbol
        {
            protected set { ElementSymbol = value; }
            get { return ElementSymbol; }
        }

        public String elementName
        {
            protected set { ElementName = value; }
            get { return ElementName; }
        }

        public int atomicNumber
        {
            protected set { AtomicNumber = value; }
            get { return AtomicNumber; }
        }

        public int valenceElectrons
        {
            protected set { ValenceElectrons = value; }
            get { return ValenceElectrons; }
        }

        public int valenceShell
        {
            protected set { ValenceShell = value; }
            get { return ValenceShell; }
        }

        public int state
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
            elementName = "Hydrogen";
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
            elementName = "Helium";
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
            elementName = "Lithium";
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
            elementName = "Beryllium";
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
            elementName = "Boron";
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
            elementName = "Carbon";
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
            elementName = "Nitrogen";
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
            elementName = "Oxygen";
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
            elementName = "Fluorine";
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
            elementName = "Neon";
            atomicNumber = 10;
            valenceElectrons = 8;
            valenceShell = 8;
            state = 1;
            ion = ionType.NOT;
        }
        public override bool isDiatomic() { return false; }
    }
    
    public class Sodium : Metal
    {
        public Sodium()
        {
            elementSymbol = "Na";
            elementName = "Sodium";
            atomicNumber = 11;
            valenceElectrons = 1;
            valenceShell = 8;
            State = 1;
            ion = ionType.CATION;
        }

        public override bool isDiatomic() { return true; }
    }

    public class Magnesium : Metal
    {
        public Magnesium()
        {
            elementSymbol = "Mg";
            elementName = "Magnesium";
            atomicNumber = 12;
            valenceElectrons = 2;
            valenceShell = 8;
            State = 1;
            ion = ionType.CATION;
        }

        public override bool isDiatomic() { return false; }
    }

    public class Aluminum : Metal
    {
        public Aluminum()
        {
            elementSymbol = "Al";
            elementName = "Aluminum";
            atomicNumber = 13;
            valenceElectrons = 3;
            valenceShell = 8;
            State = 1;
            ion = ionType.CATION;
        }

        public override void reactWithNonMetal()
        {
            throw new NotImplementedException();
        }
    }

    public class Silicon : Metalloid
    {
        public Silicon()
        {
            elementSymbol = "Si";
            elementName = "Silicon";
            atomicNumber = 14;
            valenceElectrons = 4;
            valenceShell = 8;
            State = 1;
            ion = ionType.NOT;
        }

        public override void reactWithNonMetal()
        {
            throw new NotImplementedException();
        }
    }

    public class Phosphorus : NonMetal
    {
        public Phosphorus()
        {
            elementSymbol = "P";
            elementName = "Phosphorus";
            atomicNumber = 15;
            valenceElectrons = 5;
            valenceShell = 8;
            State = 1;
            ion = ionType.ANION;
        }
    }

    public class Sulphur : NonMetal
    {
        public Sulphur()
        {
            elementSymbol = "S";
            elementName = "Sulphur";
            atomicNumber = 16;
            valenceElectrons = 6;
            valenceShell = 8;
            State = 1;
            ion = ionType.ANION;
        }
        public override bool isDiatomic() { return false; }
    }

    public class Chlorine : NonMetal
    {
        public Chlorine()
        {
            elementSymbol = "Cl";
            elementName = "Chlorine";
            atomicNumber = 17;
            valenceElectrons = 7;
            valenceShell = 8;
            State = 1;
            ion = ionType.ANION;
        }

        public override bool isDiatomic() { return true; }
    }

    public class Argon : NonMetal
    {
        public Argon()
        {
            elementSymbol = "Ar";
            elementName = "Argon";
            atomicNumber = 18;
            valenceElectrons = 8;
            valenceShell = 8;
            State = 1;
            ion = ionType.NOT;
        }

        public override bool isDiatomic() { return true; }
    }

    public class Potassium : Metal
    {
        public Potassium()
        {
            elementSymbol = "K";
            elementName = "Potassium";
            atomicNumber = 19;
            valenceElectrons = 1;
            valenceShell = 8;
            State = 1;
            ion = ionType.CATION;
        }

        public override bool isDiatomic() { return true; }
    }

    public class Calcium : Metal
    {
        public Calcium()
        {
            elementSymbol = "Ca";
            elementName = "Calcium";
            atomicNumber = 20;
            valenceElectrons = 2;
            valenceShell = 8;
            State = 1;
            ion = ionType.CATION;
        }
        public override bool isDiatomic() { return false; }
    }
}
