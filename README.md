# README - Jogo FPS Retro Velho Oeste (2.5D)

## Visão Geral

Este projeto é um jogo de tiro em primeira pessoa (FPS) inspirado em clássicos do gênero como *Doom*, mas com uma temática de velho oeste. O jogo foi desenvolvido em **Unity** usando o estilo gráfico *2.5D*, combinando elementos 2D e 3D para criar um visual retro imersivo.

O jogador explora cenários do velho oeste, enfrenta inimigos e coleta munição e vida para sobreviver. O jogo conta com mecânicas de tiro, movimento fluido e inimigos controlados por IA simples, tornando-se uma experiência dinâmica e nostálgica.

## Funcionalidades

- **Movimentação e Combate:** O jogador pode se mover livremente pelo cenário, mirar e atirar nos inimigos.
- **Mecânica de Tiro:** Sistema de tiro com animações, contagem de munição e efeitos visuais de impacto.
- **IA Inimiga:** Inimigos patrulham áreas e atacam o jogador ao se aproximar.
- **Coleta de Itens:** O jogador pode coletar munição, vida e chaves para progredir no jogo.
- **Música e Efeitos Sonoros:** Sons de tiro, impacto, coleta de itens e trilha sonora de fundo.
- **Sistema de Pause:** Menu de pausa com opção de continuar ou sair do jogo.

## Estrutura do Código

### **Scripts Principais**

1. **AtaqueDoJogador.cs**
   - Responsável por lidar com o sistema de tiro do jogador, incluindo a detecção de colisões com inimigos e a atualização da munição.
   
2. **ControleDoJogador.cs**
   - Gerencia a movimentação do jogador, incluindo a rotação da câmera e a interação com o cenário.

3. **Inimigo.cs**
   - Script de controle dos inimigos. Define o comportamento de patrulha, ataque ao jogador e a vida do inimigo.

4. **DestruirComOTempo.cs**
   - Responsável por destruir automaticamente objetos como efeitos de impacto após certo tempo.

5. **ItemColetavel.cs**
   - Define o comportamento de itens como munição, vida e chaves, e sua interação com o jogador.

6. **MenuDePause.cs**
   - Gerencia as funções do menu de pausa.

7. **Musicas.cs**
   - Controla a reprodução de músicas de fundo, como trilha da fase e som de game over.

8. **OsEfeitosSonoros.cs**
   - Script que centraliza a reprodução dos efeitos sonoros do jogo.

## Como Usar a Unity para Rodar o Projeto

### Requisitos

- **Unity**: A versão recomendada é a **Unity 2021.3 LTS** ou superior.
- **Sistemas Operacionais**: Windows, macOS ou Linux.
- **SDKs e Pacotes Adicionais**: Verifique se você tem instalados os pacotes padrão da Unity para desenvolvimento em 2D/3D.

### Passos para Iniciar o Projeto

1. **Instalar a Unity**:
   - Baixe e instale o **Unity Hub** a partir do site oficial: [Unity Hub](https://unity.com/pt/download).
   - Após instalar, abra o Unity Hub e faça login ou crie uma conta.

2. **Configurar o Projeto**:
   - No Unity Hub, clique em "Novo Projeto".
   - Selecione a template **2D**, já que o jogo utiliza uma abordagem *2.5D* com elementos 2D e 3D.
   - Nomeie o projeto e escolha o local onde será salvo.

3. **Importar os Scripts e Recursos**:
   - Dentro do projeto, crie uma pasta chamada `Scripts` e adicione os arquivos `.cs` (como `AtaqueDoJogador.cs`, `ControleDoJogador.cs`, etc.) na pasta.
   - Adicione também os **sprites** (imagens 2D), **modelos 3D** e **áudios** que fazem parte do jogo.

4. **Configurar a Cena**:
   - No painel *Hierarchy*, adicione o **Jogador** (Player), **Inimigos** e **Itens**.
   - Associe os scripts ao GameObject correto. Por exemplo, arraste o script `AtaqueDoJogador.cs` para o objeto que representa o jogador.

5. **Configurar o Input**:
   - Certifique-se de que as teclas de movimento (WASD ou setas) e o botão de tiro (botão esquerdo do mouse) estão configurados na aba `Project Settings` -> `Input Manager`.

6. **Executar o Jogo**:
   - Clique em **Play** no editor da Unity para rodar o jogo no modo de teste. Certifique-se de que a câmera e os controles estão funcionando corretamente.
   - Ajuste o **Campo de Visão (FOV)** da câmera e a **sensibilidade do mouse** para uma melhor experiência de jogo.

7. **Build e Distribuição**:
   - Quando o jogo estiver finalizado, vá em `File` -> `Build Settings`, selecione a plataforma de destino (Windows, macOS, Linux) e clique em **Build** para gerar o arquivo executável.

## Controles do Jogo

- **Movimento**: Use as teclas **WASD** ou as setas do teclado para mover o jogador.
- **Atirar**: Pressione o botão esquerdo do mouse para atirar.
- **Pause**: Pressione `Esc` para pausar o jogo.
- **Interação com Itens**: Ao se aproximar de itens colecionáveis, eles serão automaticamente adicionados ao seu inventário.

## Contribuição

Se você deseja contribuir para o projeto, sinta-se à vontade para fazer um *fork* do repositório e submeter *pull requests*. Melhorias na jogabilidade, novos inimigos, fases e melhorias no desempenho são sempre bem-vindas.

## Créditos

Desenvolvido por [Seu Nome]. 

Recursos visuais e sonoros utilizados no projeto seguem os direitos autorais respectivos de seus criadores ou foram adquiridos em repositórios de mídia livre.

---

**Divirta-se explorando o Velho Oeste em estilo retrô!**
