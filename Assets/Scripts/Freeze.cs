using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Freeze : MonoBehaviour
{
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
            Debug.Log("Freeze");
            _sr.enabled = false;
            _collider.enabled = false;
            StartCoroutine(FreezeEnemy());
        }
    }

    IEnumerator FreezeEnemy()
    {
     GameObject[] Enemys = GameObject.FindGameObjectsWithTag("Enemy");
     for (int i = 0; i < Enemys.Length; i++)
     {
         Enemys[i].GetComponent<AIPath>().canMove = false;
     }
     yield return new WaitForSeconds(10f);
     for (int i = 0; i < Enemys.Length; i++)
     {
         Enemys[i].GetComponent<AIPath>().canMove = true;
     }
    Destroy(gameObject);
    }
}
