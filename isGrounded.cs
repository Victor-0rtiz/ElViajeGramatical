using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// La clase isGrounded verifica si el objeto que esta asignado con esta clase esta en contacto con el suelo.
/// </summary>
public class isGrounded : MonoBehaviour
{
    /// <summary>
    /// Esta variable estatica que indica si el objeto con esta clase esta en contacto con el suelo.
    /// </summary>
    public static bool IsGrounded;

    /// <summary>
    /// Este metodo se llama cuando el objeto con esta clase entra en contancto con el suelo.
    /// Se pone isGrounded a verdadero, para indicar que esta en contacto con el suelo.
    /// </summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded = true;
    }

    /// <summary>
    /// Este metodo se llama cuando el objeto con esta clase deja de tocar el otro objeto.
    /// Se pone isGrounded a falso, para indicar que el objeto ya no esta en contacto con el suelo.
    /// </summary>
    private void OnTriggerExit2D(Collider2D other)
    {
        IsGrounded = false;
    }
}
