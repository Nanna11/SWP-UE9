using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompositum
{
    class GraphicObject
    {
        protected int x = 0;
        protected int y = 0;

        protected string _ObjectType = "GraphicObject";

        public virtual void move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public virtual void Add(GraphicObject obj)
        {

        }

        public virtual void Remove(GraphicObject obj)
        {

        }

        public virtual GraphicObject GetChild(int index)
        {
            return null;
        }

        public int xCoordinate
        {
            get
            {
                return x;
            }
        }

        public int yCoordinate
        {
            get
            {
                return y;
            }
        }

        public string ObjectType
        {
            get
            {
                return _ObjectType;
            }
        }

        public string Coordinates
        {
            get
            {
                return "(" + xCoordinate + ";" + yCoordinate + ")";
            }
        }
    }
}
