using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;
    public Text etiquetaScore;

    void Update()
    {
        etiquetaHPHeroe.text =
            heroe.hp + "/" + heroe.hpMax;
        float porcentajeHP = 
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        etiquetaScore.text = "Score: " + heroe.score.ToString();
    }
}
