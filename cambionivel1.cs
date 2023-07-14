using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Esta clase se encarga de controlar la aparicion del  canvas de preguntas del primer nivel, este se muestra despues de un cierto retraso.
/// </summary>
public class cambionivel1 : MonoBehaviour
{
    /// <summary>
    /// Referencia al canvas de preguntas del nivel 1.
    /// </summary>
    public GameObject preguntasCanvas;

    /// <summary>
    /// El retraso o lo que tarda en salir el canvas en segundos, antes de que se muestre en la escena.
    /// </summary>
    public float retraso = 4f;

    /// <summary>
    /// Variable de tiempo que se usa para diferenciar el tiempo del juego como un temporizador.
    /// </summary>
    private float timer = 0f;

    /// <summary>
    /// variable que se usa para verificar si ya existe el canvas de preguntas.
    /// </summary>
    private bool mostarCanvas = false;

    /// <summary>
    /// Este metodo es nativo de una clase de unity, el cual se actualiza cada frame, esto incremente el temporizador. 
    /// Si ha pasado el tiempo de retraso y el canvas de preguntas aun no se ha mostrado,
    /// se mostrara el canvas de preguntas.
    /// </summary>
    void Update()
    {
        // Incrementar el temporizador
        timer += Time.deltaTime;

        // Verificar si ha pasado el tiempo de retraso y si el canvas no se ha mostrado aun
        if (timer >= retraso && !mostarCanvas)
        {
            preguntasCanvas.SetActive(true);
            mostarCanvas = true;
        }
    }
}
