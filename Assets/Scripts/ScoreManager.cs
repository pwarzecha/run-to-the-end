using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{

    public Text highscoreText;
    //public float scoreCount; PlayerManager.distance;
    public float highscoreCount;

    public static float collectedFruitsCount = 0;
    public Text fruitText;
    void Start()
    {
        if(PlayerPrefs.GetFloat("highscore") != 0 )
        {
            highscoreCount = PlayerPrefs.GetFloat("highscore");
        }
        //fruits reset to 0
        //PlayerPrefs.SetFloat("fruitCount",0);
        if(PlayerPrefs.GetFloat("fruitCount") != 0 )
        {
            collectedFruitsCount = PlayerPrefs.GetFloat("fruitCount");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.distance > highscoreCount)
        {
            highscoreCount = PlayerManager.distance;
            PlayerPrefs.SetFloat("highscore",highscoreCount);
        }
        

        PlayerPrefs.SetFloat("fruitCount", collectedFruitsCount);
        fruitText.text = "" + collectedFruitsCount;
        highscoreText.text = "Highscore : " + highscoreCount;
    }

}
