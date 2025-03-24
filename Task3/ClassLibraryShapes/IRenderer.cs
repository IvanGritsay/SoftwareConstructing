using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    public interface IRenderer
    {
        void Render(string shapeType, params float[] dimensions);
    }
}
