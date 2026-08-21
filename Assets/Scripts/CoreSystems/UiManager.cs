using UnityEngine;

public class UiManager : MonoBehaviour
{
    private void Start()
    {
        GameManager.Ui = this;
    }

    [SerializeField] private TMPro.TextMeshProUGUI InteractText;
    public void IndicateInteractItem(string message, bool hide = false)
    {
        if (hide)
        {
            InteractText.text = "";
        }
        else
        { 
        InteractText.text = message;
        }
    }
}