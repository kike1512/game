using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTreadmill : MonoBehaviour
{
    public GameObject jugador;

    private void OnCollisionEnter2D(Collision2D colision) {
        if(colision.transform.CompareTag("jugador")){
            jugador.GetComponent<ConstantForce2D>().enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D colision) {
        if(colision.transform.CompareTag("jugador")){
            jugador.GetComponent<ConstantForce2D>().enabled = false;
        }
    }
}
