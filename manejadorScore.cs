using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// esta clase maneja la logica para mostrar el puntaje de los usuarios en la escena docente score.
/// </summary>
public class manejadorScore : MonoBehaviour
{
    /// <summary>
    /// esta variable hace referencia al objeto text para mostrar el puntaje.
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// esta clase hace referencia al gamemanager que se instancio al inicio del juego.
    /// </summary>
    private GameManager gameManager;

    /// <summary>
    /// este metodo se llama al inicializar del script y se obtiene la instancia del gamemanager para que se muestre despues el puntaje.
    /// </summary>
    private void Start()
    {
        gameManager = GameManager.instance; // Obtener la instancia del gamemanager
        ShowScore();
    }

    /// <summary>
    /// este metodo crea una cadena de texto con los nombres de los usuarios y sus puntajes,
    /// para luego establecer el texto del objeto en el canvas de esta escena.
    /// </summary>
    private void ShowScore()
    {
        string scores = "";

        foreach (User user in gameManager.users)
        {
            scores += user.name + ": " + user.score + "\n";
        }

        scoreText.text = scores;
    }
}
