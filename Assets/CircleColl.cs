using UnityEngine;


public class CircleColl : MonoBehaviour
{


    public static bool isGrounded;    


    void Start()
    {
        isGrounded = false;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
