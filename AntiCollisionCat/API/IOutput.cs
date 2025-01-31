namespace AntiCollisionCat.API
{
    /// <summary>
    /// 输出接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOutput<T> : IInput<T>
    {
        /// <summary>
        /// 设置输出值
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        bool SetValue(T targetValue);
    }
}
