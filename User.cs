using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// esta clase user es una clase serializable que representa a un usuario en el juego.
/// </summary>
[System.Serializable]
public class User
{
    /// <summary>
    /// esta variable hace referencia al nombre del usuario.
    /// </summary>
    public string name;

    /// <summary>
    /// esta variable hace referencia al score del usuario.
    /// </summary>
    public int score;
}