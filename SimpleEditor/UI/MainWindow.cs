using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel.Elements;

namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //TODO replace with proper data loading
            _editor.AddElement(new Line() { A = new PointF(10, 10), B = new PointF(200, 200), Color = Color.Red, LineStyle = DrawingEngine.Attributes.LineStyle.Plain });
            _editor.AddElement(new Circle() { Center = new PointF(750, 100), Radius = 100, Color = Color.Black, LineStyle = DrawingEngine.Attributes.LineStyle.Dash });
            _editor.AddElement(new Triangle() { A = new PointF(100, 300), B = new PointF(300, 300), C = new PointF(400,400), Color = Color.Blue, LineStyle = DrawingEngine.Attributes.LineStyle.Dots });
        }
    }
}
