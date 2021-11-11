using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] float jumpForce = 5f;
    [SerializeField] private int personaje = 0;
    [SerializeField] private Transform mira;
    [SerializeField] private Transform flecha;
    [SerializeField] private Camera camara;
    [SerializeField] private GameObject[] proyectil;
    [SerializeField] int turno;
    [SerializeField] int turnoActual;
    InputController inputActions;
    Rigidbody2D rb;
    int personajeEscogido = 0;
    int vida = 20;
    bool proyectilRecogido;
    int proyectileID;

    [SerializeField] private Image barraVida1;
    [SerializeField] private Image barraVida2;
    int vida1;
    int vida2;
    int maxvida1 = 20;
    int maxvida2 = 20;
    [SerializeField] private int equipo;

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
    }
    private void Update()
    {
        if (personaje == personajeEscogido && proyectilRecogido == false)
        {
            transform.Translate(Axis * 5F * Time.deltaTime);
            //camara.transform.position = transform.position + new Vector3(0, 10,-10);
        }
    }
    void Jump()
    {
        if (personaje == personajeEscogido && proyectilRecogido == false)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void Derecha()
    {
        if(personaje == personajeEscogido && proyectilRecogido == false)
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            flecha.position = mira.position;
        }
    }
    void Izquierda()
    {
        if(personaje == personajeEscogido && proyectilRecogido == false)
        {
            transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
            flecha.position = mira.position;
        }
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();


    //////////////////////////////////VIDA/////////////////////////
    public void BajarVida(int daño)
    {
        vida = vida - daño;
        if(vida==0)
        {
            Destroy(gameObject);
        }
    }
    //////////////////////////////////TURNO/////////////////////////
    public void PosicionarCamara()
    {

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
        if (collision.gameObject.CompareTag("Proyectile") && turno != turnoActual ) // cambiarlo a player
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
    public void SetVida()
    {
        if (equipo == 1)
        {
            vida1 = Mathf.Clamp(vida1, 0, maxvida1);
            barraVida1.fillAmount = vida1 / 20;
        }
        if (equipo == 2)
        {
            vida2 = Mathf.Clamp(vida1, 0, maxvida2);
            barraVida2.fillAmount = vida2 / 100;
        }
    }
}
