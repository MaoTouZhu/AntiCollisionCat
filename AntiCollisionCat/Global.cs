global using Real = float;
namespace AntiCollisionCat
{
    public static class Global
    {
        /// <summary>
        /// 目标每秒 Tick 数
        /// </summary>
        public static float TargetTPS {  get; set; }

        /// <summary>
        /// 每秒 Tick 数
        /// </summary>
        public static float TPS { get;internal set; }

        /// <summary>
        /// 每 Tick 性能消耗 ms 数
        /// </summary>
        public static float MTPS { get; internal set; }
    }
}
