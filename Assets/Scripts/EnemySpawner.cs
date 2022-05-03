using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    [SerializeField] private int _enemyCount = 3;
    [SerializeField] private float _delay = 5f;
    [SerializeField] private GameObject[] _enemyPrefabs;
    void Start()
    {
        StartCoroutine(Spawn(_delay));
    }

    // Update is called once per frame
    IEnumerator Spawn(float delay)
    {
        for (int i = 0; i<_enemyCount; i++)
        {
            int randomIndex = Random.Range(0, _enemyPrefabs.Length);
            Debug.Log(randomIndex);
            GameObject enemy = Instantiate(_enemyPrefabs[randomIndex], transform.position, Quaternion.identity);
            enemy.GetComponent<AIDestinationSetter>().target = target;
            yield return new WaitForSeconds(delay);
        }
    }
}
