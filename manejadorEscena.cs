using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Esta clase se encarga de cambiar entre las escenas en el juego, esto ayuda a tener un script reutilizable
/// </summary>
public class manejadorEscena : MonoBehaviour
{
    /// <summary>
    /// Este metodo esta encargado de cambiar a una escena especificada, este metodo se asigna generalmente a eventos en botones
    /// </summary>
    /// <param name="escena"> Es el parametro que se ingresa para ir a la escena indicada</param>
    /// <remarks>
    /// Este metodo utiliza la api sceneManager de Unity para cambiar la escena.
    /// </remarks>
    /// <example>
    /// Ejemplo de uso:
    /// <code>
    /// SceneManager.LoadScene(1);
    /// </code>
    /// </example>
    public void cambiarEscenas(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}
