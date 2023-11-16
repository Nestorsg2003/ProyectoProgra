using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCorrer = 2;
    public float velocidadSaltar = 20;
    public bool enPiso = false;
    private Animator miAnimador;
    private float saltosR;
    private Rigidbody2D miCuerpo;

    //WALLJUMP
    bool jump;
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;

    public Transform wallCheck;
    bool isWallTouch;
    bool isSliding;
    public float wallSlidingSpeed;

    public float wallJumpDuration;
    public Vector2 wallJumpForce;
    bool wallJumping;

    //DASH

    public float velocidadDash = 2;
    public float tiempoDash;
    private bool puedeHacerDash = true;
    public bool sePuedeMover = true;
    private float gravedadInicial;

    void Start ()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        gravedadInicial = miCuerpo.gravityScale;
    }

    private void Update()
    {
        comprobarPiso();

        float velActualVert = miCuerpo.velocity.y;
        float movHoriz = Input.GetAxisRaw("Horizontal");
        miAnimador.SetFloat("VELVERT", velActualVert);

        isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.2f, 0.1f), 0, groundLayer);
        isWallTouch = Physics2D.OverlapBox(wallCheck.position, new Vector2(0.1f, 0.8f), 0, groundLayer);
        if (movHoriz > 0 && sePuedeMover)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCorrer, velActualVert, 0);
            miAnimador.SetBool("CAMINAR", true);
        }
        else if (movHoriz < 0 && sePuedeMover)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCorrer, velActualVert, 0);
            miAnimador.SetBool("CAMINAR", true);
        }
        else
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("CAMINAR", false);
        }

        if (enPiso)
        {
            miAnimador.SetBool("ENPISO", true);
        }
        else if (enPiso == false)
        {
            miAnimador.SetBool("ENPISO", false);
        }

        if (Input.GetButtonDown("Jump") && sePuedeMover)
        {
            jump = true;
            miAnimador.SetBool("ENPISO", false);
        }

        if(isWallTouch && !isGrounded && movHoriz !=0)
        {
            isSliding = true;
        }
        else
        {
            isSliding = false;
        }
        if (jump)
        {
            Jump();
        }

        //DASH

        if(Input.GetKeyDown(KeyCode.B) && puedeHacerDash)
        {
            StartCoroutine(Dash());
        }
    }

    private void FixedUpdate()
    {
        //WALLJUMP
        float movHoriz = Input.GetAxisRaw("Horizontal");

        if (isSliding && sePuedeMover)
        {
            miCuerpo.velocity = new Vector2(miCuerpo.velocity.x, Mathf.Clamp(miCuerpo.velocity.y, -wallSlidingSpeed, float.MaxValue));
        }

        if (wallJumping && sePuedeMover)
        {
            miCuerpo.velocity = new Vector2(-movHoriz * wallJumpForce.x, wallJumpForce.y);
        }
        else
        {
            miCuerpo.velocity = new Vector2(movHoriz * velocidadCorrer, miCuerpo.velocity.y);
        }

    }
    void Jump()
    {
        if (isGrounded && sePuedeMover)
        {
            miCuerpo.AddForce(new Vector2(0, velocidadSaltar), ForceMode2D.Impulse);
        }
        else if(isSliding && sePuedeMover) 
        {
            wallJumping = true;
            Invoke("StopWallJumping", wallJumpDuration);
        }
        jump = false;
    }

    void StopWallJumping()
    {
        wallJumping = false;
    }
    //DASH

    private IEnumerator Dash()
    {
        miAnimador.SetBool("Dash", true);
        sePuedeMover = false;
        puedeHacerDash = false;
        miCuerpo.gravityScale = 0;
        miCuerpo.velocity = new Vector2(velocidadDash, 0);
        yield return new WaitForSeconds(tiempoDash);
        sePuedeMover = true;
        puedeHacerDash = true;
        miCuerpo.gravityScale = gravedadInicial;
        miAnimador.SetBool("Dash", false);
    }

    public void comprobarPiso()
    {
        enPiso = Physics2D.Raycast(
            transform.position,//desde donde
            Vector2.down,//hacia abajo
            0.1f);//distancia
    }

}