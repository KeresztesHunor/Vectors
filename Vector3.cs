using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector3<T> : IEquatable<Vector3<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T x { get => xy.x; }
        public T y { get => xy.y; }
        public T z { get; }

        public Vector2<T> xy { get; }
        public Vector2<T> yx { get => xy.yx; }
        public Vector3<T> xzy { get => new Vector3<T>(xy.x, z, xy.y); }
        public Vector3<T> yxz { get => new Vector3<T>(xy.yx, z); }
        public Vector3<T> yzx { get => new Vector3<T>(xy.y, z, xy.x); }
        public Vector3<T> zxy { get => new Vector3<T>(z, xy.x, xy.y); }
        public Vector3<T> zyx { get => new Vector3<T>(z, xy.yx); }

        public Vector3(T x, T y, T z) : this(new Vector2<T>(x, y), z)
        {
            
        }

        public Vector3(T x, Vector2<T> yz) : this(new Vector2<T>(x, yz.x), yz.y) // yz.x is the y component and yz.y is the z component
        {

        }

        public Vector3(Vector2<T> xy, T z)
        {
            this.xy = xy;
            this.z = z;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Vector3<T> other)
        {
            return this == other;
        }

        public static bool operator ==(Vector3<T> left, Vector3<T> right) => left.xy == right.xy && left.z.Equals(right.z);
        public static bool operator !=(Vector3<T> left, Vector3<T> right) => left.xy != right.xy || !left.z.Equals(right.z);
    }
}
