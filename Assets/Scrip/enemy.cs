using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    
    public float distance;
    public int damage;
    
    public void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
        
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

        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<player>().restarVida(damage);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("limiteEnemy"))
        {
            Destroy(this.gameObject);
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<player>().vidaPlayer -= damage;
        }
    }
}
