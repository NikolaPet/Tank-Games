﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ArcadeGamez_Featuring_Marko_and_Nikola
{
    public class GrassBlock : Block
    {
        public GrassBlock(int x, int y, int width, int height) : base(x, y, width, height) { }

        public override BlockType Type()
        {
            return BlockType.GRASS;
        }
    }
}
