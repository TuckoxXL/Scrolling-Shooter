using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    public float Forcemultiplier;
    public int vidaPlayer;
    public Text textoVida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;
        float verticalforce = Input.GetAxis("Vertical") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        verticalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, verticalforce, 0);

        textoVida.text = "vida: " + vidaPlayer.ToString("00");

        if(vidaPlayer <= 0)
        {
            SceneManager.LoadScene("derrota");
        }
    }

    public void restarVida(int vidaRestar)
    {
        vidaPlayer -= vidaRestar;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("limiteEnemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
