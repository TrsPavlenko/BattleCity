using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    
    public GameObject endPannel;
    public Text mainText;
    public Text goldText;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet") || other.gameObject.CompareTag("Bullet"))
        {
            Lose();
        }
    }
    
    public void Lose()
    {
        endPannel.SetActive(true);
        mainText.text = "GAME OVER";
        goldText.text = "YOUR SCORE: " + GameController.gold;
    }
}
