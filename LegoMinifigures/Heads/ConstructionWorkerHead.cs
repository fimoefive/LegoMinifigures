using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads

{
    //abstract class HeadBase
    //{
    //    public LegoColor Color { get; set; }

    //    public virtual void SayHi()
    //    {
    //        Console.WriteLine("Hi.");
    //    }

    //    public abstract void Spin();
        class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not ")} wearing its hard hat.");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
                //with or without curly braces
                NumberOfTeeth -= 1;

            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
        }


        public override void SayHi()
        {
            Console.WriteLine("Contructer Worker");
        }

    }
}
