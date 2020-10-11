using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2_8
{
    class Add
    {
        #region
        private float _x;
        protected float X
        {
            get { return _x; }
            set { _x = value; }
        }
        private string _x1;
        public string X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }
        private float _y;
        protected float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private string _y1;
        public string Y1
        {
            get { return _y1; }
            set { _y1 = value; }
        }
        #endregion
        public float add(int x, int y)
        {
            return x + y;
        }
        public string add(string x1, string y1)
        {
            //Console.WriteLine(x1+y1);
            return x1 + y1;
        }
    }
}
