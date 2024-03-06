using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangbluble
    {
        public int width;
        public int height;

        public int Getarea ()
        { 
            int area = width * height;
            return area;
        }

        public float Ratio() 
        {
            float ratio = height / width;
            return ratio;
        }

    }
}
