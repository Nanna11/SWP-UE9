using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompositum
{
    class SimpleGraphicObject : GraphicObject
    {
        public SimpleGraphicObject(int x, int y)
        {
            this.x = x;
            this.y = y;

            _ObjectType = "SimpleGraphicObject";
        }

        public override void Add(GraphicObject obj)
        {
            throw new Exception();
        }

        public override void Remove(GraphicObject obj)
        {
            throw new Exception();
        }

        public override GraphicObject GetChild(int index)
        {
            throw new Exception();
        }
    }
}
