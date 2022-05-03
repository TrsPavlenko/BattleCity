using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController: MonoBehaviour
{
    public static int gold = 0;
    public static int killedEnemy = 0;

    public GameObject endPannel;
    public Text mainText;
    public Text goldText;

    [SerializeField] private int _enemyOnLevel = 10;
    // Start is called before the first frame update

    void Update()
    {
        if (killedEnemy == _enemyOnLevel)
        {
            endPannel.SetActive(true);
            mainText.text = "YOU WIN!!!";
            goldText.text = "YOUR SCORE: " + gold;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    
}
