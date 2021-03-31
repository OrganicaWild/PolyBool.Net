using UnityEngine;

namespace Polybool.Net.Objects
{
    public class Point
    {
        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public decimal X { get; set; }
        public decimal Y { get; set; }

        public static implicit operator Point(Vector2 value)
        {
            return new Point((decimal) value.x, (decimal) value.y);
        }

        public static implicit operator Vector2(Point value)
        {
            return new Vector2((float) value.X, (float) value.Y);
        }
    }
}