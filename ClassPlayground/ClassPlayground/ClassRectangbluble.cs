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

        public int getarea ()
        { 
            int area = width * height;
            return area;
        }

        public float ratio() 
        {
            float ratio = height / width;
            return ratio;
        }

    }
}
