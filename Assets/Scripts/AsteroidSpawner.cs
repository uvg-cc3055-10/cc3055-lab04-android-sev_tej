using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Clase que instancia nuevos asteroides en tiempo de juego
 * 
 */
public class AsteroidSpawner : MonoBehaviour {

    public GameObject asteroid; 
    public float spawnTime = 4f; //el tiempo en el que volvera a instanciarse un objeto
    private float elapsedTime = 0f; 
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Control.instance.gameover == false) 
        {
            if (elapsedTime < spawnTime) 
            {
                elapsedTime += Time.deltaTime; //se acumula el tiempo transcurrido
            }
            else
            {
                float random = Random.Range(-2f, 2f); 
                Instantiate(asteroid, new Vector3(random, 5.5f, 0), Quaternion.identity); //se instancia el objeto
                elapsedTime = 0;
            }
        }
    }
}
