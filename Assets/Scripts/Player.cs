using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float jumpForce = 5f;
    [SerializeField] private int personaje = 0;
    [SerializeField] private Transform mira;
    [SerializeField] private Camera camara;
    [SerializeField] private GameObject[] proyectil;
    InputController inputActions;
    Rigidbody2D rb;
    float fuerzaTirarObjeto = 20;
    int personajeEscogido = 0;
    int vida = 20;
    bool proyectilRecogido;
    int proyectileID;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        inputActions = new InputController();
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
    private void Start()
    {
        PosicionarCamara();
        inputActions.Gameplay.Jump.performed += _ => Jump();
        inputActions.Gameplay.Derecha.performed += _ => Derecha();
        inputActions.Gameplay.Izquierda.performed += _ => Izquierda();
        inputActions.Gameplay.SeleccionarPersonaje.performed += _ => SelecionarPersonaje();
        inputActions.Gameplay.Lanzarbjeto.performed += _ => LanzarProyectil();
    }
    private void Update()
    {
        if (personaje == personajeEscogido && proyectilRecogido == false)
        {
            transform.Translate(Axis * 5F * Time.deltaTime);
        }
    }
    void Jump()
    {
        if (personaje == personajeEscogido)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void Derecha()
    {
        if(personaje == personajeEscogido)
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
    }
    void Izquierda()
    {
        if(personaje == personajeEscogido)
        {
            transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
        }
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();
    public void BajarVida(int daño)
    {
        vida = vida - daño;
        Debug.Log("vida" + vida);
        if(vida==0)
        {
            Destroy(gameObject);
        }
    }
    public void LanzarProyectil()
    {
        if (personaje == personajeEscogido && proyectilRecogido == true)
        {
            proyectilRecogido = false;
            GameObject nuevoProyectil =  Instantiate(proyectil[proyectileID], mira.transform.position, Quaternion.identity);
            fuerzaTirarObjeto = Random.Range(30, 60);
            Vector2 dir = (mira.position - transform.position).normalized;

            nuevoProyectil.GetComponent<Rigidbody2D>().AddForce(fuerzaTirarObjeto * dir, ForceMode2D.Impulse);
            camara.transform.position = nuevoProyectil.transform.position + new Vector3(0, 0, -20f);
            camara.transform.SetParent(nuevoProyectil.transform);
        }
        StartCoroutine(SeguimientoCamara());
    }
    IEnumerator SeguimientoCamara()
    {
        Debug.Log("Corrutina");
        yield return new WaitForSeconds(8f);
        proyectilRecogido = false;
        SelecionarPersonaje();
    }

    public void PosicionarCamara()
    {
        Debug.Log("Personaje" + personaje + "PersonajeEscogido" + personajeEscogido );

        if (personaje == personajeEscogido)
        {
            Debug.Log("posicionCorrecta");

            camara.transform.position = gameObject.transform.position + new Vector3(0, 0, -20f);
            camara.transform.SetParent(gameObject.transform);
        }
    }
    void SelecionarPersonaje()
    {
        personajeEscogido++;

        if (personajeEscogido == 2)
        {
            personajeEscogido = 0;
        }
        Debug.Log("Seleccion" + personajeEscogido);

        PosicionarCamara();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Proyectile")) // cambiarlo a player
        {
            BajarVida(collision.gameObject.GetComponent<proyectiles>().HacerDaño());
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Proyectile")) // cambiarlo a player
        {
            collision.gameObject.GetComponent<proyectiles>().SetDistancia(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Proyectile")) // cambiarlo a player
        {
            collision.gameObject.GetComponent<proyectiles>().SetDistancia(false);
        }
    }
    public void SetProyectile(bool recoger)
    {
        proyectilRecogido = recoger;
    }
}
