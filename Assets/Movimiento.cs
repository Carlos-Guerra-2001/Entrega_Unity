using UnityEngine;

public class Movimiento : MonoBehaviour
{
  private float Horizontal;
  private float speed = 8f;
  [SerializeField] private Rigidbody2D rb;


  void Update()
  {
	Horizontal = Input.GetAxis("Horizontal");
  }

  private void FixedUpdate()
  {
	  rb.linearVelocity = new Vector2(Horizontal * speed , rb.linearVelocity.y);
  }

}