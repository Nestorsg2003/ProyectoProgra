using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadCaminar = 3;
    private Rigidbody2D MiCuerpo;
    //private SpriteRenderer cavernicola;
    private Animator miAnimador;
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        //cavernicola = GetComponent<SpriteRenderer>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velActualVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("caminando", true);
        }
        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = true;
            miAnimador.SetBool("caminando", true);
        }

        else
        {
            MiCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("caminando", false);
        }
    }
}
