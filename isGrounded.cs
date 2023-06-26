using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{
    public static bool IsGrounded;
    // Start is called before the first frame update
    private void  OnTriggerEnter2D(Collider2D collision)
    {
        
        IsGrounded = true;
    }
    
    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D other)
    {
        
        IsGrounded = false; 
    }
    
}
