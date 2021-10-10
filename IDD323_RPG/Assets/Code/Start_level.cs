using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_level : MonoBehaviour
{
    public GameObject Cover;
    public GameObject Play;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Cover.SetActive(false);
            Play.SetActive(true);
        }
    }
}
