
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad Inicial
    [SerializeField] private float speed = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        // Variable del RigidBody
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Configurar ejes de Movimiento
        float horizontal = Input.GetAxis("Horizontal"); // (W,S / Arriba, Abajo)
        float vertical = Input.GetAxis("Vertical"); // (A, D / Izquierda, Derecha)

        rb.linearVelocity = new Vector3(
            horizontal * speed,
            rb.linearVelocity.y,
            vertical * speed
        );
    }
}
