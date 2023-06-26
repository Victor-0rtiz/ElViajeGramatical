using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Esta clase encargada de controllar el movimiento asi mismo
/// la velocidad de salto y de movimiento.
/// </summary>
public class playermovimiento : MonoBehaviour
{
    /// <value>
    /// Controlan el movimiento del joystick ya horizontal para caminar 
    /// asi como el de salto para el vertical
    /// </value>
    float horizontalMove = 0;    
    float verticalMove = 0;


    /// <value>
    /// Controlan el la velocidad con la que se mueve el personaje
    /// ya sea por el salto o por caminar
    /// </value>
    public float runSpeedHorizontal = 3;
    public float runSpeedVertical = 3;
    public float runSpeed = 1;

    /// <summary>
    /// Este isntancia de RigidBody se usa para controlar el cuerpo rigido del personaje
    /// </summary>
    Rigidbody2D  rigidbody2d;

    /// <value>
    /// Esta instancia de Joystick se usa para enlazar los movimientos verticales y horizontales
    /// para que se mueva el personaje
    /// </value>
    public Joystick joystick;

    /// <value>
    /// Esta variable sirve para controlar la fuerza de salto, eso se basa en la altura que 
    /// podra saltar el personaje
    /// </value>
    public float jumpForce =2;
 
    /// <summary>
    /// El metodo start se usa para asignar el rigidbody del personaje a la variable
    /// rigidbody, esto sirve para poder controllar el movimiento del personaje
    /// al interactuar con el terreno
    /// </summary>
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Esta funcion sirve para mover al personake 
    /// </summary>
    /// <remarks>
    /// Esto se hace gracias a controllar la posicion en que se mueve el <c>joystick</c>
    /// transforma la posicion del personaje y lo mueve conforme se mueve
    /// </remarks>
    void Update()
    {
        if (joystick.Vertical >= 0.5f && isGrounded.IsGrounded)
        {
            jump();
        }
        // verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, verticalMove , 0) * Time.deltaTime * runSpeed;
    }

/// <summary>
/// Esta funcion se usa para que el personaje salte
/// </summary>
/// <remarks>
/// Esto es gracias a obtener el cuerpo rigido del personaje y moverlo en un nuevo vector
/// </remarks>
    public void jump(){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}

