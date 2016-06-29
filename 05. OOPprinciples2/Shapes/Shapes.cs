using System;
using System.Collections.Generic;

namespace Shapes
{
    public abstract class Shapes
    {
        private float width;
        private float height;
 

        public Shapes(float height, float width)
        {
            this.Height = height;
            this.Width = width;
        }

        public float Width { get { return this.width; } set { this.width = value; } }
        public float Height { get { return this.height; } set { this.height = value; } }


        public abstract float CalculateSurface();

    }
}
