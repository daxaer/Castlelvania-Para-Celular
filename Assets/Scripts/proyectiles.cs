using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class proyectiles : MonoBehaviour
{
    [SerializeField] private int daño;
    [SerializeField] private int identificador;
    bool cambiarColor = false;
    bool distancia = false;
    [SerializeField] private GameObject player;
    int proyectileID;
    public void MouseIn()
    {
        cambiarColor = true;
        if(cambiarColor && distancia)
        {
            GetComponent<SpriteRenderer>().material.color = Color.red;
        }
    }
    public void MouseExit()
    {
        cambiarColor = false;
        if (cambiarColor==false)
        {
            GetComponent<SpriteRenderer>().material.color = Color.white;
        }
    }
    public void MouseClick()
    {
        if (cambiarColor && distancia)
        {
            Destroy(gameObject);
        }
    }
    public int HacerDaño()
    {
        return daño;
    }
    public int SetProyectileID()
    {
        return daño;
    }
    public void SetDistancia(bool check)
    {
        distancia = check;
    }
}
