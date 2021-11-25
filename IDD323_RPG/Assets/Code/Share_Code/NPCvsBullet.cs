using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCvsBullet : MonoBehaviour
{
    public GameObject Hit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Hit.SetActive(true);
        }
        else
        {
            Hit.SetActive(false);
        }
    }
}
