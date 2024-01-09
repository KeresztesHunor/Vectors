using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector2<T> : IEquatable<Vector2<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T x { get; }
        public T y { get; }

        public Vector2<T> yx { get => new Vector2<T>(y, x); }

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
            return base.GetHashCode();
        }

        public bool Equals(Vector2<T> other)
        {
            return this == other;
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right) => left.x.Equals(right.x) && left.y.Equals(right.y);
        public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);
        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right) => new Vector2<T>((dynamic)left.x + (dynamic)right.x, (dynamic)left.y + (dynamic)right.y);
        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right) => new Vector2<T>((dynamic)left.x - (dynamic)right.x, (dynamic)left.y - (dynamic)right.y);
    }
}
