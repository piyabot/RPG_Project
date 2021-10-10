using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
{
    public GameObject Lose;
    public GameObject Play;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Lose.SetActive(true);
            Play.SetActive(false);
        }
    }
}
