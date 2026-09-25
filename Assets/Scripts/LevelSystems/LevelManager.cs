using UnityEngine;

public class LevelManager : MonoBehaviour, IInteractable
{
    int currentLevel = 0;
    [SerializeField] RoomSO roomTree;

    public string Message => throw new System.NotImplementedException();
    private void Awake()
    {
        
    }
    public void Interact()
    {
        throw new System.NotImplementedException();
    }
    public void CreateNextRoom()
    {

    }
}
