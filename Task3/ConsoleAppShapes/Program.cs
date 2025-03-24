using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryShapes;

namespace ConsoleAppShapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            Shape vectorCircle = new Circle(vectorRenderer, 5);
            Shape rasterSquare = new Square(rasterRenderer, 10);
            Shape vectorTriangle = new Triangle(vectorRenderer, 8, 6);

            vectorCircle.Draw();
            rasterSquare.Draw();
            vectorTriangle.Draw();
        }
    }
}
