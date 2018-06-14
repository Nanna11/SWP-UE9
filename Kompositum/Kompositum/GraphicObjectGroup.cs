using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompositum
{
    class GraphicObjectGroup : GraphicObject
    {
        List<GraphicObject> children = new List<GraphicObject>();

        public GraphicObjectGroup()
        {
            _ObjectType = "GraphicObjectGroup";
        }

        public override void move(int x, int y)
        {
            base.move(x, y);

            foreach(GraphicObject obj in children)
            {
                obj.move(x, y);
            }
        }

        public override void Add(GraphicObject obj)
        {
            children.Add(obj);
            x = GetMaxX();
            y = GetMinY();
        }

        public override void Remove(GraphicObject obj)
        {
            children.Remove(obj);
            x = GetMaxX();
            y = GetMinY();
        }

        public override GraphicObject GetChild(int index)
        {
            return children[index];
        }

        private int GetMaxX()
        {
            int? max = null;

            foreach (GraphicObject obj in children)
            {
                if(max == null)
                {
                    max = obj.xCoordinate;
                    continue;
                }else if(max < obj.xCoordinate)
                {
                    max = obj.xCoordinate;
                }
            }

            return max ?? 0;
        }

        private int GetMinY()
        {
            int? min = null;

            foreach (GraphicObject obj in children)
            {
                if (min == null)
                {
                    min = obj.yCoordinate;
                    continue;
                }
                else if (min > obj.yCoordinate)
                {
                    min = obj.yCoordinate;
                }
            }

            return min ?? 0;
        }
    }
}
