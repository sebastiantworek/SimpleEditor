using DrawingEngine;
using DrawingEngine.Attributes;
using GDIPlusGraphicsWrapper;
using System;
using System.Drawing;

namespace DrawingEngineGDIPlus
{
    public class GDIGraphicsWrapper : IGraphics, IDisposable
    {
        protected readonly Graphics _graphics;
        protected readonly PenManager _penManager = new PenManager();
        public GDIGraphicsWrapper(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void DrawCircle(PointF center, float radius, Color color, LineStyle lineStyle)
        {
            _graphics.DrawEllipse(_penManager.GetPen(color, lineStyle), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }

        public void DrawLine(PointF a, PointF b, Color color, LineStyle lineStyle)
        {
            _graphics.DrawLine(_penManager.GetPen(color, lineStyle), a, b);
        }

        public void Dispose()
        {
            _penManager.Dispose();
            _graphics.Dispose();
        }
    }
}
