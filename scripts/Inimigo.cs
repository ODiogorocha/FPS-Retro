using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    //Variaveis
    public Transform[] pontos_para_caminhar;
    public Transform local_do_disparo;
    public GameObject Projetil_do_inimigo;
    public Animator oAnimator;

    public float velocidade_do_inimigo;
    public int ponto_atual;
    public float distancia_para_atacar;
    public float tempo_para_o_ataque;
    public float tempo_entre_os_pontos;
    public float tempo_atual;
    public int vida_maxima_do_inimigo;
    public int vida_atual_do_inimigo; 

    public bool inimigo_esta_vivo;
    public bool inimigo_pode_andar;
    public bool inimigo_ja_atacou;
    //Funcoes
    private void movimentar_inimigo(){
        if(inimigo_esta_vivo == true){
            if(inimigo_pode_andar == true){
                transform.position = Vector2.MoveTowards(transform.position, pontos_para_caminhar[ponto_atual].position, velocidade_do_inimigo * Time.deltaTime);

                if(transform.position.y != pontos_para_caminhar[ponto_atual].position.y){
                    oAnimator.SetTrigger("Andando");
                }

                if(transform.position.y == pontos_para_caminhar[ponto_atual].position.y){
                    oAnimator.SetTrigger("Parado");
                    esperar_antes_de_caminhar();
                }

                if(ponto_atual == pontos_para_caminhar.Length){
                    ponto_atual = 0;
                }
            }
        }
    }

    private void esperar_antes_de_caminhar(){
        //inimigo_pode_andar = false; essa linha quebra o jogo e eu nao sei o porque ??????????
        tempo_atual -= Time.deltaTime;

        if(tempo_atual <= 0){
            inimigo_pode_andar = true;
            ponto_atual++;
            tempo_atual = tempo_entre_os_pontos;
        }
    } 

    private void verificar_distancia(){
        if(Vector3.Distance(transform.position, ControleDoJogador.instance.transform.position) < distancia_para_atacar){
            atacar_jogador();
        }else{
            inimigo_pode_andar = true;
        }
    }

    private void atacar_jogador(){
        if(inimigo_ja_atacou == false){
            inimigo_pode_andar = false;
            oAnimator.SetTrigger("Atacando");
            OsEfeitosSonoros.instance.tocar_ataque_do_inimigo();
            Instantiate(Projetil_do_inimigo, local_do_disparo.position, local_do_disparo.rotation);
            inimigo_ja_atacou = true;
            Invoke(nameof(resetar_ataque_do_inimigo), tempo_para_o_ataque);
        }
    }

    private void resetar_ataque_do_inimigo(){
        inimigo_ja_atacou = false;
    }

    public void machucar_inimigo(int dano_para_receber){
        if(inimigo_esta_vivo == true){
            vida_atual_do_inimigo -= dano_para_receber;
            OsEfeitosSonoros.instance.tocar_som_dano_inimigo();
            oAnimator.SetTrigger("Dano");

            if(vida_atual_do_inimigo <= 0){
                inimigo_esta_vivo = false;
                inimigo_pode_andar = false;

                OsEfeitosSonoros.instance.tocar_som_inimigo_derrotado();
                oAnimator.SetTrigger("Derrotado");
            }
        }
    }

    public void derrotar_inimigo(){
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        inimigo_esta_vivo = true;
        inimigo_pode_andar = true;
        inimigo_ja_atacou = false;

        transform.position = pontos_para_caminhar[0].position;
        vida_atual_do_inimigo = vida_maxima_do_inimigo;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.jogador_esta_vivo == true){
            movimentar_inimigo();
            verificar_distancia();
        }
    }
}
