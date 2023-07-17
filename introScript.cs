using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// esta clase maneja la logica para el cambio en el intro, ya que con esta se cambia al menu.
/// </summary>
public class introScript : MonoBehaviour
{
    /// <summary>
    /// Esta variable hace referencia a los segundos esperados para cambiar la escena
    /// </summary>
    public float retraso=  12f;


    /// <summary>
    /// Esta variable hace referencia al tiempo recorrido que inicia en 0
    /// </summary>
    public float timer=  0f;
    

    /// <summary>
    /// Esta funcion viene por defecto en las clases de unity, en este caso la clase 
    /// se usa como cronometro, cuando llega a los segundos esperados
    /// cambia la escena
    /// </summary>
    void Update()
    {
        timer += Time.deltaTime;

        // Verificar si ha pasado el tiempo de retraso 
        if (timer >= retraso)
        {
             SceneManager.LoadScene(1);
        }
    }
}
