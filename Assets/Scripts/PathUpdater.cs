using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PathUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PathUpdate());
    }

    IEnumerator PathUpdate()
    {
        while (true)
        {
            AstarPath.active.Scan();
            Debug.Log("Path Update");
            yield return new WaitForSeconds(5f);
        }
    }
    // Update is called once per frame
}
