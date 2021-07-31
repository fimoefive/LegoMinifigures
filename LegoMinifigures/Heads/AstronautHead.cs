using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    class AstronautHead : HeadBase
    {
        //public LegoColor Color { get; set; }
        public bool WearingHelment { get; set; }
        public FacialHair FacialHair { get; set; } 

        public void SayHi()
        {
            Console.WriteLine("Major Tom to Ground Control...");
        }
        public void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos...");
        }
        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}.");
            FacialHair = FacialHair.None;
        }

    }
}
