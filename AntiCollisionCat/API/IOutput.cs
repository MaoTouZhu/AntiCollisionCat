namespace AntiCollisionCat.API
{
    public interface IOutput<T> : IInput<T>
    {
        bool SetValue(T value);
    }
}
