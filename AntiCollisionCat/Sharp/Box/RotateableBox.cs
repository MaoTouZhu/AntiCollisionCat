using AntiCollisionCat.Data;
using AntiCollisionCat.Sharp.Box;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 可旋转的盒子
    /// </summary>
    public class RotateableBox : IRotateable, IBox
    {
        public Vector Halfize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Matrix3 Center { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Matrix3 Direction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name => throw new NotImplementedException();

        public void Parallel(Vector dir)
        {
            throw new NotImplementedException();
        }
    }
}
