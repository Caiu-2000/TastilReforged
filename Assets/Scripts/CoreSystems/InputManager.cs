using UnityEngine;
using UnityEngine.InputSystem;



[DefaultExecutionOrder(-5)]
public class InputManager : MonoBehaviour
{ 
    private InputAction _useAction, _useItemAction, _movementAction, _lookAction, _attackAction, _interactAction, _blockAction, _jumpAtion, _rightClickAction;
    private InputAction _parryAction, _SpecialAction;
 
    Vector2 _dir = Vector2.zero;
  





    public delegate void AttacksDelegate();

    public delegate void JumpPress();
    public delegate void UseAction();
    public delegate void Parry();
    public delegate void Interact();

    public AttacksDelegate OnAttackPressed = delegate { };
    public AttacksDelegate OnAttackReleased = delegate { };
    public AttacksDelegate OnSpecialPressed = delegate { };
    public AttacksDelegate OnSpecialReleased = delegate { };
    public JumpPress OnJumpPress = delegate { };

    public UseAction OnUsePressed = delegate { };
    public UseAction OnUseItemPressed = delegate { };


    public Parry OnParryPressed = delegate { };
    public Interact OnInteractPressed = delegate { };
    // Este todavia no se usa pero ya queda aca
    // public UseAction OnUseReleased = delegate { };

    private void Awake()
    {

        _movementAction = InputSystem.actions.FindAction("Move");
        _lookAction = InputSystem.actions.FindAction("Look");
        _attackAction = InputSystem.actions.FindAction("Attack");
        _interactAction = InputSystem.actions.FindAction("Interact");

        _useAction = InputSystem.actions.FindAction("Use");
        _jumpAtion = InputSystem.actions.FindAction("Jump");
        _rightClickAction = InputSystem.actions.FindAction("SecondClick");

        _parryAction = InputSystem.actions.FindAction("Parry");
        _useItemAction = InputSystem.actions.FindAction("UseItem");

        _SpecialAction = InputSystem.actions.FindAction("RigthClick");

        /*
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        */


    }
    private void Start()
    {
        GameManager.inputManager = this;
    }

    private void Update()
    {

        _dir = _movementAction.ReadValue<Vector2>();
        if (_interactAction.WasPressedThisFrame())
        {
            OnInteractPressed?.Invoke();
        }

        Vector2 lookDir = _lookAction.ReadValue<Vector2>();

            if (_attackAction.WasPressedThisFrame())
            {

                OnAttackPressed?.Invoke();
            }
            if (_attackAction.WasReleasedThisFrame())
            {
                OnAttackReleased?.Invoke();
            }

            if (_useAction.WasPressedThisFrame())
            {
                OnUsePressed?.Invoke();
            }
            if (_rightClickAction.WasPressedThisFrame())
            {

            }
            if (_useItemAction.WasPressedThisFrame())
            {
                OnUseItemPressed?.Invoke();
            }

            if (_parryAction.WasPressedThisFrame())
            {
                OnParryPressed?.Invoke();
            }

            if (_SpecialAction.WasPressedThisFrame())
            {
                OnSpecialPressed?.Invoke();
            }
            else if (_SpecialAction.WasReleasedThisFrame())
            {
                OnSpecialReleased?.Invoke();
            }
 
        if (_jumpAtion.WasPressedThisFrame())
        {
            OnJumpPress?.Invoke();
        }

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {

            for (int i = 1; i <= 4; i++)
            {

                Key tecla = (Key)System.Enum.Parse(typeof(Key), "Digit" + i);

                if (Keyboard.current[tecla].wasPressedThisFrame)
                {
                    //
                    //_inventory.ChangeSelection(i - 1);
                    break;
                }
            }
        }
    }


}





