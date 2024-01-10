using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector3<T> : IEquatable<Vector3<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T x { get => xy.x; }
        public T y { get => xy.y; }
        public T z { get; }

        public double Length { get => Math.Sqrt(xd * xd + yd * yd + zd * zd); }
        double xd { get => x.ToDouble(null); }
        double yd { get => y.ToDouble(null); }
        double zd { get => z.ToDouble(null); }

        public float LengthF { get => MathF.Sqrt(xf * xf + yf * yf + zf * zf); }
        float xf { get => x.ToSingle(null); }
        float yf { get => y.ToSingle(null); }
        float zf { get => z.ToSingle(null); }

        public Vector2<T> xy { get; }
        public Vector2<T> yx { get => xy.yx; }
        public Vector2<T> xz { get => new Vector2<T>(x, z); }
        public Vector2<T> zx { get => new Vector2<T>(z, x); }
        public Vector2<T> yz { get => new Vector2<T>(y, z); }
        public Vector2<T> zy { get => new Vector2<T>(z, y); }
        public Vector3<T> xzy { get => new Vector3<T>(xz, y); }
        public Vector3<T> yxz { get => new Vector3<T>(yx, z); }
        public Vector3<T> yzx { get => new Vector3<T>(yz, x); }
        public Vector3<T> zxy { get => new Vector3<T>(zx, y); }
        public Vector3<T> zyx { get => new Vector3<T>(zy, x); }
        public Vector3<double> Normalized { get => new Vector3<double>(xd / Length, yd / Length, zd / Length); }
        public Vector3<float> NormalizedF { get => new Vector3<float>(xf / LengthF, yf / LengthF, zf / LengthF); }

        public Vector3(T x, T y, T z) : this(new Vector2<T>(x, y), z)
        {
            
        }

        public Vector3(T x, Vector2<T> yz) : this(x, yz.x, yz.y)
        {

        }

        public Vector3(Vector2<T> xy, T z)
        {
            this.xy = xy;
            this.z = z;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector3<T> v ? this == v : false;
        }

        public override int GetHashCode()
        {
            return (391 + xy.GetHashCode()) * 23 + z.GetHashCode();
        }

        public bool Equals(Vector3<T> other)
        {
            return this == other;
        }

        public override string ToString()
        {
            return xy.ToString() + ", z: " + z;
        }

        public static bool operator ==(Vector3<T> left, Vector3<T> right) => left.xy == right.xy && left.z.Equals(right.z);
        public static bool operator !=(Vector3<T> left, Vector3<T> right) => !(left == right);
        public static Vector3<T> operator +(Vector3<T> left, Vector3<T> right) => new Vector3<T>(left.xy + right.xy, (dynamic)left.z + (dynamic)right.z);
        public static Vector3<T> operator -(Vector3<T> left, Vector3<T> right) => new Vector3<T>(left.xy - right.xy, (dynamic)left.z - (dynamic)right.z);
        public static Vector3<T> operator -(Vector3<T> value) => new Vector3<T>(-value.xy, -(dynamic)value.z);
    }
}
