using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeType, params float[] dimensions)
        {
            Console.WriteLine($"Drawing {shapeType} as pixels with dimensions: {string.Join(", ", dimensions)}");
        }
    }
}
