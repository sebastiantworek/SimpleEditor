using DrawingEngine;
using DrawingEngine.Attributes;
using System.Drawing;
using Utils;

namespace DataModel.Elements
{
    public abstract class Element : IDrawable
    {
        public Color Color { get; set; }
        public LineStyle LineStyle { get; set; }

        public ulong ID { get; }

        public Element()
        {
            ID = RandomUtils.GenerateID();
        }
                

        public abstract void Draw(IGraphics graphics);
    }
}
