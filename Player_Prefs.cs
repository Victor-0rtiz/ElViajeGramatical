using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Prefs : MonoBehaviour
{
    
    public Button guardarButton;
    public InputField input; 
    private string nombre;
    
    // Start is called before the first frame update
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");

        if (!string.IsNullOrEmpty(playerName))
        {
            // Si el PlayerName tiene un nombre asignado, cargar la escena "NombreDeLaEscena"
            SceneManager.LoadScene("nivel 1");
        }
        else
        {
            // Si el PlayerName no tiene un nombre asignado, mostrar un mensaje en la consola
            Debug.Log("No se ha asignado un nombre al PlayerName.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GuardarNombre()
    {  
        nombre = input.text;
    PlayerPrefs.SetString("PlayerName", nombre);
    PlayerPrefs.Save();
    Debug.Log("Nombre guardado: " + nombre);
    }

}
