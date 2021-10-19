using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> item_list = new List<GameObject>();
    public GameObject Door;
    public GameObject Hide;

    void Start()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Item"))
        {
            item_list.Add(item);
        }
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            item_list.Add(enemy);
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
            Hide.SetActive(false);
        }
    }
}
