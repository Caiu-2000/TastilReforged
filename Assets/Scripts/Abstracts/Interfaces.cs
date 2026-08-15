
public interface IHittable
{
    public void ApplyHitt(HittData? data = null);
}
public interface ITimable
{
    public void TimeStopped();
}