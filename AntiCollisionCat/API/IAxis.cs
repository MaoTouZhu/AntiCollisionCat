namespace AntiCollisionCat.API
{
    /// <summary>
    /// 轴接口
    /// </summary>
    public interface IAxis : IOutput<double?>
    {
        /// <summary>
        /// 轴当前位置
        /// </summary>
        Real? PosNow { get; }
        /// <summary>
        /// 目标位置
        /// </summary>
        Real? PosTarget { get; }
    }
}
