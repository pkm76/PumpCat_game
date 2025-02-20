using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class en_pump_script : MonoBehaviour
{
    public Rigidbody2D r_enemy;
    public Rigidbody2D r_gato;
    public GameObject obj_enemy;
    public bool knock_back = false;
    public gato_script gato;
    float posicaoInicial;
    float velocidadex;
    public bool henrique = false;
    public bool henrique2 = false;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 posicao = transform.position;
        //r_gato.AddForceAtPosition(Vector2.left, posicao, ForceMode2D.Force);
        
        posicaoInicial = transform.position.x;
        r_enemy = GetComponent<Rigidbody2D>();
        velocidadex = 6f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicao = transform.position;
        //float velocidadex = Random.Range(-10f, 10f);
        
        r_enemy.velocity = new Vector2(velocidadex, r_enemy.velocity.y);

        float posicaoAtual;
        posicaoAtual = posicao.x;

        if (posicaoAtual > posicaoInicial + 12 && henrique==false)
        {
            velocidadex = -(velocidadex);
            henrique = true;
            henrique2 = true;

        }

        if (posicaoAtual < (posicaoInicial - 12) && henrique2==true)
        {
            velocidadex = -(velocidadex);
            henrique = false;
            henrique2 = false;
        }
        //if(knock_back==true)
        // {
        // r_gato.velocity = new Vector2(-1, 1) * 10;
        // }
        //if(r_gato.velocity.y > 0 && r_gato.velocity.y < 0)
        //  {
        //    if (knock_back == true)
        //  {
        //    cat_grounded = false;
        //}
        //}




    }
        
    // Referência ao Rigidbody2D do inimigo
//public float knockbackForce = 5f; // Força do knockback

    // Método chamado quando uma colisão ocorre
    void OnCollisionEnter2D(Collision2D collision)
    {
        float direction = r_gato.velocity.x;
        if (collision.gameObject.CompareTag("Gato") && direction > 0)
        {
            
            Debug.Log("bateu no gato");
            //knock_back = true;
            //r_gato.velocity = r_gato.velocity / (r_gato.velocity.x ^ 2);
            
                
                r_gato.velocity = new Vector2(-1, 2) * 20;
                

            if (gato != null)
            {
                // Acessa a variável cat_grounded através da referência ao gatoscript 

                gato.cat_grounded = false;
            }

        }
        else
        {
            //knock_back = false;
            

            Debug.Log("nao bateu no gato");
        }

        if (collision.gameObject.CompareTag("Gato") && direction < 0)
        {
            Debug.Log("bateu no gato");
            //knock_back = true;
            //r_gato.velocity = r_gato.velocity / (r_gato.velocity.x ^ 2);

                r_gato.velocity = new Vector2(1, 2) * 20;
            
            if (gato != null)
            {
                // Acessa a variável cat_grounded através da referência ao gatoscript 

                gato.cat_grounded = false;
            }

        }
        else
        {
            //knock_back = false;


            Debug.Log("nao bateu no gato");
        }

        //Vector3 posicao = obj_enemy.transform.position;
        //r_gato.AddForceAtPosition(new Vector2(2, 2), posicao, ForceMode2D.Force);

    }



}
  

