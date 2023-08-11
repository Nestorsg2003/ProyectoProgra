using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    //declarar una referencia al rigid body
    private Rigidbody2D MiCuerpo;
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            print("se presiono salto");
            MiCuerpo.AddForce(
                new Vector3(0, 20, 0),
                ForceMode2D.Impulse);
        }
    }
}
