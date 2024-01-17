using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Interfaces
{
    // Существуют плоские фигуры без периметра (фракталы)
    internal interface IHavePerimeter 
    {
        double GetPerimeter();
    }
}
