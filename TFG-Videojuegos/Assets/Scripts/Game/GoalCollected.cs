using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCollected : MonoBehaviour
{

    private int siguienteEscena;

    public GameObject UIFinNivel;

    private void Start() {
        siguienteEscena = SceneManager.GetActiveScene().buildIndex + 1;
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("jugador")){
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 2f);
            UIFinNivel.SetActive(true);
            Invoke("SiguienteEscena", 0.8f);

        }    
    }

    public void SiguienteEscena(){
        SceneManager.LoadScene(siguienteEscena);

        if(siguienteEscena > PlayerPrefs.GetInt("nivelAlcanzado")){
                PlayerPrefs.SetInt("nivelAlcanzado",siguienteEscena);
        }
    }

}
