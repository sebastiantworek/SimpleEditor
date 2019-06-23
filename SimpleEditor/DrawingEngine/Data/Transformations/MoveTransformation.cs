using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawingEngine.Data.Transformations
{
    public struct MoveTransformation: ITransformation
    {
        public float DX { get; }
        public float DY { get; }

        public MoveTransformation(float dx, float dy)
        {
            DX = dx;
            DY = dy;
        }

        public void Apply(IGraphics graphics)
        {
            graphics.MoveTransform(DX,DY);
        }
    }
}
