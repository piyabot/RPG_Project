using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Transform player;
    private float speed = 35.9f;
    public GameObject Lose;
    public GameObject Hide;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("One").transform;
    }
    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        direction = direction.normalized;
        rigid.MovePosition((Vector2)transform.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("One"))
        {
            Destroy(gameObject);
            Lose.SetActive(true);
            Hide.SetActive(false);
        }
    }
}
