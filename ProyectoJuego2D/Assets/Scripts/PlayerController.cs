using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [Header("Movimiento")]
    public float velocidad = 5f;
    float horizontalMovement;
    
    [Header("Salto")]
    public float fuerzaSalto = 10f;
    [Header("GroundCheck")]
    public Transform groundCheckPos;
    public Vector2 groundCkeckSize = new Vector2(0,5f, 0.05f);
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //aPlayer = GetComponent<Animator>();

    }
    public void Movimiento(InputAction.CallbackContext context){
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
    public void Salto(InputAction.CallbackContext context){
        if (context.performed){
            rb.velocity = new Vector2 (rb.velocity.x, fuerzaSalto);
        }else if (context.canceled){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y* 0,5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalMovement* velocidad, rb.velocity.y);
    }
   
}
        //giraPlayer(h);
        //aPlayer.SetFloat("VelocidadX",Mathf.Abs(rPlayer.velocity.x));
        //aPlayer.SetFloat("VelocidadY",rPlayer.velocity.y);
        //aPlayer.SetFloat("TocaSuelo",rPlayer.velocity.y);


        //programar salto
       // colPies = CheckGround.colPies;
       // if (Input.GetButtonDown("Jump") && colPies)
       // {
       //  rPlayer.velocity = new Vector2 (rPlayer.velocity.x, 0f);
       //     rPlayer.AddForce (new Vector2(0,fuerzaSalto), ForceMode2D.Impulse);   
       // }
    
    
    


    //private void FixedUpdate()
    //{
    //    h = Input.GetAxisRaw("Horizontal");
    //    rPlayer.AddForce(Vector2.right * velocidad * h);
    //    float limiteVelocidad = Mathf.Clamp(rPlayer.velocity.x, -velocidadMax, velocidadMax);
    //    rPlayer.velocity = new Vector2(limiteVelocidad, rPlayer.velocity.y);
    //    if(h == 0 && !colPies){
    //        Vector3 velocidadArreglada = rPlayer.velocity;
    //        velocidadArreglada *= friccionSuelo;
    //        rPlayer.velocity = velocidadArreglada;
    //    }    
    //}
    //void giraPlayer(float horizontal){
    //    if ((horizontal > 0 && !miraDerecha || horizontal < 0 && miraDerecha)){
    //        miraDerecha = !miraDerecha;
    //        Vector3 escalaGiro = transform.localScale;
    //        escalaGiro.x = escalaGiro.x * -1;
    //        transform.localScale = escalaGiro;
    //    }
    //}
