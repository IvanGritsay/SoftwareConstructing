using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public class Circle : Shape
    {
        private float radius;

        public Circle(IRenderer renderer, float radius) : base(renderer, "Circle")
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.Render(shapeType, radius);
        }
    }
}
