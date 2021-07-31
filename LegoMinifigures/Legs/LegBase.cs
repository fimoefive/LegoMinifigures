using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace LegoMinifigures.Legs

{
    abstract class LegBase
    {
        public Bottoms Bottoms { get; set; }
        public Shoes Kicks { get; set; }

        public virtual void Dance()
        {
            Console.WriteLine("Start doing the Electric Slide.");
        }
        public abstract void Walk();

    }
}
