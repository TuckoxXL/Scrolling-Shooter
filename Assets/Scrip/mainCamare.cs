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
            textoTimer.text = "" + timer.ToString("f0");

            if (timer <= 0)
            {
                SceneManager.LoadScene("");
            }
        }

        
    }

    public void sumarTiempo()
    {
        timer += 10;
    }
}
