using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparar : MonoBehaviour
{
    InputController inputActions;
    [SerializeField] private int minPower = 0;
    [SerializeField] private int maxPower = 0;
    [SerializeField] private GameObject mira;
    [SerializeField] int turno;

    int poderActual;
    int currentAngle;
    [SerializeField] private SpriteRenderer flecha;

    public Lanzar lanzar;
    
    private void Start()
    {
        flecha.enabled = false;
    }
    private void Update()
    {
        if(Input.GetMouseButton(0) && turno == 1)
        {
            if(turno == GameManager.instance.turnoActual())
            {
                flecha.transform.position = mira.transform.position;
                flecha.enabled = true;
                CalcularAngulo();
                CalcularPoder();
            }
        }
        else if(Input.GetMouseButtonUp(0))
        {
            lanzar.fireProyectile(poderActual);
            flecha.enabled = false;
        }
    }

    private void CalcularPoder()
    {
        Vector3 mousePosicion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosicion.z = 0;

        float distancia = Vector3.Distance(mousePosicion, mira.transform.position);
        UpdatePower((int)distancia * 2);
        
    }

    private void CalcularAngulo()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 dir = mousePos - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        UpdateAngre((int)angle);
    }

    private void UpdateAngre(int angle)
    {
        currentAngle = angle;
        flecha.transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);
    }

    void UpdatePower(int distance)
    {
        poderActual = Mathf.Clamp(distance, minPower, maxPower);
        flecha.transform.localScale = new Vector2(poderActual/12, poderActual/12);
    }
}
