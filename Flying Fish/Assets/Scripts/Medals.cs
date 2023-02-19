using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medals : MonoBehaviour
{
    
    public Sprite metalMedal, silverMedal, goldMedal,bronzeMedal;
    private Image img;
    
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
      
        int  gamescore = GameManager.gamescore;
        if (gamescore>=0 && gamescore<=10)
        {
            img.sprite = metalMedal;
        }
        else if (gamescore>10 && gamescore<=20)
        {
            img.sprite = silverMedal;
        }
        else if (gamescore>20 && gamescore<=30)
        {
            img.sprite = bronzeMedal;
        }
        else if (gamescore>30)
        {
            img.sprite = goldMedal;
        }
    }
}
