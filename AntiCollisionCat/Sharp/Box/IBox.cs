using AntiCollisionCat.API;
using AntiCollisionCat.LinearMath;

namespace AntiCollisionCat.Sharp.Box
{
    /// <summary>
    /// 盒子接口
    /// </summary>
    public interface IBox : ISharp, IHasName
    {
        /// <summary>
        /// 盒子尺寸, 半值
        /// </summary>
        JVector Halfize { get; set; }
    }
}
