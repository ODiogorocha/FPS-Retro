using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    // Variaveis
    public Text texto_de_vida_do_jogador;
    
    public int vida_maxima_do_jogador;
    public int vida_atual_do_jogador;

    // Funcoes
    public void machucar_jogador(int dano_para_receber)
    {
        if (GameManager.instance.jogador_esta_vivo)
        {
            vida_atual_do_jogador -= dano_para_receber;
            OsEfeitosSonoros.instance.tocar_som_dano_jogador();
            texto_de_vida_do_jogador.text = "VIDA \n" + vida_atual_do_jogador;

            if (vida_atual_do_jogador <= 0)
            {
                GameManager.instance.game_over();
            }
        }
    }

    public void ganhar_vida(int vida_para_receber){
        if(vida_atual_do_jogador + vida_para_receber < vida_maxima_do_jogador){
            vida_atual_do_jogador += vida_para_receber;
        }else{
            vida_atual_do_jogador = vida_maxima_do_jogador;
        }

        texto_de_vida_do_jogador.text = "VIDA\n" + vida_atual_do_jogador;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
        texto_de_vida_do_jogador.text = "VIDA\n" + vida_atual_do_jogador;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
