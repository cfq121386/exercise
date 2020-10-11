using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2_8
{
    class Divide
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
        public float divide(int x, int y)
        {
            return x / y;
        }
    }
}
