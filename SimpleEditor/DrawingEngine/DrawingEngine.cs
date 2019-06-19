using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingEngine
{
    public class DrawingEngine
    {
        private Dictionary<ulong, IDrawable> _primitives = new Dictionary<ulong, IDrawable>();
        private readonly IGraphics _graphics;

        public DrawingEngine(IGraphics graphics)
        {
            _graphics = graphics;
        }

        public void AddPrimitive(IDrawable drawable)
        {
            _primitives.Add(drawable.ID, drawable);
        }

        public void RemovePrimitive(ulong id)
        {
            _primitives.Remove(id);
        }

        public void ModifiePrimitive(IDrawable drawable)
        {
            if (!_primitives.ContainsKey(drawable.ID))
                throw new ArgumentOutOfRangeException();

            _primitives[drawable.ID] = drawable;
        }

        public void Draw()
        {
            //TODO add transformation
            foreach(var kvp in _primitives)
            {
                kvp.Value.Draw(_graphics);
            }
        }
    }
}
