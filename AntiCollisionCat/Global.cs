namespace AntiCollisionCat
{
    public static class Global
    {
        public static float TargetTPS { get; internal set; }

        /// <summary>
        /// 目标每秒 Tick 数, 默认 50
        /// </summary>
        public static void SetTargetTPS(float targetTPS)
        {
            if (targetTPS <= 0)
                throw new ArgumentException($"目标TPS必须为正数! ");
            TargetTPS = targetTPS;
        }

        /// <summary>
        /// 实时每秒 Tick 数
        /// </summary>
        public static float TPS { get; internal set; }

        /// <summary>
        /// 每 Tick 性能消耗 ms 数
        /// </summary>
        public static float MTPS { get; internal set; }
    }
}
