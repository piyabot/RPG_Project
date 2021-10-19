using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Transform player;
    private float speed = 35.9f;
    public GameObject Fight;
    public GameObject Hide;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Two").transform;
    }
    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        direction = direction.normalized;
        rigid.MovePosition((Vector2)transform.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Two"))
        {
            Destroy(gameObject);
            Fight.SetActive(true);
            Hide.SetActive(false);
        }
    }
}
