using DrawingEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace GDIPlusGraphicsWrapper
{
    public class PenManager : IDisposable
    {
        private readonly Dictionary<(Color, LineStyle), Pen> _pens = new Dictionary<(Color, LineStyle), Pen>();

        public Pen GetPen(Color color, LineStyle lineStyle)
        {
            var key = (color, lineStyle);
            if (!_pens.ContainsKey(key))
            {
                _pens[key] = new Pen(color) { DashStyle = ConvertLineStyle(lineStyle) };
            }
            return _pens[key];
        }

        private static DashStyle ConvertLineStyle(LineStyle lineStyle)
        {
            switch(lineStyle)
            {
                case LineStyle.Dash:
                    return DashStyle.Dash;
                case LineStyle.Dots:
                    return DashStyle.Dot;
                case LineStyle.Plain:
                    return DashStyle.Solid;
            }

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            foreach(var kvp in _pens)
            {
                kvp.Value.Dispose();
            }

            _pens.Clear();
        }
    }
}
