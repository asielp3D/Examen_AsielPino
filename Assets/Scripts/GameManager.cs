using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public List <GameObject> enemiesInScreen;
    public Text coinText;
    int coins;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            KillWindowEnemies();
        }
    }

    void KillWindowEnemies()
    {
        for (int i = 0; i < enemiesInScreen.Count; i++)
        {
            Destroy(enemiesInScreen[i]);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}