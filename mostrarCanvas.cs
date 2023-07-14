using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// esta clase maneja la logica para mostrar y ocultar el Canvas de preguntas en la escena.
/// </summary>
public class mostrarCanvas : MonoBehaviour
{
    /// <summary>
    /// esta variable hace referencia al canvas de preguntas
    /// </summary>
    public GameObject questionCanvas;

    /// <summary>
    /// este metodo oculta el canvas con las preguntas y reanuda el tiempo en el juego.
    /// </summary>
    public void mostrarCanv()
    {
        questionCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
