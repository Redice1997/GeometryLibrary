using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Interfaces
{
    //Фракталы не двумерны
    internal interface IShape2D : IHavePerimeter, IHaveSquare
    {
    }
}
