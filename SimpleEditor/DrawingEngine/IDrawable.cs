using System;

namespace DrawingEngine
{
    public interface IDrawable
    {
        void Draw(IGraphics graphics);

        ulong ID { get; }
    }
}
