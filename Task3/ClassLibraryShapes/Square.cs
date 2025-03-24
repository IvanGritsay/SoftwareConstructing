using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public class Square : Shape
    {
        private float side;

        public Square(IRenderer renderer, float side) : base(renderer, "Square")
        {
            this.side = side;
        }

        public override void Draw()
        {
            renderer.Render(shapeType, side);
        }
    }
}
