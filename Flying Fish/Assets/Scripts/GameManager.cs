using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector2 bottomLeft;
    public static bool isGameOver;
    public GameObject gameOverpanel;
    public static bool isGameStarted;
    public GameObject getReady;
    
    
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void Start()
    {
        isGameOver = false;
        isGameStarted = false;
    }
    public void GameHasStarted()
    {
        isGameStarted = true;
        getReady.SetActive(false);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameOver()
    {
        isGameOver = true;
        gameOverpanel.SetActive(true);
    }
}
