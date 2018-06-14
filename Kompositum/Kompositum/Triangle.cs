using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompositum
{
    internal class Triangle : SimpleGraphicObject
    {
        public Triangle(int x, int y) : base(x, y)
        {
            _ObjectType = "Triangle";
        }
    }
}
