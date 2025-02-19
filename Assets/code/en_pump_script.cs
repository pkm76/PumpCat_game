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

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 posicao = transform.position;
        //r_gato.AddForceAtPosition(Vector2.left, posicao, ForceMode2D.Force);
        
    }

    // Update is called once per frame
    void Update()
    {
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
    // Refer�ncia ao Rigidbody2D do inimigo
//public float knockbackForce = 5f; // For�a do knockback

    // M�todo chamado quando uma colis�o ocorre
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
                // Acessa a vari�vel cat_grounded atrav�s da refer�ncia ao gatoscript 

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
                // Acessa a vari�vel cat_grounded atrav�s da refer�ncia ao gatoscript 

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
  

