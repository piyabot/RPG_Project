using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithNPC : MonoBehaviour
{
    public GameObject Dia1;
    public GameObject Dia2;
    public GameObject Dia3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("One"))
        {
            Dia1.SetActive(true);
        }
        else
        {
            Dia1.SetActive(false);
        }
        if (collision.CompareTag("Two"))
        {
            Dia2.SetActive(true);
        }
        else
        {
            Dia2.SetActive(false);
        }
        if (collision.CompareTag("Three"))
        {
            Dia3.SetActive(true);
        }
        else
        {
            Dia3.SetActive(false);
        }
    }
}
