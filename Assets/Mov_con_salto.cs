using UnityEngine;

public class Mov_con_salto : MonoBehaviour
{
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float JumpForce = 8f;
   
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");


        rb.transform.Translate(new Vector2(h, 0) * Time.deltaTime * speed);
       
        if (Input.GetKeyDown(KeyCode.Space) &&  (CircleColl.isGrounded == true))
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}


