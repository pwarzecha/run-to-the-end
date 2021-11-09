using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;
    public static bool isGamePaused;
    public GameObject pausePanel;
    public GameObject pauseButton;

    public static int numberOfFruits;
    public Text coinsText;
    public static int distance;
    public Text distanceText;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale =  1;
        isGameStarted = false;
        numberOfFruits = 0;
        distance = 0;
        isGamePaused = false;
        pauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        
        if(isGamePaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            pauseButton.SetActive(false);
        }
        else {
            if (gameOver)
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true); 
                pausePanel.SetActive(false);
                pauseButton.SetActive(false);
            }
            else {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            pauseButton.SetActive(true);
            }
            
        }

        coinsText.text = "" + numberOfFruits;
        
        distanceText.text = "SCORE : " + distance;

        if (SwipeManager.tap  && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
