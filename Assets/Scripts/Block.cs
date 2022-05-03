using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _health = 20;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("EnemyBullet"))
        {
            GetDamage(other.gameObject.GetComponent<Bullet>().Damage());
            Destroy(other.gameObject);
        }
    }

    private void GetDamage(float damage)
    {
        _health = _health - damage;
        if (_health <= 0)
        {
           Die();
        }
    }

    private void Die()
    {
       Destroy(gameObject);
    }
}
