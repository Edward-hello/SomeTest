using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTest
{
    class Vector3D
    {
        private  float x, y, z;
        
        public Vector3D(float x = 0f, float y = 0f, float z = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D(Vector3D vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = vec.z;
        }

        public Vector3D Add(Vector3D vec)
        {
            Vector3D ret = new Vector3D(x, y, z);
            ret.x += vec.x;
            ret.y += vec.y;
            ret.z += vec.z;
            return ret;
        }

        public override string ToString()
        {
            return string.Format("(" + x + "," + y + "," + z + ")");
        }

        public static Vector3D operator +(Vector3D lv, Vector3D rv)
        {
            return lv.Add(rv);
        }
    }
}
