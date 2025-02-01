using Jitter2.Collision.Shapes;
using Jitter2.LinearMath;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class MBoxShape : BoxShape, IHasName
    {
        /// <summary>
        /// 创建具有指定尺寸的盒子形状。
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="size">
        /// 盒子的尺寸。<br></br><br></br>
        /// </param>
        public MBoxShape(string name, JVector size) : base(size)
        {
            Name = name;
        }

        /// <summary>
        /// 创建具有指定边长的立方体。
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="size">
        /// 立方体每边的长度。<br></br><br></br>
        /// </param>
        public MBoxShape(string name, Real size) : base(size)
        {
            Name = name;
        }

        /// <summary>
        /// 创建具有指定长度、高度和宽度的盒子形状。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="length">盒子长度 </param>
        /// <param name="height">盒子高度 </param>
        /// <param name="width">盒子宽度 </param>
        public MBoxShape(string name, Real length, Real height, Real width) : base(length, height, width)
        {
            Name = name;
        }

        /// <inheritdoc/>
        public string Name { get; set; }
    }
}
