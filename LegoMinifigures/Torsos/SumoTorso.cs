using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegoMinifigures.Heads;

namespace LegoMinifigures.Torsos
{
    class SumoTorso : TorsoBase
    {
        public bool AreTHeyThicc { get; set; }
        public LegoColor Fundoshi { get; set; }

        public override void Wiggle()
        {
            Console.WriteLine("Sumo, does their smiko before match");
        }
        public void FightPrep()
        {
            Console.WriteLine("Before the fight, pour down salt");
        }
    }
}
