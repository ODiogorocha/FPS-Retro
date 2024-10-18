using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicas : MonoBehaviour
{
    //Variaveis
    public AudioSource musica_da_fase;
    public AudioSource musica_de_game_over;
    //Funcao
    public void tocar_musica_da_fase(){
        musica_da_fase.Play();
    }

    public void tocar_musica_de_game_over(){
        musica_da_fase.Stop();
        musica_de_game_over.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        tocar_musica_da_fase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
