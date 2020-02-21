using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClass
{
    enum HeldType {Barbaar, Elf, Dwerg, Tovenaar };
    class Held
    {
        public Held (HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobbelSteen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Tovenaar:
                    AanvalDobbelSteen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }
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
