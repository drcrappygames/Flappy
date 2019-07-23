using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFail : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.GetComponent<PlayerController>() == null)
            return;

        collision.collider.gameObject.GetComponent<PlayerController>().Failed();
    }

}
