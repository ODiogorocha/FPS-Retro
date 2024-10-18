using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDePause : MonoBehaviour
{
   public void resumir_jogo(){
    GameManager.instance.des_pausar_jogo();
   }

   public void sair_do_jogo(){
    Application.Quit();
    Debug.Log("saiu do jogo");
   }
}
