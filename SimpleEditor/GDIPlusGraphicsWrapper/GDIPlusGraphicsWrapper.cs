using DrawingEngine;
using DrawingEngine.Attributes;
using GDIPlusGraphicsWrapper;
using System;
using System.Drawing;

namespace GDIPlusGraphicsWrapper
{
    public class GDIGraphicsWrapper : IGraphics, IDisposable
    {
        public Graphics Graphics { get; set; }

        protected readonly PenManager _penManager = new PenManager();


        public GDIGraphicsWrapper() : this(null)
        {

        }

        public GDIGraphicsWrapper(Graphics graphics)
        {
            Graphics = graphics;
        }

        public void DrawCircle(PointF center, float radius, Color color, LineStyle lineStyle)
        {
            Graphics.DrawEllipse(_penManager.GetPen(color, lineStyle), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        }

        public void DrawLine(PointF a, PointF b, Color color, LineStyle lineStyle)
        {
            Graphics.DrawLine(_penManager.GetPen(color, lineStyle), a, b);
        }

        public void Dispose()
        {
            _penManager.Dispose();
        }

        public void ScaleTransform(float scale)
        {
            Graphics.ScaleTransform(scale, scale);
        }

        public void MoveTransfrom(float dx, float dy)
        {
            Graphics.TranslateTransform(dx, dy);
        }
    }
}
