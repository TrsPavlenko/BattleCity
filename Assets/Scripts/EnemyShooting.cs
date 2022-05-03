using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : Shooting
{
    private float _shootDelay = 0.5f;
    private bool _readyToShoot = true;
   // Start is called before the first frame update
    void FixedUpdate()
    {
       
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawRay(transform.position, transform.up, Color.red);

        if (hit)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                Debug.Log(hit.transform.name);
                if (_readyToShoot) StartCoroutine(shootingWithDelay());
            }
        }
    }

    IEnumerator shootingWithDelay()
    {
        _readyToShoot = false;
        Shoot();
        yield return new WaitForSeconds(_shootDelay);
        _readyToShoot = true;
    }
}
