using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float speed = 150f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float horizontalMovement = horizontalInput * speed * Time.deltaTime;
        _rb.linearVelocityX = horizontalMovement;

        float verticalInput = Input.GetAxisRaw("Vertical");
        float verticalMovement = verticalInput * speed * Time.deltaTime;
        _rb.linearVelocityY = verticalMovement;
    }
}
