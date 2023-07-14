using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// esta clase enemigo representa al dinosaurio que se mueve hacia el jugador y realiza pequeños saltos, esta es usada en los niveles para darle movimiento y funcionalidad al dinosaurio.
/// </summary>
public class enemigo : MonoBehaviour
{
    /// <summary>
    /// Velocidad a la que se mueve el dinosaurio.
    /// </summary>
    public float speed = 2.0f;

    /// <summary>
    /// Fuerza con la que el dinosaurio salta
    /// </summary>
    public float fuerzaSalto = 5f;

    /// <summary>
    /// Distancia que se utiliza para verificar si el dinosaurio esta en tocando el suelo.
    /// </summary>
    public float groundCheckDistance = 0.2f;

    /// <summary>
    /// La capa que se utilizara verificar los elementos con la etiqueta suelo
    /// </summary>
    public LayerMask groundLayer;

    /// <summary>
    /// Este canvas que se activara cuando el dinosaurio toque al jugador.
    /// </summary>
    public GameObject canvasPreguntas;

    /// <summary>
    /// Esta variable hace referencia al jugador, se usa para mover al dinosaurio hacia el jugador
    /// </summary>
    private Transform target;

    /// <summary>
    /// El metodo Start se usa para que el dinosaurio busque al jugador en la escena y establece su posicion como el objetivo.
    /// </summary>
    void Start()
    {
        // Encuentra al jugador en la escena
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    /// <summary>
    /// En cada frame, el dinosaurio calcula la direccion hacia el jugador, se mueve en esa direccion y va realizando unos pequeño saltos si esta en el suelo.
    /// </summary>
    void Update()
    {
        // Calcula la direccion hacia el jugador
        Vector2 direction = (Vector2)target.position - (Vector2)transform.position;
        direction.Normalize();

        // Mueve el dinosaurio hacia el jugador
        transform.position = (Vector2)transform.position + direction * speed * Time.deltaTime;

        // Hacer que el dinosario de pequeños saltos
        if (IsGrounded())
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    /// <summary>
    /// Este metodo verifica si el dinosaurio esta en el suelo utilizando un raycast hacia abajo para que salte.
    /// </summary>
    /// <returns>Devuelve verdadero si el dinosaurio esta en el suelo, falso en caso contrario.</returns>
    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Este metodo se invoca cuando el dinosaurio entra en colision el jugador, 
    /// se mostrara el canvas de preguntas y se detendra el tiempo del juego.
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Activa el GameObject cuando el dinosaurio toque al jugador
            canvasPreguntas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
