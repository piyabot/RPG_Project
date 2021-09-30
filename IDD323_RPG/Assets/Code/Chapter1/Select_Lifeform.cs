using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Lifeform : MonoBehaviour
{
    public GameObject play;
    public GameObject lifeform;
    private void Update()
    {
        play.SetActive(true);
        lifeform.SetActive(false);
    }
}
