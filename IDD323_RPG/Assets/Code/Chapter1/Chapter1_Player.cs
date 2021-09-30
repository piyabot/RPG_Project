using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter1_Player : MonoBehaviour
{
    public float movespeed = 10;
    public float rotationspeed = 10;
    public Rigidbody2D rigid;
    public GameObject Chad;
    public GameObject Normie;
    public GameObject Culture;
    public GameObject play;

    void Start()
    {

    }


    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement.y += movespeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= movespeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= movespeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += movespeed;
        }
        rigid.MovePosition(transform.position + (Vector3)movement * Time.fixedDeltaTime);

        if (movement != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main_menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Chad"))
        {
            Chad.SetActive(true);
            play.SetActive(false);
        }
        if (collision.CompareTag("Normie"))
        {
            Normie.SetActive(true);
            play.SetActive(false);
        }
        if (collision.CompareTag("Culture"))
        {
            Culture.SetActive(true);
            play.SetActive(false);
        }
    }
}
