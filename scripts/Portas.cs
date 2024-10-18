using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portas : MonoBehaviour
{
    //Variaveis
    public Animator oAnimator_da_porta; 
    public Collider2D colizor_da_porta;

    public bool porta_normal;
    public bool porta_prateada;
    public bool porta_dourada;
    public bool porta_fechada;
    
    //Funcaos
    public void abrir_porta(){
        oAnimator_da_porta.SetTrigger("Porta abrindo");
        porta_fechada = false;
        colizor_da_porta.enabled = false;
    }
    public void fechar_porta(){
        oAnimator_da_porta.SetTrigger("Porta fechando");
        porta_fechada = true;
        colizor_da_porta.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            if(porta_fechada == true){
                if(porta_normal == true){
                    abrir_porta();
                }
            }

            if(porta_prateada == true){
                if(GameManager.instance.tem_chave_prateada == true){
                    abrir_porta();
                }
            }

            if(porta_dourada == true){
                if(GameManager.instance.tem_chave_dourada == true){
                    abrir_porta();
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            if(porta_fechada == false){
                fechar_porta();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        porta_fechada = true;
    }
}
