using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Esta clase controla los movimientos del jugador,
/// cuenta con la capacidad de moverlo gracias a los botones, asi mismo controlla la velocidad
/// de correr o saltar
/// </summary>
public class movimiento : MonoBehaviour
{
    public float velocidadCorrer = 2;
    public float velocidadSaltar = 3;
    Rigidbody2D rb2D;
    public Button btnleft, btnrigth;
    // Start is called before the first frame update
    void Start()
    {
        rb2D= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moverDerecha(){
        rb2D.velocity = new Vector2(velocidadCorrer, rb2D.velocity.y);
    }
    public void moverIzquierda(){
         rb2D.velocity = new Vector2(-velocidadCorrer, rb2D.velocity.y);
    }
    public void saltar(){
         rb2D.velocity = new Vector2(rb2D.velocity.x, velocidadSaltar);
    }

}
