using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Personaje heroe;
    public int puntosDanio = 5;
    public float repetirDanio = 2f;
    private Animator miAnimador;
    public GameObject efectoVenenoPrefab;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    private void OnTriggerEnter2D(Collider2D veneno)
    {
        Veneno pocionV = GetComponent<Veneno>();
        print(name + "hizo colision con" + veneno.gameObject.name);
        GameObject otroObjeto = veneno.gameObject;
        if (otroObjeto.CompareTag("Player"))
        {
            heroe = otroObjeto.GetComponent<Personaje>();
            InvokeRepeating("DanioRepeat", 0f, repetirDanio);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 8f);
            miAnimador.SetTrigger("OBTENER");
            misSonidos.reproducir("BEBER");
            GameObject gas = Instantiate(efectoVenenoPrefab, transform);
        }
    }

    void DanioRepeat()
    {
        if (heroe != null)
        {
            misSonidos.reproducir("ENVENENADO");
            heroe.hacerDanio(puntosDanio, this.gameObject);
        }
    }
}