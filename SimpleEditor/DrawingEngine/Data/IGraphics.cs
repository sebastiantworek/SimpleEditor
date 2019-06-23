using DrawingEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawingEngine
{
    public interface IGraphics
    {
        void DrawLine(PointF a, PointF b, Color color, LineStyle lineStyle);

        void DrawCircle(PointF center, float radius, Color color, LineStyle lineStyle);

        void ScaleTransform(float scale);

        void MoveTransform(float x, float y);

        void ResetTransform();
    }
}
