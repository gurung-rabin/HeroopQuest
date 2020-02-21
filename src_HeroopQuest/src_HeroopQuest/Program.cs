using src_HeroopQuest.GameClass;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(HeldType.Barbaar, "Gron");
            Held held2 = new Held(HeldType.Tovenaar, "Inon");
            Console.WriteLine(held1.AanvalDobbelSteen);
            Console.WriteLine(held2.HeldType);
        }
    }
}
