using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC_Helper_2.Classes
{
    [Serializable]
    public class Point
    {

        const string G01 = "G01";
        const string G02 = "G02";
        const string G03 = "G03";

        public float xLoc;
        public float yLoc;
        public float zLoc;
        public float rValue;
        public string code;

        public Point(float x, float y, float z, float r, string gcode)
        {
            xLoc = x;
            yLoc = y;
            zLoc = z;
            rValue = r;
            code = gcode;
        }
    }
}
