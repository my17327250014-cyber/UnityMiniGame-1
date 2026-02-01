using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class SonController_Test : MonoBehaviour
{
    public InputSystem_Actions inputControl;
    private Rigidbody2D rb;
    public Vector2 inputFangxiang;
    public float speed;
    private void Awake()
    {
        inputControl = new InputSystem_Actions();

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputControl.Enable();
    }

    private void Ondisable()
    {
        inputControl.Disable();
    }

    private void Update()
    {
        inputFangxiang = inputControl.Gameplay.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        rb.linearVelocity = new Vector2(speed * Time.deltaTime * inputFangxiang.x, speed * Time.deltaTime * inputFangxiang.y);
    }
}