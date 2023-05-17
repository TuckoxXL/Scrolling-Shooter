using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFinal : MonoBehaviour
{
    public GameObject objetoAspawnear;
    public float minY;
    public float maxY;
    public float Xpos;
    public float mintiempoSpawn = 0f;
    public float maxtiempoSpawn = 0f;   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObstaculo(Random.Range(mintiempoSpawn, maxtiempoSpawn), objetoAspawnear));
    }

   

    private IEnumerator spawnObstaculo(float intervalo, GameObject obstaculo)
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(obstaculo, new Vector3(Random.Range(minY, maxY), Xpos, 0), Quaternion.identity);
        StartCoroutine(spawnObstaculo(intervalo, obstaculo));
    }   
}
