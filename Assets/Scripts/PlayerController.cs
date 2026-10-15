using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public CheckGround checkGround;

    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        /* Sabiendo la función de este método
        genere las instrucciones necesarias...
        */
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        checkMove();
        checkJump();
    }

    void FixedUpdate()
    {
        
    }

    private void checkMove()
    {
        /* Genere el código para que el jugador se mueva...
        añada las animaciones pertinentes
        */
        if (Input.GetKey("a"))
        {
            _spriteRenderer.flipX = true;
            
        }
        if (Input.GetKey("d"))
        {
            _spriteRenderer.flipY = false;
        }
    }    
    
    private void checkJump()
    {
        /* Genere el código para que el jugador salte...
        añada las animaciones pertinentes
        */
        if (Input.GetKey("Spacebar"))
        {
            
            _animator.SetBool("isJumping", true);
        }
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}
