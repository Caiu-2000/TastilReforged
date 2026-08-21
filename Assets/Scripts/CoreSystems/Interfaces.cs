
public interface IHittable
{
    public void ApplyHitt(HittData? data = null);
}
public interface ITimable
{
    public void TimeStopped();
}

public interface IPhysicUpdater
{
    public void PysicsUpdate();
}

public interface IInteractable
{
    string Message { get; }
    

    // Asi se tiene que implementar
    //[SerializeField] private string interactionMessage;
    //public string InteractionMessage => interactionMessage;
    public void Interact();
}