using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    //Este es un atributo de la clase
    //que funciona como referencia a
    //la pelota de la escena
    public Transform Pelota;
    void Start()
    {
        
    }

    void Update()
    {
        //Corta las lineas largas para que sean mas cortas pero ver punto y coma
        //le coloco la posicion de la pelota
        //a la camara, excepto en z
        transform.position =
            new Vector3(
                Pelota.position.x,
                Pelota.position.y,
                -1);
    }
}
