using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// La clase letrasmanejador se usa para la logica de mostrar las letras en el canvas de los niveles.
/// </summary>
public class letrasManejador : MonoBehaviour
{
    /// <summary>
    /// esta variable hace referencia al canvas que contiene las letras.
    /// </summary>
    public GameObject imagenCanvas;

    /// <summary>
    /// esta variable hace referencia a la etiqueta de cada letra
    /// </summary>
    public string etiquetaLetra;

    /// <summary>
    /// esta variable hace referencia a la letra en el canvas.
    /// </summary>
    private Image imagenLetra;

    /// <summary>
    /// awake se llama cuando el script esta cargando y se utiliza para inicializar las variables del juego y 
    /// se busca la imagen de la letra en el canvas por su etiqueta.
    /// </summary>
    private void Awake()
    {
        // Buscar la imagen de la letra en el Canvas mediante su etiqueta
        imagenLetra = imagenCanvas.transform.Find(etiquetaLetra)?.GetComponent<Image>();
    }


     /// <summary>
    /// este metodo se llama cuando el jugador entra en contacto con el objeto de la letra.
    /// se oculta el objeto de la letra y se muestra la imagen de la letra en el canvas.
    /// </summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Ocultar el objeto de letra
            gameObject.SetActive(false);

            // Mostrar la imagen de la letra en el canvas si esta disponible
            if (imagenLetra != null)
            {
                imagenLetra.gameObject.SetActive(true);
            }
        }
    }
}
