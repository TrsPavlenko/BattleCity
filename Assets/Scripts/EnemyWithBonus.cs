using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyWithBonus : Enemy
{
    [SerializeField] private GameObject[] _bonusPrefabs;
    // Start is called before the first frame update
    public override void Die()
    {
        int randomIndex = Random.Range(0, _bonusPrefabs.Length);
        Instantiate(_bonusPrefabs[randomIndex], transform.position, quaternion.identity);
        base.Die();
    }
}
