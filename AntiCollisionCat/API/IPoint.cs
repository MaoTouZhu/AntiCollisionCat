namespace AntiCollisionCat.API
{
    public interface IPoint
    {
        IEnumerable<(IAxis,double?)> PointInfo { get; }
    }
}
