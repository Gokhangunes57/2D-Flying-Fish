using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
   Rigidbody2D rb;
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();  
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 9f);
        }
        {
            
        }
    }
}
