using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingEngine.Data.Transformations
{
    public struct ScaleTransformation: ITransformation
    {
        public float Scale { get; set; }

        public ScaleTransformation(float scale)
        {
            Scale = scale;
        }

        public void Apply(IGraphics graphics)
        {
            graphics.ScaleTransform(Scale);
        }
    }
}
