using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClass
{
    enum HeldType {Barbaar, Elf, Dwerg, Tovenaar };
    class Held
    {
        public string Beschriijving { get; private set; }
        public string Naam { get; set; }
        public int MaxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        
        public HeldType HeldType { get; private set; }
        public int AanvalDobbelSteen { get; private set; } = 2;
        public int VerdedigingDobbelSteen { get; private set; } = 2;
        public int LoopDobbelsteen { get; private set; } = 2;
    }
}
