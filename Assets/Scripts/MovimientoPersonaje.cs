using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour

{
    public float speed = 3.0f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       spriteRenderer=GetComponent<SpriteRenderer>(); 
       animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2 (horizontalInput, 0f);
        transform.Translate (movement*speed*Time.deltaTime);

      
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = true;

        }

        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX =false;
        }

        if (horizontalInput != 0)
        {
            animator.SetBool("isWalking", true);
        }

        else
        {
            animator.SetBool("isWalking",false);
        }
    }
}

