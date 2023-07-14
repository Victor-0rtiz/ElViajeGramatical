using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// esta clase se encarga de eliminar la clave "UsuarioActual" de PlayerPrefs
/// esto pasa cuando el jugador colisiona con un objeto marcado con la etiqueta "salida" que en este caso son las cuevas.
/// esto es util ya que con esto se puede agregar mas usuarios al juego
/// </summary>
public class eliminadorActual : MonoBehaviour
{
    
    /// <summary>
    /// Este metodo se usa cuando el jugador colisiona con otro objeto en la escena.
    /// Si el objeto tiene la etiqueta "salida", se eliminara la clave "UsuarioActual" de PlayerPrefs.
    /// <remarks>
    /// Este metodo es nativo de Unity como una funcionalidad.
    /// </remarks>
    /// </summary>
    /// <param name="collision"> este parametro se usa para comprobar la colision del personaje.</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprueba si el objeto con el que el jugador colisiono tiene la etiqueta "ChangeScene"
        if (collision.gameObject.CompareTag("salida"))
        {
            // Cambia a la siguiente escena
            PlayerPrefs.DeleteKey("UsuarioActual");
            Debug.Log("correcto");
        }
    }
}
