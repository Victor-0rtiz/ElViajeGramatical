using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// La clase GameManager es la que maneja la logica del juego.
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Instancia  de la clase GameManager para tener acceso global.
    /// </summary>
    public static GameManager instance;

    /// <summary>
    /// Lista de usuarios en el juego para guardarlos en formato json.
    /// </summary>
    public List<User> users = new List<User>();

    /// <summary>
    /// Usuario activo en el juego antes de destruirse para crear otro.
    /// </summary>
    public User activeUser;

    /// <summary>
    /// Puntaje del jugador actual.
    /// </summary>
    public int currentScore = 0;

    /// <summary>
    /// Awake se llama cuando el script se esta cargando.
    /// Se utiliza para inicializar las variables o estado del juego antes de que comience el jugador a jugar,
    /// y es donde se inicializa la instancia de la clase GameManager.
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        CargarUsuarios();
    }

    /// <summary>
    /// Agrega un nuevo usuario a la lista de usuarios que se guardaran en formato json.
    /// </summary>
    public void AgregarUsuario(User user)
    {
        users.Add(user);
    }

    /// <summary>
    /// Guarda la lista de usuarios en las preferencias del jugador en formato json.
    /// </summary>
    public void GuardarUsuarios()
    {
        PlayerPrefs.SetString("UserList", JsonUtility.ToJson(users));
    }

    /// <summary>
    /// verifica si Userlist contiene datos y carga la lista de usuarios de las preferencias del jugador.
    /// </summary>
    public void CargarUsuarios()
    {
        if (PlayerPrefs.HasKey("UserList"))
        {
            string json = PlayerPrefs.GetString("UserList");
            users = JsonUtility.FromJson<List<User>>(json);
        }
    }

    /// <summary>
    /// Establece el usuario que estara activo en el juego.
    /// </summary>
    public void SetActiveUser(User user)
    {
        activeUser = user;
    }

    /// <summary>
    /// Aumenta el puntaje del jugador actual.
    /// </summary>
    public void IncreaseScore(int amount)
    {
        currentScore += amount;
    }

    /// <summary>
    /// Obtiene el puntaje del actual jugador.
    /// </summary>
    public int GetCurrentScore()
    {
        return currentScore;
    }
}
