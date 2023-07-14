using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// esta clase manejadorPreguntas maneja la logica de las preguntas y el puntaje de cada escena.
/// </summary>
public class manejadorPreguntas : MonoBehaviour
{
    /// <summary>
    /// variable que hace referencia al puntaje del nivel.
    /// </summary>
    public int puntajeEscena;

    /// <summary>
    /// esta variable hace referencia al gamemanager que se inicializa al inicio del juego.
    /// </summary>
    private GameManager gameManager;

    /// <summary>
    /// este metodo se llama de primero al inicializar el script y se obtiene la instancia del gamemanager
    /// </summary>
    private void Start()
    {
        gameManager = GameManager.instance;
    }

    /// <summary>
    /// este metdo se llama cuando se selecciona una respuesta y la respuesta es correcta,
    ///  aumenta el puntaje del usuario actual.
    /// </summary>
    public void seleccionada(bool esCorrecto)
    {
        if (esCorrecto)
        {
            // Aumentar el puntaje utilizando el GameManager
            foreach (User user in gameManager.users)
            {
                int lastIndex = gameManager.users.Count - 1;
                gameManager.users[lastIndex].score += puntajeEscena;
            }
        }
    }
}
