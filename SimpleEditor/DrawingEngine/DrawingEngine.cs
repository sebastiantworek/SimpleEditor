using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DrawingEngine.Data.Transformations;

namespace DrawingEngine
{
    public class DrawingEngine
    {
        #region Members

        private readonly Dictionary<ulong, IDrawable> _primitives = new Dictionary<ulong, IDrawable>();

        private IGraphics _graphics;

        public IGraphics Graphics
        {
            get => _graphics;
            set
            {
                _graphics = value;

                ApplyTransformations();
            }
        }

        private void ApplyTransformations()
        {
            if (_graphics == null)
                return;

            _graphics.ResetTransform();
            _zoomTransformation.Apply(_graphics);
        }

        protected ScaleTransformation _zoomTransformation =  new ScaleTransformation(1);

        #endregion

        #region Constructors

        public DrawingEngine() : this(null)
        {

        }

        public DrawingEngine(IGraphics graphics)
        {
            Graphics = graphics;

            _zoomTransformation = ScaleTransform(1);
        }

        #endregion

        #region Methods

        public void Add(IDrawable drawable)
        {
            _primitives.Add(drawable.ID, drawable);
        }

        public void Remove(ulong id)
        {
            _primitives.Remove(id);
        }

        public void Modify(IDrawable drawable)
        {
            if (!_primitives.ContainsKey(drawable.ID))
                throw new ArgumentOutOfRangeException();

            _primitives[drawable.ID] = drawable;
        }

        public void Draw()
        {
            if (Graphics == null)
                return;

            ApplyTransformations();

            foreach (var kvp in _primitives)
            {
                kvp.Value.Draw(Graphics);
            }
        }

        public void Zoom(float scale)
        {
            _zoomTransformation.Scale *= scale;
        }

        protected ScaleTransformation ScaleTransform(float scale)
        {
            var scaleTransformation = new ScaleTransformation(scale);
            if (Graphics != null)
                scaleTransformation.Apply(Graphics);
            return scaleTransformation;
        }

        protected MoveTransformation MoveTransform(float x, float y)
        {
            var moveTransformation = new MoveTransformation(x, y);
            if(Graphics!= null)
                moveTransformation.Apply(Graphics);
            return moveTransformation;
        }

        #endregion
    }
}
