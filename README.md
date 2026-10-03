# 🐦 Flappy Bardo

Um jogo 2D inspirado em Flappy Bird, desenvolvido em Unity como projeto de estudo para praticar conceitos fundamentais de desenvolvimento de jogos.

O projeto foi iniciado a partir de um tutorial introdutório de Unity e continuará sendo expandido com novas funcionalidades, melhorias visuais e sistemas próprios.

---

## 🎮 Sobre o projeto

O objetivo é controlar o personagem e atravessar os espaços entre os obstáculos sem colidir com os canos.

Cada obstáculo ultrapassado aumenta a pontuação do jogador.

O projeto foi utilizado para estudar conceitos como:

- Física 2D
- Rigidbody2D
- Collider2D
- Triggers
- Movimentação de objetos
- Instanciação de prefabs
- Sistema de pontuação
- Interface com TextMeshPro
- Detecção de colisões
- Game Over
- Reinício de cena
- Organização de scripts em C#

---

## 🕹️ Controles

Ação: Voar / pular
Tecla: Espaço

Ação: Reiniciar
Controle: Botão de reinício na tela de Game Over

---

## ⚙️ Tecnologias

- Unity 6
- C#
- TextMeshPro
- Unity 2D Physics

---

## 🧩 Sistemas implementados

### Movimento do jogador

O pássaro utiliza um Rigidbody2D e recebe velocidade vertical ao pressionar a barra de espaço.

### Obstáculos

Os canos são gerados durante a partida e se movimentam horizontalmente pela tela.

### Colisões

Os canos utilizam BoxCollider2D, enquanto o jogador utiliza um CircleCollider2D.

Ao colidir com um obstáculo, o jogador perde a partida.

### Pontuação

Existe uma região invisível entre os canos responsável por detectar quando o jogador atravessa o obstáculo.

Ao atravessar:

Score +1

A pontuação é exibida na interface utilizando TextMeshPro.

### Game Over

Ao colidir com um obstáculo:

- A tela de Game Over é exibida
- O jogador deixa de poder continuar normalmente
- É possível reiniciar a cena e começar novamente

---

## 📂 Estrutura principal

Assets/

├── BirdScript.cs
├── LogicScript.cs
├── PipeMoveScript.cs
├── PipeSpawnScript.cs
├── PipeMiddleScript.cs
├── Scenes/
├── Prefabs/
│   └── Pipe
└── Sprites/

---

## Scripts

BirdScript

Responsável pelo comportamento do jogador, incluindo movimento e detecção de colisões.

LogicScript

Controla sistemas gerais da partida, como:

- Pontuação
- Game Over
- Reinício da cena

PipeMoveScript

Responsável pela movimentação dos obstáculos.

PipeSpawnScript

Cria novos conjuntos de canos durante a partida.

PipeMiddleScript

Detecta quando o jogador atravessa corretamente um conjunto de canos e adiciona pontos.

---

## 🚧 Estado do projeto

O tutorial-base utilizado para iniciar o projeto foi concluído.

A partir deste ponto, o desenvolvimento continuará com funcionalidades próprias e melhorias adicionais.

### Próximas melhorias

- [ ] Tela inicial
- [ ] Sistema de recorde / High Score
- [ ] Melhorar tela de Game Over
- [ ] Sons e efeitos sonoros
- [ ] Música
- [ ] Animações do personagem
- [ ] Melhorar cenário
- [ ] Diferentes dificuldades
- [ ] Aumento progressivo da velocidade
- [ ] Melhorar geração dos obstáculos
- [ ] Sistema de pause
- [ ] Build executável
- [ ] Melhorias gerais de UI/UX

---

## 📚 Referência

O projeto foi iniciado acompanhando o tutorial:

The Unity Tutorial For Complete Beginners

YouTube:
https://www.youtube.com/watch?v=XtQMytORBmM

O tutorial foi utilizado como base de aprendizado. O projeto continuará sendo desenvolvido e modificado com novas funcionalidades.

---

## 🎯 Objetivo

Este projeto faz parte dos meus estudos em desenvolvimento de jogos com Unity e C#, servindo como prática para entender a estrutura e os principais sistemas utilizados em jogos 2D.

---

## 👨‍💻 Desenvolvedor

Desenvolvido por Vinícius Francisco Garcia Sobral.

GitHub:
https://github.com/vinikyo

---

## 📌 Observação

Este projeto está em desenvolvimento.

Novas funcionalidades e melhorias serão adicionadas progressivamente.
