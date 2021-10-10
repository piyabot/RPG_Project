using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInDungeon : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Transform player;
    public float speed = 1.5f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        direction = direction.normalized;
        rigid.MovePosition((Vector2)transform.position + direction * speed * Time.fixedDeltaTime);
    }
}
