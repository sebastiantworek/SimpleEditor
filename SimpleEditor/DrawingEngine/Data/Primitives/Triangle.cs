using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DrawingEngine;
using DrawingEngine.Primitives;

namespace DataModel.Elements
{
    public class Triangle : Primitive
    {
        public PointF A { get; set; }

        public PointF B { get; set; }

        public PointF C { get; set; }

        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(A, B, Color, LineStyle);
            graphics.DrawLine(B, C, Color, LineStyle);
            graphics.DrawLine(C, A, Color, LineStyle);
        }
    }
}
