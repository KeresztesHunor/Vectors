using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector2<T> : IEquatable<Vector2<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T x { get; }
        public T y { get; }
        public double Length { get => Math.Sqrt(xd * xd + yd + yd); }
        double xd { get => x.ToDouble(null); }
        double yd { get => y.ToDouble(null); }

        public float LengthF { get => MathF.Sqrt(xf * xf + yf * yf); }
        float xf { get => x.ToSingle(null); }
        float yf { get => y.ToSingle(null); }

        public Vector2<T> yx { get => new Vector2<T>(y, x); }
        public Vector2<double> Normalized { get => new Vector2<double>(xd / Length, yd / Length); }
        public Vector2<float> NormalizedF { get => new Vector2<float>(xf / LengthF, yf / LengthF); }

        public Vector2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); // TODO: check how the "GetHashCode" method works and correct code accordingly
        }

        public bool Equals(Vector2<T> other)
        {
            return this == other; // TODO: check how overloading the "=="/"!=" operators and the "Equals" method work and correct code accordingly
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right) => left.x.Equals(right.x) && left.y.Equals(right.y);
        public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);
        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right) => new Vector2<T>((dynamic)left.x + (dynamic)right.x, (dynamic)left.y + (dynamic)right.y);
        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right) => new Vector2<T>((dynamic)left.x - (dynamic)right.x, (dynamic)left.y - (dynamic)right.y);
        public static Vector2<T> operator -(Vector2<T> value) => new Vector2<T>(-(dynamic)value.x, -(dynamic)value.y);
    }
}
