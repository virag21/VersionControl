﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week08_GXMRLU.Abstractions;

namespace Week08_GXMRLU.Entities
{
    class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color boxColor, Color ribbonColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbonColor);
        }
        protected override void DrawImage(Graphics g)
        {
            Rectangle rect = new Rectangle(0, 0, 200, 200);
            g.FillRectangle(BoxColor, rect);
            Rectangle ribbon1 = new Rectangle(0, 80, 40, 40);
            g.FillRectangle(RibbonColor, rect);
            Rectangle ribbon2 = new Rectangle(80, 0, 40, 40);
            g.FillRectangle(RibbonColor, rect);
        }
    }
}
