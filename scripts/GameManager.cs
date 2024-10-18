using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variáveis
    public static GameManager instance;
    public GameObject painel_de_pause;

    public bool jogador_esta_vivo;
    public bool tem_chave_prateada;
    public bool tem_chave_dourada;
    public bool jogo_pausado;


    // Funções
    public void game_over(){
        jogador_esta_vivo = false;
        FindObjectOfType<Musicas>().tocar_musica_de_game_over();
        Debug.Log("gameover");
    }

    void Awake(){
        instance = this;
    }

    public void pausar_jogo(){
        Time.timeScale = 0f;
        painel_de_pause.SetActive(true);
        jogo_pausado = true;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void des_pausar_jogo(){
        Time.timeScale = 1f;
        painel_de_pause.SetActive(false);
        jogo_pausado = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        Time.timeScale = 1f;
        jogador_esta_vivo = true;
        jogo_pausado = false;
        tem_chave_dourada = false;
        tem_chave_prateada = false;

        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(jogo_pausado == false){
                pausar_jogo();
            }else{
                des_pausar_jogo();
            }
        }
    }
}
