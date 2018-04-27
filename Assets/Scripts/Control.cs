using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/**
 * Clase que controla funcionalidades como el Game Over, el punteo, entre otros.
 * 
 */
public class Control : MonoBehaviour {

    public bool gameover = false; //variable para terminar el juego
    public float score = 0; //el punteo
    private float timeScore = 0;

    public Text texto;

    public static Control instance; //variable referente al objeto en cuestion

    // Use this for initialization
    void Start () {
        instance = this;
       
    }
	
	// Update is called once per frame
	void Update () {
        timeScore = timeScore + Time.deltaTime; //se suma el tiempo transcurrido a time
        texto.text = "Score: " + timeScore.ToString("n0"); // n0 sirve para no mostrar decimales
        HighScore();
	}

    /**
     * Funciones para el manjeo de escenas
     */ 
    public void ChangeScene(string scenename) 
    {
        SceneManager.LoadScene(scenename);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void HighScore() {
        if (gameover == true) {
            if (PlayerPrefs.GetFloat("HighScore") < timeScore){ //se toma el valor de highscore y se compara con timeScore
                PlayerPrefs.SetFloat("HighScore",timeScore); //se actualiza el valor de HighScore
            }
            
        }
    }
}
