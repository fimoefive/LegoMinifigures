using System;
using System.Collections.Generic;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ConstructionWorkerHead();    
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
            batmanTorso.Color = LegoColor.head;
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

        }
    }
}
