using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private float spawnDelay = 1f;
    [SerializeField]
    private float spawnPositionX = 8f;

    public bool Lost = false;

    private List<GameObject> objectPool = new List<GameObject>();

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Lost)
        {
            Vector3 spawnPosition = new Vector3(spawnPositionX, Random.Range(-3f, 3f), 0);
            GameObject tempObstacle = GetFromPool();
            tempObstacle.transform.position = spawnPosition;
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    private GameObject GetFromPool()
    {
        if(objectPool.Count == 0)
        {
            return Instantiate(obstacle, transform);
        }
        GameObject objToReturn;
        objToReturn = objectPool[0];
        objectPool.RemoveAt(0);
        objToReturn.SetActive(true);
        return objToReturn;
    }

    public void AddToPool(GameObject go)
    {
        go.SetActive(false);
        go.transform.position = new Vector3(-20, 0, 0);
        objectPool.Add(go);
    }
}
