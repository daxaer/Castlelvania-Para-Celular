using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool municionRecogida;
    public int turno;
    public int[] unidades1;
    public int[] unidades2;
    [SerializeField] private Image barraVida1;
    [SerializeField] private Image barraVida2;
    int vida1;
    int vida2;
    int maxvida1 = 20;
    int maxvida2 = 20;
    int equipo;

    private void Awake()
    {
        instance = this;
    }
    public void turnos(int turno)
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(turno == 0)
            {
                turno = 1;
            }
            else if(turno == 1)
            {
                turno = 0;
            }
            SetPersonajeEnTurno(turno);
        }
    }

    private int SetPersonajeEnTurno(int turno)
    {
        return turno;
    }

    public int turnoActual()
    {
        return turno;
    }

    public void SetVida()
    {
        if(equipo == 1)
        {
            vida1 = Mathf.Clamp(vida1, 0, maxvida1);
            barraVida1.fillAmount = vida1 / 20;
        }
        if (equipo == 2)
        {
            vida2 = Mathf.Clamp(vida1, 0, maxvida2);
            barraVida2.fillAmount = vida2 /100;
        }
    }
}
