using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        protected string shapeType;

        public Shape(IRenderer renderer, string shapeType)
        {
            this.renderer = renderer;
            this.shapeType = shapeType;
        }

        public abstract void Draw();
    }
}
