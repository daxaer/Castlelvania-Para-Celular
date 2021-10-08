using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    InputController inputActions;
    Rigidbody2D rb;
    [SerializeField, Range(1f, 10f)] float jumpForce = 5f;
    [SerializeField, Range(1f, 10f)] float dashForce = 10f;
    bool dash = true;

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
        inputActions.Gameplay.Jump.performed += _ => Jump();
        inputActions.Gameplay.Atack.performed += _ => Atack();
        inputActions.Gameplay.Dash.performed += _ => Dash();
        inputActions.Gameplay.Shield.performed += _ => Shield();
        inputActions.Gameplay.FlipLeft.performed += _ => FlipXleft();
        inputActions.Gameplay.FlipXRight.performed += _ => FlipXright();
    }
    private void Update()
    {
        transform.Translate(Axis * 5F * Time.deltaTime);
    }
    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    void Atack()
    {
        
    }
    void Dash()
    {
        if(dash)
        {
            dash = false;
            StartCoroutine("DashColdDown");
            if (gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                rb.AddForce(Vector2.right * dashForce, ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(Vector2.left * dashForce, ForceMode2D.Impulse);
            }
        }
    }
    void Shield()
    {
        
    }
    void FlipXright()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }
    void FlipXleft()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }
    Vector2 Axis => inputActions.Gameplay.Axis.ReadValue<Vector2>();
    
    IEnumerator DashColdDown()
    {
        yield return new WaitForSeconds(5f);
        dash = true;
    }
}
