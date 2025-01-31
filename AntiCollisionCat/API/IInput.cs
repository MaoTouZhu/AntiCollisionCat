namespace AntiCollisionCat.API
{
    /// <summary>
    /// 送入接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInput<T> : IHasName
    {
        /// <summary>
        /// 输入值
        /// </summary>
        T Value { get; }
    }
}
