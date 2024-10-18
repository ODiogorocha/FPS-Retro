using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsEfeitosSonoros : MonoBehaviour
{
    // Variáveis
    public static OsEfeitosSonoros instance;

    public AudioSource som_do_ataque_do_inimigo;
    public AudioSource som_do_ataque_do_jogador;
    public AudioSource som_da_chave;
    public AudioSource som_dano_inimigo;
    public AudioSource som_dano_jogador;
    public AudioSource som_inimigo_derrotado;
    public AudioSource som_municao;
    public AudioSource som_sem_municao;
    public AudioSource som_da_vida;

    // Funções
    public void tocar_ataque_do_inimigo(){
        som_do_ataque_do_inimigo.Play();
    }

    public void tocar_ataque_do_jogador(){ 
        som_do_ataque_do_jogador.Play();
    }

    public void tocar_som_da_chave(){
        som_da_chave.Play();
    }

    public void tocar_som_dano_inimigo(){
        som_dano_inimigo.Play(); 
    }

    public void tocar_som_dano_jogador(){
        som_dano_jogador.Play();
    }

    public void tocar_som_inimigo_derrotado(){
        som_inimigo_derrotado.Play();
    }

    public void tocar_som_municao(){
        som_municao.Play();
    }

    public void tocar_som_sem_municao(){
        som_sem_municao.Play();
    }

    public void tocar_som_da_vida(){
        som_da_vida.Play();
    }

    void Awake(){
        instance = this;
    }
}
