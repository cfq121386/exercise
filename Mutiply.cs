using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2_8
{
    class Mutiply
    {
        private float _x;
        private float _y;
        protected float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        protected float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float mutiply(int x, int y)
        {
            return x * y;
        }
    }
}
