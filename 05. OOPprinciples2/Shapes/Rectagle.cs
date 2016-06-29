using System;

namespace Shapes
{
    public class Rectagle : Shapes
    {
        public Rectagle(float height, float width) : base(height, width)
        {
        }

        public override float CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
