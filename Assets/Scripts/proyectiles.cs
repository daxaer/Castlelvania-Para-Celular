using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class proyectiles : MonoBehaviour
{
    [SerializeField] private int da�o;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (CompareTag("Unidad"))
        {
            collision.gameObject.GetComponent<Player>().BajarVida(da�o);
        }*/
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
