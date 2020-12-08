﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight
{
    class BlueBox : Box
    {
        public BlueBox(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.boxColor = BoxColor.Blue;
        }

        public override void Draw(int locationX, int locationY)
        {
            Console.WriteLine($"{boxColor} box drawn. {locationX}, {locationY}");
        }
    }
}
