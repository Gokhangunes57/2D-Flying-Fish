using System;
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
   public Score score;
   private bool touchGround;
   public GameManager gameManager;
   public Sprite fishDead;
   private SpriteRenderer sp;
   Animator anim;
   public ObstacleSpawner obstacleSpawner;
   
   
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();  
      rb.gravityScale = 0;
      sp = GetComponent<SpriteRenderer>();
      anim = GetComponent<Animator>();
      
     
    }

    // Update is called once per frame
    void Update()
    {
     FishSwim();
     

        
        
            
       
    }

    private void FixedUpdate()
    {
        FishRotation();
    }

    void FishSwim()
    {
        if (Input.GetMouseButtonDown(0)&&GameManager.isGameOver==false)
        {
            if (GameManager.isGameStarted==false)
            {
              rb.gravityScale = 4;
              rb.velocity = Vector2.zero;
              rb.velocity = new Vector2(rb.velocity.x, speed);
              obstacleSpawner.SpawnObstacle();
              GameManager.GameHasStarted();
              
                
            }
            
            else{
                rb.velocity = Vector2.zero;
                rb.velocity = new Vector2(rb.velocity.x, speed);
                
            }
            
            
            
            
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

        if (touchGround==false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle); 
        }
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("obstacle"))
        {
          score.Scored();
        }
        else if (col.gameObject.CompareTag("column"))
        {
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            if (GameManager.isGameOver==false)
            {
                gameManager.GameOver();
                GameOver();
                
            }
            else
            {
               GameOver();
            }
          
        }
    }
    
    void GameOver()
    {
        touchGround = true;
        transform.rotation = Quaternion.Euler(0, 0, -90);
        sp.sprite = fishDead;
        anim.enabled = false;
    }
}
