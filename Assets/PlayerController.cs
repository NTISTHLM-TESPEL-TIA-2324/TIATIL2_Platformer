using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 5;

  [SerializeField]
  float jumpForce = 100;

  bool mayJump = true;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float moveX = Input.GetAxisRaw("Horizontal");

    Vector2 movementX = new Vector2(moveX, 0);

    transform.Translate(movementX * speed * Time.deltaTime);

    if (Input.GetAxisRaw("Jump") > 0 && mayJump == true)
    {
      Rigidbody2D rb = GetComponent<Rigidbody2D>();
      Vector2 jump = Vector2.up * jumpForce;

      rb.AddForce(jump);

      mayJump = false;
    }

    if (Input.GetAxisRaw("Jump") == 0)
    {
      mayJump = true;
    }


  }
}
