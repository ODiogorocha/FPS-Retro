using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComOTempo : MonoBehaviour
{
    //Variaveis
    public float tempo_de_vida;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempo_de_vida);
    }

}
