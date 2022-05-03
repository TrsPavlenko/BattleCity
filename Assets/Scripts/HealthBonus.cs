using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer _sr;

    private BoxCollider2D _collider;
    // Start is called before the first frame update
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _collider = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Health+");
            _sr.enabled = false;
            _collider.enabled = false;
            other.gameObject.GetComponent<PlayerHealth>().health += 20;

        }
    }
}
