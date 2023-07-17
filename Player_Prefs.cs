using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// esta clase maneja la logica para guardar y cargar las preferencias del jugador.
/// </summary>
public class Player_Prefs : MonoBehaviour
{
    /// <summary>
    /// esta variable hace referencia al boton de guardar las preferencias.
    /// </summary>
    public Button guardarButton;

    /// <summary>
    /// esta variable hace referencia al campo input para la entrada del nombre del jugador.
    /// </summary>
    public InputField input;

    /// <summary>
    /// esta variable hace referencia al nombre del jugador.
    /// </summary>
    private string nombre;

    /// <summary>
    /// este metodo se llama al inicializa al cargar el script y asi mismo se carga el nombre del usuario actual
    ///  desde las preferencias del jugador y si el nombre del usuario actual no esta vacio, se carga la escena 4.
    /// </summary>
    void Start()
    {
        string playerName = PlayerPrefs.GetString("UsuarioActual");

        if (!string.IsNullOrEmpty(playerName))
        {
            // Si el PlayerName tiene un nombre asignado, cargar la escena "4"
            SceneManager.LoadScene(5);
        }
    }

    /// <summary>
    /// este metodo  guarda el nombre del jugador en las preferencias y despues carga la escena 4, 
    /// este metodo es llamado por el boton en el juego.
    /// </summary>
    public void GuardarNombre()
    {
        nombre = input.text;
        User newUser = new User();
        newUser.name = nombre;

        GameManager.instance.AgregarUsuario(newUser);

        PlayerPrefs.SetString("PlayerName", nombre);
        PlayerPrefs.SetString("UsuarioActual", nombre);
        PlayerPrefs.Save();
        Debug.Log("Nombre guardado: " + nombre);
        SceneManager.LoadScene(5);
    }
}
