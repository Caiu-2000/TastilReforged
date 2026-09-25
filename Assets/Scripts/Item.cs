using UnityEngine;

public  class Item : MonoBehaviour , IInteractable
{
    public string interactionMessage;
    public string Message => interactionMessage;
    
    public ItemData ItemData { get; private set; }
    public void Interact()
    {
        Debug.Log("Interacted with item: " + gameObject.name);
        Destroy(gameObject);
        // Implement the logic for what happens when the item is interacted with
    }

}
