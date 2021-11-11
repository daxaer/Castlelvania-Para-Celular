using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour
{
    public GameObject proyectile;
    public Transform muzzle;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void fireProyectile(int power)
    {
        GameObject insProj = Instantiate(proyectile, muzzle.transform.position, muzzle.transform.rotation);
        insProj.GetComponent<proyectiles>().Initialize(power);
    }
}
