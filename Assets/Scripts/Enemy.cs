using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _health;
    [SerializeField] private int bonus;
    

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetDamage(float damage)
    {
        _health = _health - damage;
        if (_health <=0) Die();
    }

    public virtual void Die()
    {
        GameController.gold += bonus;
        GameController.killedEnemy += 1;
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            GetDamage(other.gameObject.GetComponent<Bullet>().Damage());
            Destroy(other.gameObject);
        }
    }
}
