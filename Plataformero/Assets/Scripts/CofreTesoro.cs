using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CofreTesoro : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject tesoro;
    public bool cercaCofre = false;
    void Start()
    {
        miAnimador = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && cercaCofre)
        {
            miAnimador.SetTrigger("OBTENER");
            Instantiate(tesoro, transform);
        }

    }
    private void OnTriggerEnter2D(Collider2D abrir)
    {
        
        CofreTesoro cofre = GetComponent<CofreTesoro>();
        print(name + "hizo colision con" + abrir.gameObject.name);
        GameObject otro = abrir.gameObject;
        
        if (otro.tag == "Player")
        {
            ControladorUI canvas = GetComponent<ControladorUI>();
            //Aplico el daño al otro invocando el metodo hacer daño
            canvas.aparecerBoton();
            cercaCofre = true;
        }
    }
    private void OnTriggerExit2D(Collider2D fuera)
    {

        CofreTesoro cofre = GetComponent<CofreTesoro>();
        print(name + "salio de" + fuera.gameObject.name);
        GameObject otro = fuera.gameObject;

        if (otro.tag == "Player")
        {
            cercaCofre = false;
            ControladorUI canvas = GetComponent<ControladorUI>();
            //Aplico el daño al otro invocando el metodo hacer daño
            canvas.desaparecerBoton();
        }
    }
}
