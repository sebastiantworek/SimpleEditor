using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DrawingEngine;
using DrawingEngine.Primitives;

namespace DataModel.Elements
{
    public class Circle : Primitive
    {
        public PointF Center { get; set; }
        public float Radius { get; set; }

        public override void Draw(IGraphics graphics)
        {
            graphics.DrawCircle(Center, Radius, Color, LineStyle);
        }
    }
}
