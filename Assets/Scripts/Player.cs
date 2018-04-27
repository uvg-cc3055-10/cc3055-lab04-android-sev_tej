using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Clase con el comportamiento de la nave espacial
 * 
 */
public class Player : MonoBehaviour {

    private Rigidbody2D rb; //referencia al cuerpo rigido 2d
    public float speed = 5f; //Variable para la velocidad horizontal que tendra la nave

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>(); //inicializacion del cuerpo rigido
	}
	
	// Update is called once per frame
	void Update () {
        if (Control.instance.gameover == false) {
            float movX = Input.acceleration.x; //entrada del acelerometro del celular

            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime); //el cuerpo rigido se traslada
        }
        else {
            Control.instance.ChangeScene("menuScene"); //se regresa al menu
        }
        

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Control.instance.score++;
        // Debug.Log(Control.instance.score);
        Control.instance.gameover = true;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Control.instance.gameover = true;
    }
}
