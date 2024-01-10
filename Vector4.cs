using System;
using System.Collections.Generic;

namespace Vectors
{
    struct Vector4<T> : IEquatable<Vector4<T>> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        public T x { get => xyz.x; }
        public T y { get => xyz.y; }
        public T z { get => xyz.z; }
        public T w { get; }

        public double Length { get => Math.Sqrt(xd * xd + yd * yd + zd * zd + wd * wd); }
        double xd { get => x.ToDouble(null); }
        double yd { get => y.ToDouble(null); }
        double zd { get => z.ToDouble(null); }
        double wd { get => w.ToDouble(null); }

        public float LengthF { get => MathF.Sqrt(xf * xf + yf * yf + zf * zf + wf * wf); }
        float xf { get => x.ToSingle(null); }
        float yf { get => y.ToSingle(null); }
        float zf { get => z.ToSingle(null); }
        float wf { get => w.ToSingle(null); }

        public Vector2<T> xy { get => xyz.xy; }
        public Vector2<T> xz { get => xyz.xz; }
        public Vector2<T> xw { get => new Vector2<T>(x, w); }
        public Vector2<T> yx { get => xyz.yx; }
        public Vector2<T> yz { get => xyz.yz; }
        public Vector2<T> yw { get => new Vector2<T>(y, w); }
        public Vector2<T> zx { get => xyz.zx; }
        public Vector2<T> zy { get => xyz.zy; }
        public Vector2<T> zw { get => new Vector2<T>(z, w); }
        public Vector2<T> wx { get => new Vector2<T>(w, x); }
        public Vector2<T> wy { get => new Vector2<T>(w, y); }
        public Vector2<T> wz { get => new Vector2<T>(w, z); }
        public Vector3<T> xyz { get; }
        public Vector3<T> xyw { get => new Vector3<T>(xy, w); }
        public Vector3<T> xzy { get => xyz.xzy; }
        public Vector3<T> xzw { get => new Vector3<T>(xz, w); }
        public Vector3<T> xwy { get => new Vector3<T>(xw, y); }
        public Vector3<T> xwz { get => new Vector3<T>(xw, z); }
        public Vector3<T> yxz { get => xyz.yxz; }
        public Vector3<T> yxw { get => new Vector3<T>(yx, w); }
        public Vector3<T> yzx { get => xyz.yzx; }
        public Vector3<T> yzw { get => new Vector3<T>(yz, w); }
        public Vector3<T> ywx { get => new Vector3<T>(yw, x); }
        public Vector3<T> ywz { get => new Vector3<T>(yw, z); }
        public Vector3<T> zxy { get => xyz.zxy; }
        public Vector3<T> zxw { get => new Vector3<T>(zx, w); }
        public Vector3<T> zyx { get => xyz.zyx; }
        public Vector3<T> zyw { get => new Vector3<T>(zy, w); }
        public Vector3<T> zwx { get => new Vector3<T>(zw, x); }
        public Vector3<T> zwy { get => new Vector3<T>(zw, y); }
        public Vector3<T> wxy { get => new Vector3<T>(wx, y); }
        public Vector3<T> wxz { get => new Vector3<T>(wx, z); }
        public Vector3<T> wyx { get => new Vector3<T>(wy, x); }
        public Vector3<T> wyz { get => new Vector3<T>(wy, z); }
        public Vector3<T> wzx { get => new Vector3<T>(wz, x); }
        public Vector3<T> wzy { get => new Vector3<T>(wz, y); }
        public Vector4<T> xywz { get => new Vector4<T>(xyw, z); }
        public Vector4<T> xzyw { get => new Vector4<T>(xzy, w); }
        public Vector4<T> xzwy { get => new Vector4<T>(xzw, y); }
        public Vector4<T> xwyz { get => new Vector4<T>(xwy, z); }
        public Vector4<T> xwzy { get => new Vector4<T>(xwz, y); }
        public Vector4<T> yxzw { get => new Vector4<T>(yxz, w); }
        public Vector4<T> yxwz { get => new Vector4<T>(yxw, z); }
        public Vector4<T> yzxw { get => new Vector4<T>(yzx, w); }
        public Vector4<T> yzwx { get => new Vector4<T>(yzw, x); }
        public Vector4<T> ywxz { get => new Vector4<T>(ywx, z); }
        public Vector4<T> ywzx { get => new Vector4<T>(ywz, x); }
        public Vector4<T> zxyw { get => new Vector4<T>(zxy, w); }
        public Vector4<T> zxwy { get => new Vector4<T>(zxw, y); }
        public Vector4<T> zyxw { get => new Vector4<T>(zyx, w); }
        public Vector4<T> zywx { get => new Vector4<T>(zyw, x); }
        public Vector4<T> zwxy { get => new Vector4<T>(zwx, y); }
        public Vector4<T> zwyx { get => new Vector4<T>(zwy, x); }
        public Vector4<T> wxyz { get => new Vector4<T>(wxy, z); }
        public Vector4<T> wxzy { get => new Vector4<T>(wxz, y); }
        public Vector4<T> wyxz { get => new Vector4<T>(wyx, z); }
        public Vector4<T> wyzx { get => new Vector4<T>(wyz, x); }
        public Vector4<T> wzxy { get => new Vector4<T>(wzx, y); }
        public Vector4<T> wzyx { get => new Vector4<T>(wzy, x); }
        public Vector4<double> Normalized { get => new Vector4<double>(xd / Length, yd / Length, zd / Length, wd / Length); }
        public Vector4<float> NormalizedF { get => new Vector4<float>(xf / LengthF, yf / LengthF, zf / LengthF, wf / LengthF); }
        
        public Vector4(T x, T y, T z, T w) : this(new Vector3<T>(x, y, z), w)
        {

        }

        public Vector4(Vector2<T> xy, T z, T w) : this(xy.x, xy.y, z, w)
        {
            
        }

        public Vector4(T x, Vector2<T> yz, T w) : this(x, yz.x, yz.y, w)
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
            return base.GetHashCode(); // TODO: check how the "GetHashCode" method works and correct code accordingly
        }

        public bool Equals(Vector4<T> other)
        {
            return this == other; // TODO: check how overloading the "=="/"!=" operators and the "Equals" method work and correct code accordingly
        }

        public static bool operator ==(Vector4<T> left, Vector4<T> right) => left.xyz == right.xyz && left.w.Equals(right.w);
        public static bool operator !=(Vector4<T> left, Vector4<T> right) => !(left == right);
        public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right) => new Vector4<T>(left.xyz + right.xyz, (dynamic)left.w + (dynamic)right.w);
        public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right) => new Vector4<T>(left.xyz - right.xyz, (dynamic)left.w - (dynamic)right.w);
        public static Vector4<T> operator -(Vector4<T> value) => new Vector4<T>(-value.xyz, -(dynamic)w);
    }
}