using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    private BoxCollider2D box;
    private float width;
    float obstacleWidth;
    
    void Start()
    {

        if (gameObject.CompareTag("ground"))
        {
            box = GetComponent<BoxCollider2D>();
            width = box.size.x;
        }
        else if (gameObject.CompareTag("obstacle"))
        {
           obstacleWidth= GameObject.FindGameObjectWithTag("column").GetComponent<BoxCollider2D>().size.x;
        }
        {
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (gameObject.CompareTag("ground"))
        {
            if (transform.position.x <= -width)
            {
                transform.position = new Vector2(transform.position.x + 2*width, transform.position.y);
            }
        }
        
        else if (gameObject.CompareTag("obstacle"))
        {
            if (transform.position.x <= GameManager.bottomLeft.x-obstacleWidth)
            {
                Destroy(gameObject);
            }
        }
        
        
       
    }
}
