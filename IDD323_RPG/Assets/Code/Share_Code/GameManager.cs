using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> item_list = new List<GameObject>();
    public GameObject Door;

    void Start()
    {
        foreach (GameObject enemies in GameObject.FindGameObjectsWithTag("HL"))
        {
            item_list.Add(enemies);
        }
    }

    private void Update()
    {
        for (int i = 0; i < item_list.Count; i++)
        {
            if (item_list[i] == null)
            {
                item_list.RemoveAt(i);
            }
        }
        if (item_list.Count <= 0)
        {
            Door.SetActive(true);
        }
    }
}
