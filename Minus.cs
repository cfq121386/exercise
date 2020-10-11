using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2_8
{
    class Minus
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
        public float minus(int x, int y)
        {
            return x - y;
        }
        public void minus(string x1, string x2)
        {
            bool a = x1.Contains(x2);
            string x3;
            if (a)
            {
                int i = x1.IndexOf(x2);
                x3 = x1.Remove(i,x2.Length);
                minus(x3, x2);
                if (!x3.Contains(x2))
                {
                    Console.WriteLine(x3.ToString());
                }
            }
        }
    }
}
