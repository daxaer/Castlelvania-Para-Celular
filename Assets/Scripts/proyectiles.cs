using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class proyectiles : MonoBehaviour
{
    [SerializeField] private int da�o;
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
    public int HacerDa�o()
    {
        return da�o;
    }
    public int SetProyectileID()
    {
        return da�o;
    }
    public void SetDistancia(bool check)
    {
        distancia = check;
    }
}
