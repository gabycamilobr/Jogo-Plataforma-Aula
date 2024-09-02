using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float horizontal;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    public Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        this.rb.velocity = new Vector2(horizontal * 8, rb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        Flip();

       /*f (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Apertou o espaço");
        }
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("Clicou com io botao direito");
        }  */

    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}

