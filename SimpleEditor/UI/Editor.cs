using DataModel.Elements;
using GDIPlusGraphicsWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class Editor : Panel
    {
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

        private void RefreshGraphics(PaintEventArgs e)
        {
            if (_graphicsWrapper == null)
                _graphicsWrapper = new GDIGraphicsWrapper(e.Graphics);
            else
                _graphicsWrapper.Graphics = e.Graphics;

            if (_drawingEngine.Graphics == null)
                _drawingEngine.Graphics = _graphicsWrapper;
        }

        public void AddElement(Element element)
        {
            _drawingEngine.AddPrimitive(element);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _graphicsWrapper.Dispose();
        }
    }
}
