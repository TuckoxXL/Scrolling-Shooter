using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainCamare : MonoBehaviour
{
    public float timer = 20;
    public float speed;
    public Text textoTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed, Space.World);
        if (transform.position.y >= 177f)
        {
            speed = 0;
            timer -= Time.deltaTime;
            textoTimer.gameObject.SetActive(true);
            textoTimer.text = "cargando la supercorrida " + timer.ToString(" s0");

            if (timer <= 0)
            {
                SceneManager.LoadScene("victoria");
            }
        }

        
    }

    public void sumarTiempo()
    {
        timer += 10;
    }
}
