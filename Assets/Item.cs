using UnityEngine;

public  class Item : MonoBehaviour , IInteractable
{
    public string interactionMessage;
    public string Message => interactionMessage;
    
    public void Interact()
    {
        Debug.Log("Interacted with item: " + gameObject.name);
        // Implement the logic for what happens when the item is interacted with
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
