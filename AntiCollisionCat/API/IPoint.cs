namespace AntiCollisionCat.API
{
    /// <summary>
    /// 点位接口
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// 点位信息
        /// </summary>
        IEnumerable<(IAxis, double?)> PointInfo { get; }
    }
}
