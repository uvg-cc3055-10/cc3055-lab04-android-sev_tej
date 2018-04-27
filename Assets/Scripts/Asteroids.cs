using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Clase con el comportamiento de los asteroides
 * 
 */
public class Asteroids : MonoBehaviour {

    public float scrollingSpeed = 2f; //velocidad a la que se desplaza el objeto

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Control.instance.gameover == false)
        {
            transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime); //se mueve para abajo
            if (transform.position.y < -5.5) //al salir de la pantalla se destruye el objeto
            {
                Destroy(gameObject);
            }
        }
    }
}
