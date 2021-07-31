﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    class BatmanHead
    {
        public bool IswearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";

        public BatmanHead()
        {
            Color = LegoColor.Black;
        }

        public override void Spin()
        {
            Console.WriteLine("Where is the joker!?!?");
        }
        public void SayHi()
        {
            Console.WriteLine("I'm Batman");
        }

    }
}
