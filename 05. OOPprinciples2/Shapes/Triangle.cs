using System;


namespace Shapes
{
    public class Triangle : Shapes
    {
        public Triangle(float height, float width) : base(height, width)
        {
        }

        public override float CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
