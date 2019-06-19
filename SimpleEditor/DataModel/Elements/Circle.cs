using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DrawingEngine;

namespace DataModel.Elements
{
    public class Circle : Element
    {
        public PointF Center { get; set; }
        public float Radius { get; set; }

        public override void Draw(IGraphics graphics)
        {
            graphics.DrawCircle(Center, Radius, Color, LineStyle);
        }
    }
}
