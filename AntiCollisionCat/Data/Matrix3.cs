using System.Runtime.CompilerServices;

namespace AntiCollisionCat.Data
{
    /// <summary>
    /// 3x3矩阵
    /// </summary>
    public readonly struct Matrix3
    {
        /// <summary>
        /// 通过 9 个数构造一个 3x3 矩阵
        /// </summary>
        public Matrix3(
            Real a11 = (Real)0, Real a12 = (Real)0, Real a13 = (Real)0,
            Real a21 = (Real)0, Real a22 = (Real)0, Real a23 = (Real)0,
            Real a31 = (Real)0, Real a32 = (Real)0, Real a33 = (Real)0)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a21 = a21;
            this.a22 = a22;
            this.a23 = a23;
            this.a31 = a31;
            this.a32 = a32;
            this.a33 = a33;
        }

        /// <summary>
        /// 使用单个实数值初始化矩阵的构造方法 <br></br><br></br>
        /// 所有成员变量将被初始化为该值.
        /// </summary>
        public Matrix3(Real value)
        {
            this.a11 = value;
            this.a12 = value;
            this.a13 = value;
            this.a21 = value;
            this.a22 = value;
            this.a23 = value;
            this.a31 = value;
            this.a32 = value;
            this.a33 = value;
        }

        /// <summary>
        /// 通过一个 <see cref="IEnumerable{Real}"/> 构造一个 3x3 矩阵
        /// </summary>
        /// <param name="matrix3Datas">
        /// 矩阵数据. <br></br><br></br>
        /// 依次从 <see cref="a11"/> 压入矩阵进行初始化, <br></br>
        /// 数量不足将默认为 <see  href="0"/>
        /// </param>
        public Matrix3(in IEnumerable<Real> matrix3Datas)
        {
            ArgumentNullException.ThrowIfNull(matrix3Datas);
            short index = 1;
            foreach (var item in matrix3Datas)
            {
                switch (index)
                {
                    case 1: a11 = item; break;
                    case 2: a12 = item; break;
                    case 3: a13 = item; break;
                    case 4: a21 = item; break;
                    case 5: a22 = item; break;
                    case 6: a23 = item; break;
                    case 7: a31 = item; break;
                    case 8: a32 = item; break;
                    case 9: a33 = item; break;
                }
            }
        }



        /// <summary>
        /// 第 1 行第 1 列
        /// </summary>
        public readonly Real a11;
        /// <summary>
        /// 第 1 行第 2 列
        /// </summary>
        public readonly Real a12;
        /// <summary>
        /// 第 1 行第 3 列
        /// </summary>
        public readonly Real a13;
        /// <summary>
        /// 第 2 行第 1 列
        /// </summary>
        public readonly Real a21;
        /// <summary>
        /// 第 2 行第 2 列
        /// </summary>
        public readonly Real a22;
        /// <summary>
        /// 第 2 行第 3 列
        /// </summary>
        public readonly Real a23;
        /// <summary>
        /// 第 3 行第 1 列
        /// </summary>
        public readonly Real a31;
        /// <summary>
        /// 第 3 行第 2 列
        /// </summary>
        public readonly Real a32;
        /// <summary>
        /// 第 3 行第 3 列
        /// </summary>
        public readonly Real a33;

        /// <summary>
        /// 索引矩阵中的值
        /// </summary>
        /// <param name="row">行值 [1,3] </param>
        /// <param name="col">列值 [1,3] </param>
        /// <returns>对应行列的值</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Real this[int row, int col]
        {
            get
            {
                switch (row)
                {
                    case 1:
                        switch (col)
                        {
                            case 1: return a11;
                            case 2: return a12;
                            case 3: return a13;
                        }
                        break;
                    case 2:
                        switch (col)
                        {
                            case 1: return a21;
                            case 2: return a22;
                            case 3: return a23;
                        }
                        break;
                    case 3:
                        switch (col)
                        {
                            case 1: return a31;
                            case 2: return a32;
                            case 3: return a33;
                        }
                        break;
                }

                throw new IndexOutOfRangeException("矩阵索引不合法, 1 <= 矩阵索引 <= 3");
            }
        }



        /// <summary>
        /// 矩阵加法
        /// </summary>
        public Matrix3 Add(Matrix3 rightMatrix3)
        {
            return new Matrix3(
                this.a11 + rightMatrix3.a11, this.a12 + rightMatrix3.a12, this.a13 + rightMatrix3.a13,
                this.a21 + rightMatrix3.a21, this.a22 + rightMatrix3.a22, this.a23 + rightMatrix3.a23,
                this.a31 + rightMatrix3.a31, this.a32 + rightMatrix3.a32, this.a33 + rightMatrix3.a33
            );
        }

        /// <summary>
        /// 矩阵与实数相加
        /// </summary>
        public Matrix3 Add(Real scalar)
        {
            return new Matrix3(
                this.a11 + scalar, this.a12 + scalar, this.a13 + scalar,
                this.a21 + scalar, this.a22 + scalar, this.a23 + scalar,
                this.a31 + scalar, this.a32 + scalar, this.a33 + scalar
            );
        }

        /// <summary>
        /// 矩阵减法
        /// </summary>
        public Matrix3 Subtract(Matrix3 rightMatrix3)
        {
            return new Matrix3(
                this.a11 - rightMatrix3.a11, this.a12 - rightMatrix3.a12, this.a13 - rightMatrix3.a13,
                this.a21 - rightMatrix3.a21, this.a22 - rightMatrix3.a22, this.a23 - rightMatrix3.a23,
                this.a31 - rightMatrix3.a31, this.a32 - rightMatrix3.a32, this.a33 - rightMatrix3.a33
            );
        }

        /// <summary>
        /// 矩阵与实数相减
        /// </summary>
        public Matrix3 Subtract(Real scalar)
        {
            return new Matrix3(
                this.a11 - scalar, this.a12 - scalar, this.a13 - scalar,
                this.a21 - scalar, this.a22 - scalar, this.a23 - scalar,
                this.a31 - scalar, this.a32 - scalar, this.a33 - scalar
            );
        }

        /// <summary>
        /// 矩阵与实数相乘
        /// </summary>
        public Matrix3 Multiply(Real scalar)
        {
            return new Matrix3(
                this.a11 * scalar, this.a12 * scalar, this.a13 * scalar,
                this.a21 * scalar, this.a22 * scalar, this.a23 * scalar,
                this.a31 * scalar, this.a32 * scalar, this.a33 * scalar
            );
        }

        /// <summary>
        /// 矩阵乘法
        /// </summary>
        public Matrix3 Multiply(Matrix3 rightMatrix3)
        {
            return new Matrix3(
                this.a11 * rightMatrix3.a11 + this.a12 * rightMatrix3.a21 + this.a13 * rightMatrix3.a31,
                this.a11 * rightMatrix3.a12 + this.a12 * rightMatrix3.a22 + this.a13 * rightMatrix3.a32,
                this.a11 * rightMatrix3.a13 + this.a12 * rightMatrix3.a23 + this.a13 * rightMatrix3.a33,

                this.a21 * rightMatrix3.a11 + this.a22 * rightMatrix3.a21 + this.a23 * rightMatrix3.a31,
                this.a21 * rightMatrix3.a12 + this.a22 * rightMatrix3.a22 + this.a23 * rightMatrix3.a32,
                this.a21 * rightMatrix3.a13 + this.a22 * rightMatrix3.a23 + this.a23 * rightMatrix3.a33,

                this.a31 * rightMatrix3.a11 + this.a32 * rightMatrix3.a21 + this.a33 * rightMatrix3.a31,
                this.a31 * rightMatrix3.a12 + this.a32 * rightMatrix3.a22 + this.a33 * rightMatrix3.a32,
                this.a31 * rightMatrix3.a13 + this.a32 * rightMatrix3.a23 + this.a33 * rightMatrix3.a33
            );
        }

        /// <summary>
        /// 矩阵除法（按元素相除）
        /// </summary>
        public Matrix3 Divide(Matrix3 rightMatrix3)
        {
            // 检查除数矩阵的元素是否为零，防止除零错误
            if (rightMatrix3.a11 == 0 || rightMatrix3.a12 == 0 || rightMatrix3.a13 == 0 ||
                rightMatrix3.a21 == 0 || rightMatrix3.a22 == 0 || rightMatrix3.a23 == 0 ||
                rightMatrix3.a31 == 0 || rightMatrix3.a32 == 0 || rightMatrix3.a33 == 0)
            {
                throw new DivideByZeroException("矩阵除法时，除数矩阵的元素不能为零。");
            }
            return new Matrix3(
                this.a11 / rightMatrix3.a11, this.a12 / rightMatrix3.a12, this.a13 / rightMatrix3.a13,
                this.a21 / rightMatrix3.a21, this.a22 / rightMatrix3.a22, this.a23 / rightMatrix3.a23,
                this.a31 / rightMatrix3.a31, this.a32 / rightMatrix3.a32, this.a33 / rightMatrix3.a33
            );
        }

        /// <summary>
        /// 矩阵除法（按元素除以一个实数）
        /// </summary>
        /// <param name="value">除数</param>
        /// <exception cref="DivideByZeroException"></exception>
        public Matrix3 Divide(Real value)
        {
            if (value == 0)
            {
                throw new DivideByZeroException("矩阵除法时，除数不能为零。");
            }
            return new Matrix3(
                this.a11 / value, this.a12 / value, this.a13 / value,
                this.a21 / value, this.a22 / value, this.a23 / value,
                this.a31 / value, this.a32 / value, this.a33 / value
            );
        }

        /// <summary>
        /// 矩阵范数（Frobenius范数）
        /// </summary>
        public Real Norm()
        {
            return (Real)Math.Sqrt(
                (double)this.a11 * (double)this.a11 + (double)this.a12 * (double)this.a12 + (double)this.a13 * (double)this.a13 +
                (double)this.a21 * (double)this.a21 + (double)this.a22 * (double)this.a22 + (double)this.a23 * (double)this.a23 +
                (double)this.a31 * (double)this.a31 + (double)this.a32 * (double)this.a32 + (double)this.a33 * (double)this.a33
            );
        }

        /// <summary>
        /// 矩阵幂
        /// </summary>
        public Matrix3 Power(int exponent)
        {
            Matrix3 result = new Matrix3(1, 0, 0, 0, 1, 0, 0, 0, 1); // 单位矩阵
            Matrix3 baseMatrix = this;

            while (exponent > 0)
            {
                if ((exponent % 2) == 1)
                {
                    result = result.Multiply(baseMatrix);
                }
                baseMatrix = baseMatrix.Multiply(baseMatrix);
                exponent /= 2;
            }

            return result;
        }

        /// <summary>
        /// 矩阵迹
        /// </summary>
        public Real Trace()
        {
            return this.a11 + this.a22 + this.a33;
        }

        /// <summary>
        /// 矩阵行列式
        /// </summary>
        public Real Determinant()
        {
            return this.a11 * (this.a22 * this.a33 - this.a23 * this.a32) -
                   this.a12 * (this.a21 * this.a33 - this.a23 * this.a31) +
                   this.a13 * (this.a21 * this.a32 - this.a22 * this.a31);
        }

        /// <summary>
        /// 矩阵转置
        /// </summary>
        public Matrix3 Transpose()
        {
            return new Matrix3(
                this.a11, this.a21, this.a31,
                this.a12, this.a22, this.a32,
                this.a13, this.a23, this.a33
            );
        }

        public static Matrix3 operator +(Matrix3 left, Matrix3 right) => left.Add(right);

        public static Matrix3 operator +(Matrix3 left, Real right) => left.Add(right);

        public static Matrix3 operator -(Matrix3 left, Matrix3 right) => left.Subtract(right);

        public static Matrix3 operator -(Matrix3 left, Real right) => left.Subtract(right);

        public static Matrix3 operator * (Matrix3 left, Matrix3 right) => left.Multiply(right);

        public static Matrix3 operator *(Matrix3 left, Real right) => left.Multiply(right);

        public override string ToString()
        {
            return $"[{a11}, {a12}, {a13}]{Environment.NewLine}" +
                   $"[{a21}, {a22}, {a23}]{Environment.NewLine}" +
                   $"[{a31}, {a32}, {a33}]";
        }
    }
}
