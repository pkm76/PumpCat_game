using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao_Script : MonoBehaviour
{
    public GameObject chao;
    private float Temporizador = 0;
    public float spawnrate = 2;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(chao, transform.position - Vector3.up * 2.8f, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Temporizador < spawnrate)
        {
            Temporizador = Temporizador + Time.deltaTime;
        }
        else
        {
            Instantiate(chao, transform.position -Vector3.up*2.8f + Vector3.right * Random.Range(-15, 15), transform.rotation);
            Temporizador = 0;
            float number = Random.Range(0.5f, 2.0f);

            spawnrate = number;

        }


    }
}
