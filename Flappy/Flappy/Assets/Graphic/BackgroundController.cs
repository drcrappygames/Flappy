using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private float deathPoint = -8f;
    [SerializeField]
    private float startPointX = 8f;
    [SerializeField]
    GameObject[] backgrounds;

    void Update()
    {
        foreach (GameObject g in backgrounds)
        {
            g.transform.Translate(-speed * Time.deltaTime, 0, 0);
            if(g.transform.position.x <= deathPoint)
            {
                g.transform.position = new Vector3(startPointX, 0, 0);
            }
        }

        
    }
}
