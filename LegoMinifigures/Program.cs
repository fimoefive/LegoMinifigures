using System;
using System.Collections.Generic;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();    
            workerHead.Color = LegoColor.Yellow;
            var batmanHead = new BatmanHead();
            var astronautHead = new AstronautHead();
            var heads = new List<HeadBase>() { astronauntHead, batmanHead, workerHead };

            foreach ( var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
            var batmanTorso = new BatSuitTorso();
            batmanTorso.Color = LegoColor.Green;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();
            var sumoTorso = new SumoTorso();
            var torsos = new List<TorsoBase>() { batmanTorso, cowboyTorso, sumoTorso };
            foreach(var torso in torsos)
            {
                torso.Greeting();
                torso.Wiggle();
            }

            var seaLeg = new SeaLeg();
            seaLeg.Arewabely = true;
            seaLeg.Bottoms = Bottoms.Chaps;
            seaLeg.NumberOfLegs = 3;
            seaLeg.Kicks = Shoes.SteeltoeAddidas;

            var magicLeg = new MagicLeg();
            magicLeg.Bottoms = Bottoms.Chaps; //this is magical
            magicLegLeg.HasInvisibleLegs = true;
            magicLeg.Measuring = ("small");
                Console.WriteLine($"Magic legs has length of {magicLeg.Length}.");

            var legs = new List<LegBase>() { seaLeg, magicLeg };

            foreach (var leg in legs)
            {
                leg.Dance();
                leg.Walk();
            }

            Console.WriteLine("Before Bob.");


            //var bob = new Minifigure(workerHead, cowboyTorso, new SeaLeg());
            var bob = new Minifigure(workerHead, cowboyTorso, seaLeg);
            bob.BuildIt();


            Console.WriteLine("You just saw Bob do his thang!");
            Console.ReadLine();

        }
    }
}
