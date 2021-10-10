using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chad_Weapon : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
    }
}
