using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeType, params float[] dimensions)
        {
            Console.WriteLine($"Drawing {shapeType} as vector with dimensions: {string.Join(", ", dimensions)}");
        }
    }
}
