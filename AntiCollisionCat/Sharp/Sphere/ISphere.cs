using AntiCollisionCat.API;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 球接口
    /// </summary>
    public interface ISphere : IHasName, ISharp
    {
        /// <summary>
        /// 半径
        /// </summary>
        double Radius { get; set; }
    }
}
