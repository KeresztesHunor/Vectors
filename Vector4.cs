using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector4<T> : IEquatable<Vector4<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public Vector3<T> xyz { get; }
        public T w { get; }

        public Vector4(T x, T y, T z, T w) : this(new Vector3(x, y, z), w)
        {

        }

        public Vector4(Vector2<T> xy, T z, T w) : this(xy.x, xy.y, z, w)
        {

        }

        public Vector4(T x, Vector2<T> yz, T z) : this(x, yz.x, yz.y, w)
        {

        }

        public Vector4(T x, T y, Vector2<T> zw) : this(x, y, zw.x, zw.y)
        {

        }

        public Vector4(Vector2<T> xy, Vector2<T> zw) : this(xy.x, xy.y, zw.x, zw.y)
        {

        }

        public Vector4(T x, Vector3<T> yzw) : this(x, yzw.x, yzw.y, yzw.z)
        {

        }

        public Vector4(Vector3<T> xyz, T w)
        {
            this.xyz = xyz;
            this.w = w;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Vector4<T> other)
        {
            return this == other;
        }

        public static bool operator ==(Vector4<T> left, Vector4<T> right) => left.xyz == right.xyz && left.w.Equals(right.w);
        public static bool operator !=(Vector4<T> left, Vector4<T> right) => left.xyz != right.xyz || !left.w.Equals(right.w);
    }
}