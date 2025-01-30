namespace AntiCollisionCat.API
{
    public interface IAxis : IOutput<double?>
    {
        double? PosNow { get;}
        double? PosTarget { get;}
    }
}
