using System;


namespace Shapes
{
    public class Square : Shapes
    {
        public Square(float height) : base(height, height)
        {

        }

        public Square(float height, float width) : base(height, height)
        {
            CheckValidEntires(height, width);
        }

        public override float CalculateSurface()
        {
            return this.Height * 4;
        }


        public void CheckValidEntires(float x, float y)
        {
            if (x != y)
            {
                throw new ArgumentException("both values shold be the same!");
            }
        }
    }
}
