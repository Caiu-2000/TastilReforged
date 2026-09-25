using UnityEngine;

[DefaultExecutionOrder(-4)]
public class InteractionComponnent : MonoBehaviour
{
    [SerializeField] private LayerMask InteractableMask;
    private IInteractable InteractableOnSight;

    private void Start()
    {
        GameManager.inputManager.OnInteractPressed += InteractPressed;
    }

    void Update()
    {
        if (Camera.main != null)
        {
            Ray _ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

            RaycastHit _hit;



            if (Physics.Raycast(_ray, out _hit, 5, InteractableMask))
            {

                if (_hit.transform.gameObject.GetComponent<IInteractable>() == null) return;

                if (InteractableOnSight != _hit.transform.gameObject.GetComponent<IInteractable>())
                {

                    string mensaje = _hit.transform.gameObject.GetComponent<IInteractable>().Message;
                    GameManager.Ui.IndicateInteractItem(mensaje);
                }

                InteractableOnSight = _hit.transform.gameObject.GetComponent<IInteractable>();
            }
            else
            {
                InteractableOnSight = null;
                GameManager.Ui.IndicateInteractItem(null, true);
            }



        }
    }

    public void InteractPressed()
    {
        if (InteractableOnSight != null)
        {
            InteractableOnSight.Interact();
        }
    }
}
