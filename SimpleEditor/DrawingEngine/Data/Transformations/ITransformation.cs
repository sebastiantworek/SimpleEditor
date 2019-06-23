using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingEngine.Data.Transformations
{
    public interface ITransformation
    {
        void Apply(IGraphics graphics);
    }
}
