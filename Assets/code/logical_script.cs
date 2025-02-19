using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logical_script : MonoBehaviour

    
{

        
        public GameObject obj_camera;
        public GameObject obj_gato;
        public Vector3 bananas;
        public bool cameraW = false;
        public bool cameraS = false;
        public bool morte = false;
        public float hp = 3f;
        public float altura_camera= 2;
        


    // Start is called before the first frame update
    void Start()
    {
        obj_gato.GetComponent<Collider2D>().isTrigger = false;
        morte = false;
        hp = 3f;

    }


    // Update is called once per frame
    void Update()
        {
           gato_script gatoScriptInstance = obj_gato.GetComponent<gato_script>();
            
        if (morte==false)
            {

                
                Vector3 playerposition = obj_gato.transform.position;

                float playerX = playerposition.x;
                float playerY = playerposition.y;

                Vector3 cameraposition = obj_camera.transform.position;
                playerY = playerY + altura_camera;

                float cameraY = cameraposition.y;

                cameraposition.x = playerX;
                cameraposition.y = playerY;
        
                obj_camera.transform.position = cameraposition; //nao funciona sem essa linha, pois eumudava o vector3 cameraposition mas n igualava isso com a posicao do gameobject.
                if (Input.GetKey(KeyCode.W) == true && gatoScriptInstance.cat_speeding == false && cameraS == false&& gatoScriptInstance.cat_grounded == true)//&& GameObject.Find("obj_gato").GetComponent<gato_script>().cat_grounded==true)//&& cat_grounded == true)//&&cat_Grounded==true
                {
                    playerY = playerY + 4; //eu queria q fosse +4.5
                    cameraposition.y = playerY;
                    cameraW = true;
                    obj_camera.transform.position = cameraposition;
                }
                else
                {
                    cameraW = false;
                }

                if (Input.GetKey(KeyCode.S) == true &&  gatoScriptInstance.cat_speeding == false && cameraW == false && gatoScriptInstance.cat_grounded == true)//&& cat_grounded == true)
                {
                    playerY = playerY - 5.28F;//era 6
                    cameraposition.y = playerY;
                    obj_camera.transform.position = cameraposition;
                    cameraS = true;
                }
                else
                {
                    cameraS = false;

                }
            }
            if(gatoScriptInstance.can_move == false)
            {
                hp = hp - 1;
            }
            if(hp==0f)
            {
                Debug.Log(hp);
                morte = true;
                gatoScriptInstance.can_move = false;
                obj_gato.GetComponent<Collider2D>().isTrigger = true;
            }
            if(altura_camera == 6)
            {
                altura_camera = 2 ;
                cameraposition.y = 6
            }
    }

        void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.CompareTag("chao") && gameObject.CompareTag("Gato"))
            {
                altura_camera = 6;
                Debug.Log("Gato colidiu com o chao");
            }
            if (collision.gameObject.CompareTag("plataforma") && gameObject.CompareTag("Gato"))
            {
                altura_camera = 2;
                Debug.Log("Gato colidiu com plataforma");
            }
    }


}







