using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public float distance;
    public void Start()
    {
        
    }

    public void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Enemy get shooted");

            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }

        if (collision.gameObject.CompareTag("limiteEnemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
