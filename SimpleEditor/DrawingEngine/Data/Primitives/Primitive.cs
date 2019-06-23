using System.Drawing;
using DrawingEngine.Attributes;
using Utils;

namespace DrawingEngine.Primitives
{
    public abstract class Primitive : IDrawable
    {
        public Color Color { get; set; }
        public LineStyle LineStyle { get; set; }

        public ulong ID { get; }

        public Primitive()
        {
            ID = RandomUtils.GenerateID();
        }
                

        public abstract void Draw(IGraphics graphics);
    }
}
