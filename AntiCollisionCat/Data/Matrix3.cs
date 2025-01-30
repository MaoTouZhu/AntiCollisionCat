namespace AntiCollisionCat.Data
{
    /// <summary>
    /// 3x3矩阵
    /// </summary>
    public struct Matrix3
    {
        public Matrix3(IEnumerable<Real> matrix3Datas)
        {
            ArgumentNullException.ThrowIfNull(matrix3Datas);
        }
        public Real a11;
        public Real a12;
        public Real a13;
        public Real a21;
        public Real a22;
        public Real a23;
        public Real a31;
        public Real a32;
        public Real a33;

        public Matrix3 Add(Matrix3 rightMatrix3)
        {
            return new Matrix3()
            {
                a11 = this.a11 + rightMatrix3.a11,
                a12 = this.a12 + rightMatrix3.a12,
                a13 = this.a13 + rightMatrix3.a13,
                a21 = this.a21 + rightMatrix3.a21,
                a22 = this.a22 + rightMatrix3.a22,
                a23 = this.a23 + rightMatrix3.a23,
                a31 = this.a31 + rightMatrix3.a31,
                a32 = this.a32 + rightMatrix3.a32,
                a33 = this.a33 + rightMatrix3.a33
            };
        }

        public Matrix3 Subtract(Matrix3 rightMatrix3)
        {
            return new Matrix3()
            {
                a11 = this.a11 - rightMatrix3.a11,
                a12 = this.a12 - rightMatrix3.a12,
                a13 = this.a13 - rightMatrix3.a13,
                a21 = this.a21 - rightMatrix3.a21,
                a22 = this.a22 - rightMatrix3.a22,
                a23 = this.a23 - rightMatrix3.a23,
                a31 = this.a31 - rightMatrix3.a31,
                a32 = this.a32 - rightMatrix3.a32,
                a33 = this.a33 - rightMatrix3.a33
            };
        }

        public Matrix3 Multiply(Matrix3 rightMatrix3)
        {
            var left = this;
            var right = rightMatrix3;
            return new Matrix3()
            {
                a11 = left.a11 * right.a11 + left.a12 * right.a21 + left.a13 * right.a31,
                a12 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a13 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a21 = left.a21 * right.a11 + left.a22 * right.a22 + left.a13 * right.a32,
                a22 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a23 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a31 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a32 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
                a33 = left.a11 * right.a21 + left.a12 * right.a22 + left.a13 * right.a32,
            };
        }

        public Matrix3 Divide(Matrix3 rightMatrix3)
        {
            return new Matrix3()
            {
                a11 = this.a11 / rightMatrix3.a11,
                a12 = this.a12 / rightMatrix3.a12,
                a13 = this.a13 / rightMatrix3.a13,
                a21 = this.a21 / rightMatrix3.a21,
                a22 = this.a22 / rightMatrix3.a22,
                a23 = this.a23 / rightMatrix3.a23,
                a31 = this.a31 / rightMatrix3.a31,
                a32 = this.a32 / rightMatrix3.a32,
                a33 = this.a33 / rightMatrix3.a33
            };
        }
    }
}
