using AntiCollisionCat.Data;
using AntiCollisionCat.Sharp.Box;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 平移盒子
    /// </summary>
    public class ParallelBox : IBox
    {
        public ParallelBox(Vector halfize, Matrix3 center, Matrix3 direction)
        {
            Halfize = halfize;
            Center = center;
            Direction = direction;
        }
        public Vector Halfize { get; set; }

        public Matrix3 Center { get; set; }
        public Matrix3 Direction { get; set; }

        public string Name => throw new NotImplementedException();

        public void Parallel(Vector dir)
        {
            throw new NotImplementedException();
        }
    }
}
