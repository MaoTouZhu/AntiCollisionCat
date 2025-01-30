namespace AntiCollisionCat.API
{
    public interface IInput<T> : IHasName
    {
        T Value { get; }
    }
}
