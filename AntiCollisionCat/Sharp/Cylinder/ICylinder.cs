using AntiCollisionCat.API;

namespace AntiCollisionCat.Sharp.Cylinder
{
    /// <summary>
    /// 圆柱体接口
    /// </summary>
    public interface ICylinder : ISharp, IHasName
    {
        /// <summary>
        /// 长度
        /// </summary>
        double Lenght { get; set; }

        /// <summary>
        /// 半径
        /// </summary>
        double Radius { get; set;}
    }
}
