using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DrawingEngine;

namespace DataModel.Elements
{
    public class Line : Element
    {
        public PointF A { get; set; }
        public PointF B { get; set; }

        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(A, B, Color, LineStyle);
        }
    }
}
