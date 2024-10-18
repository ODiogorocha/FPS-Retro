using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    //variaveis
    public static ControleDoJogador instance; //variavel com a parte static so pode existir uma em todo o jogo

    public Rigidbody2D oRigidbody2D;
    public Animator animacao_do_painel_da_arma;

    public float velocidade_do_jogador;
    public float sensibilidade_do_mouse;

    private Vector2 comandos_do_teclado;  
    private Vector2 movimento_do_mouse; 

    //funcoes
    private void movimentar_jogador(){
        comandos_do_teclado = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));  

        Vector3 movimento_horizontal = transform.up * -comandos_do_teclado.x;  
        Vector3 movimento_vertical = transform.right * comandos_do_teclado.y;  

        oRigidbody2D.velocity = (movimento_horizontal + movimento_vertical) * velocidade_do_jogador;

        if(oRigidbody2D.velocity.magnitude == 0){
            animacao_do_painel_da_arma.Play("Jogador parado");
        }else{
            animacao_do_painel_da_arma.Play("Jogador andando");
        }
    }

    private void girar_camera(){
        //diferanca do GetAxis para o GetAxisRaw e que o Raw faz o movimento ser menos preciso
        // o sem o raw e mais preciso

        movimento_do_mouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * sensibilidade_do_mouse);

        //a movimentacao da camera tem 4 eixos o x, y, z e o w, olhe a opcao debug no transform, o comando euler converte em tres eixos
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - movimento_do_mouse.x);
    }


    // funciona antes do jogo iniciar
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	movimentar_jogador();
        girar_camera();
    }
}
