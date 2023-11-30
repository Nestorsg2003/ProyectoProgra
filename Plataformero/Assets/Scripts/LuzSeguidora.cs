using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzSeguidora : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cavernicola;
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
                cavernicola.position.x,
                cavernicola.position.y + 2,
                -1);
    }
}
