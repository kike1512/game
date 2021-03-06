using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public AudioSource sonidoFondo;

    public AudioSource sonidoBotones;

    public Button[] levelButtons;

    void Start(){

        Invoke("AudioFondo",1f);

        int nivelAlcanzado = PlayerPrefs.GetInt("nivelAlcanzado", 2);

        for (int i = 0; i < levelButtons.Length; i++){

            if (i + 2 > nivelAlcanzado){
                levelButtons[i].interactable = false;
            }
            
        }
    }

    //Función que nos permitirá el Nivel o la escena que queramos
    public void SelectLevelOrScene (string levelName){
        sonidoBotones.Play();
        SceneManager.LoadScene(levelName);
    }

    public void reset(){
        PlayerPrefs.DeleteAll();
    }

    public void AudioFondo(){
        sonidoFondo.Play();
    }



}
