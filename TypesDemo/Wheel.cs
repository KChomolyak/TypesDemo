using System;
using System.Collections.Generic;
using System.Text;

namespace TypesDemo
{
    class Wheel:Circle
    {
        public float WidthWheel;

        public string TypeOfWheel;
        public Wheel(string Type)
        {
            TypeOfWheel = Type;
        }

        public Wheel(string Type, float Width)
        {
            TypeOfWheel = Type;
            WidthWheel = Width;
        }

        public Wheel(string Type, float Width, float Radius)
        {
            TypeOfWheel = Type;
            WidthWheel = Width;
            CircleRadius = Radius;
        }

    }

}
