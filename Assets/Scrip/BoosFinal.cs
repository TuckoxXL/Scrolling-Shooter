using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class BoosFinal : MonoBehaviour
{
    public int vidaBoos;
    public Text vidaTexto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaTexto.text = "vida: " + vidaBoos.ToString("00");

        if (vidaBoos == 0)
        {
            SceneManager.LoadScene("");
        }
    }
}
