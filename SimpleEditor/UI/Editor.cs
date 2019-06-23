using DataModel.Elements;
using GDIPlusGraphicsWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingEngine.Primitives;

namespace UI
{
    public class Editor : Panel
    {
        public const float ScrollStep = 0.2f;

        protected  GDIGraphicsWrapper _graphicsWrapper;

        protected DrawingEngine.DrawingEngine _drawingEngine;

        public Editor()
        {
            _drawingEngine = new DrawingEngine.DrawingEngine();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RefreshGraphics(e);

            _drawingEngine.Draw();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            _drawingEngine.Zoom(e.Delta>0 ? 1f+ ScrollStep : 1f- ScrollStep);
            Invalidate();
        }

        private void RefreshGraphics(PaintEventArgs e)
        {
            if (_graphicsWrapper == null)
                _graphicsWrapper = new GDIGraphicsWrapper(e.Graphics);
            else
                _graphicsWrapper.Graphics = e.Graphics;

            _drawingEngine.Graphics = _graphicsWrapper;
        }

        public void AddElement(Primitive primitive)
        {
            _drawingEngine.Add(primitive);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _graphicsWrapper.Dispose();
        }
    }
}
