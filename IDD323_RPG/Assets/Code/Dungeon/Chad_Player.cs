using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chad_Player : MonoBehaviour
{
    public float movespeed = 10f;
    
    public Rigidbody2D rigid;
    public Camera cam;
    public GameObject Win;
    public GameObject Hide;
    public GameObject Cheat;

    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }


    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + movement * movespeed * Time.deltaTime);

        Vector2 lookDir = mousePos - rigid.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rigid.rotation = angle;

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKey(KeyCode.O))
        {
            Destroy(Cheat);
        }
    }
}
