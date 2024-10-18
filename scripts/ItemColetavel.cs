using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    //Variaveis
    public bool item_de_municao;
    public bool item_de_vida;
    public bool chave_prateada;
    public bool chave_dourada;

    public int municao_para_dar;
    public int vida_para_dar;
    //Funcao
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            if(item_de_municao == true){
                other.gameObject.GetComponent<AtaqueDoJogador>().ganhar_municao(municao_para_dar);
                OsEfeitosSonoros.instance.tocar_som_municao();
            }

            if(item_de_vida == true){
                other.gameObject.GetComponent<VidaDoJogador>().ganhar_vida(vida_para_dar);
                OsEfeitosSonoros.instance.tocar_som_da_vida();
            }

            if(chave_prateada == true){
                GameManager.instance.tem_chave_prateada = true;
                OsEfeitosSonoros.instance.tocar_som_da_chave();
            }

            if(chave_dourada == true){
                GameManager.instance.tem_chave_dourada = true;
                OsEfeitosSonoros.instance.tocar_som_da_chave();
            }

            Destroy(this.gameObject);
        }
    }
} 
