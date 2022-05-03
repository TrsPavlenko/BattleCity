using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    
    public GameObject endPannel;
    public Text mainText;
    public Text goldText;
    public GameObject healthBar;
    // Start is called before the first frame update
    
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetDamage(float damage)
    {
        health = health - damage;
        healthBar.GetComponent<Slider>().value = health;
        if (health <= 0)
        {
            Lose();
            Die();
        }
    }

    public virtual void Die()
    {
       Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            GetDamage(other.gameObject.GetComponent<Bullet>().Damage());
            Destroy(other.gameObject);
        }
    }
    
    public void Lose()
    {
        endPannel.SetActive(true);
        mainText.text = "GAME OVER";
        goldText.text = "YOUR SCORE: " + GameController.gold;
    }
}
