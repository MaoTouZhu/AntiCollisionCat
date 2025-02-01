using Jitter2.Collision.Shapes;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class MCylinderShape : CylinderShape, IHasName
    {
        /// <summary>
        /// 初始化 <see cref="CylinderShape"/> 类的新实例，创建具有指定高度和半径的圆柱形状。圆柱的对称轴沿 y 轴对齐。<br></br><br></br>
        /// Initializes a new instance of the <see cref="CylinderShape"/> class, creating a cylinder shape with the specified height and radius. The symmetry axis of the cylinder is aligned along the y-axis.
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="height">圆柱体的高度。</param>
        /// <param name="radius">圆柱体的半径。</param>
        public MCylinderShape(string name, Real height, Real radius) : base(height, radius)
        {
            Name = name;
        }

        /// <inheritdoc/>
        public string Name { get; set; }
    }
}
