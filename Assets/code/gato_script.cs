using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gato_script : MonoBehaviour
{
    public Rigidbody2D r_gato;
    public Rigidbody2D r_chao;
    public GameObject obj_gato;
    public Rigidbody2D r_abobo;
    public int vel_frontal;
    public int vel_vertical;
    public Vector2 vel_x;
    public Vector2 vel_up;
    public bool cat_grounded;
    public bool can_move;
    public bool cat_speeding;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, -2, 0);
        cat_grounded = false;
        can_move = true;
        cat_speeding = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel_x = r_gato.velocity;

        if (Input.GetKey(KeyCode.D) == true && can_move==true)
            vel_x.x = vel_frontal;

        r_gato.velocity = vel_x;
        vel_x = r_gato.velocity;

        if (Input.GetKey(KeyCode.A) == true && can_move==true)
            vel_x.x = -vel_frontal;
        if (Mathf.Abs(vel_x.x) > 0)
        {
            cat_speeding = true;
            //Debug.Log("cat_speeding=true");
        }
        else
        {
            cat_speeding = false;
            //Debug.Log("cat_speeding=false");
        }

        r_gato.velocity = vel_x;
        //if (//colisoa do gato_script com o chao)
        // cat_grounded == true;
        // else
        //   cat_grounded == false;

        if (Input.GetKeyDown(KeyCode.Space) == true && cat_grounded==true)//&& cat_grounded == true
            r_gato.velocity = Vector2.up * vel_vertical;

            //cat_grounded = false;
        //cat_grounded = false;

        if (r_gato.velocity.y > 0 || r_gato.velocity.y < 0 )

            cat_grounded = false;
        if (r_gato.velocity.y == 0)
            cat_grounded = true;
        //if (can_move == false)
          //  r_gato.velocity = new Vector2(1, -1) *5
                ;
       // if (r_gato.IsTouching(r_gato Collider2D r_chao) == false) 
       //   cat_grounded=false;









    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        cat_grounded = true;
        if (collision.gameObject.CompareTag("enemy"))
        {
            can_move = false;
            //Debug.Log("can_move=false");
        }
        else

        {
            can_move = true;
            //Debug.Log("can_move=true");
        }
      

    }
}
