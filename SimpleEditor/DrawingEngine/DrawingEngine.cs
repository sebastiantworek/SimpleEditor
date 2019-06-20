using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingEngine
{
    public class DrawingEngine
    {
        #region Members

        private Dictionary<ulong, IDrawable> _primitives = new Dictionary<ulong, IDrawable>();
        public IGraphics Graphics { get; set; }

        #endregion

        #region Constructors

        public DrawingEngine() : this(null)
        {

        }

        public DrawingEngine(IGraphics graphics)
        {
            Graphics = graphics;
        }

        #endregion

        #region Methods

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
            if (Graphics == null)
                return;

            //TODO add transformation
            foreach(var kvp in _primitives)
            {
                kvp.Value.Draw(Graphics);
            }
        }

        #endregion
    }
}
