using UnityEngine;

public class Mov_con_salto : MonoBehaviour
{
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 8f;

    void Update()
    {
        // Movimiento horizontal
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
