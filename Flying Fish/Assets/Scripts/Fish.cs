using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
   Rigidbody2D rb;
   [SerializeField] float speed = 9f;
   private int angle;
   private int MaxAngle = 20;
   private int MinAngle = -60;
   
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();  
     
    }

    // Update is called once per frame
    void Update()
    {
     FishSwim();
     FishRotation();

        
        
            
       
    }

    void FishSwim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }

    void FishRotation()
    {
        if (rb.velocity.y > 0)
        {
            if(angle<=MaxAngle)
            {
                angle += 4;
            }
        }
        else if(rb.velocity.y<-1.3f)
        {
            if(angle>=MinAngle)
            {
                angle -= 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
