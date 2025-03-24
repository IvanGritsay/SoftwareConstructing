using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public class Triangle : Shape
    {
        private float baseLength;
        private float height;

        public Triangle(IRenderer renderer, float baseLength, float height) : base(renderer, "Triangle")
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override void Draw()
        {
            renderer.Render(shapeType, baseLength, height);
        }
    }
}
