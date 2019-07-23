using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float deathPointX = -10f;

    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        if(transform.position.x < deathPointX)
        {
            PoolIt();
        }
    }

    void PoolIt()
    {
        transform.GetComponentInParent<ObstacleSpawner>().AddToPool(gameObject);
    }
}
