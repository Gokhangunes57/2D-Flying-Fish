using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float MaxTime ;
    float timer;
    public float MinY;
    public float MaxY;
    float randomY;
    
    
    
    void Start()
    {
       //SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isGameOver==false && GameManager.isGameStarted==true)
        {
            timer += Time.deltaTime;
            if (timer >=MaxTime)
            { 
            
                randomY = Random.Range(MinY, MaxY);
                SpawnObstacle();
                timer = 0;
            }  
        }
        
      
    }
    
    public void SpawnObstacle()
    {
      GameObject newObstacle = Instantiate(obstacle);
      newObstacle.transform.position = new Vector2(transform.position.x,randomY);
      
    }
}
