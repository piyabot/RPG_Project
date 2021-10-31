using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Transform player;
    public float speed = 10f;
    public GameObject Lose;
    public GameObject Hide;
    private Vector2 movement;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rigid.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        direction = direction.normalized;
        rigid.MovePosition((Vector2)transform.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Lose.SetActive(true);
            Hide.SetActive(false);
        }
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("One"))
        {
            Destroy(gameObject);
        }
    }
}
