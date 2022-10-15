using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.InputSystem.InputAction;

public class PersonBehavior : MonoBehaviour
{

    public GameObject _bullet;
    public PlayerControls controls;
    public float time;

    private void Awake() => controls = new PlayerControls();

    private void OnEnable()
    {
        controls.ActionMap.Enable();
        controls.ActionMap.Fire.performed += OnFire;
        controls.ActionMap.PressButtonLogging.performed += OnButtonLogging;
        controls.ActionMap.Jump.performed += OnJump;
    }

    private void OnJump(CallbackContext obj)
    {
        var isJumped = Keyboard.current[Key.Space].isPressed;
        if (!isJumped) return;

        transform.position += new Vector3(0, 5, 0);
    }

    private void OnButtonLogging(CallbackContext context)
    {
        var but = context.ReadValue<float>();
        Debug.Log("Button is pressed");
    }

    void Update()
    {
        time -= Time.deltaTime;
        
        MovementForward();
        OnRotation();
    }

    private void OnRotation()
    {
        var leftRotation = Keyboard.current[Key.Q].isPressed;
        var rightRotation = Keyboard.current[Key.E].isPressed;

        if (leftRotation)
        {
            transform.eulerAngles += new Vector3(0, -1, 0);
        }

        if (rightRotation)
        {
            transform.eulerAngles += new Vector3(0, 1, 0);
        }
    }
    
    private void OnFire(CallbackContext context)
    {
        if (time >= 0) return;
        Instantiate(_bullet, transform.position, transform.rotation);
        

        time = 1.5f;
    }
    
    private void MovementForward()
    {
        var translate = controls.ActionMap.Movement.ReadValue<Vector2>();
        var up = translate.x;
        var down = translate.y;

        transform.position += new Vector3(up, 0, down) * Time.deltaTime;

        if (transform.position.y > 0)
        {
            transform.position += Vector3.down * Time.deltaTime;
        }
    }

    private void OnDisable()
    {
        controls.ActionMap.Disable();
        // controls.ActionMap.Movement.performed -= MovementForward;
        controls.ActionMap.Fire.performed -= OnFire;
        controls.ActionMap.PressButtonLogging.performed -= OnButtonLogging;
        controls.ActionMap.Jump.performed -= OnJump;
    }
}
