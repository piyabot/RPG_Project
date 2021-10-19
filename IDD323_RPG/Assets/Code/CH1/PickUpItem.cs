using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}