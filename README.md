# **GRUPO X:** Título do Jogo
Trabalho de Desenvolvimento de Jogos apresentado ao Centro Universitário [FEI](https://portal.fei.edu.br/), como parte dos requisitos necessários para aprovação na disciplina de Desenvolvimento de Jogos Digitais (CC7140) do curso de Ciência da Computação, orientado pelo Prof. Dr. [Fagner de Assis Moura Pimentel](https://github.com/fagnerpimentel).

## Componentes do Grupo

- Gabriel Albertini Pinheiro | 22.124.094-8
- Alexandre Domiciano Pierri | 22.125.061-6
- Kawan Mark Geronimo | R.A: 22.222.010-5

## Tópicos:

## 1. Introdução

### 1.1 Ideia Principal
O projeto visa criar um jogo de plataforma cooperativo 2D que resgate a **nostalgia** dos clássicos jogos de navegador da era Flash, especificamente inspirando-se na dinâmica de *Fireboy and Watergirl*. A essência do jogo reside na cooperação mútua, onde dois jogadores devem coordenar suas ações em tempo real para superar desafios que vão aumentando ao decorrer das fases.

### 1.2 Experiência do Jogador
O objetivo central é proporcionar uma experiência de **trabalho em equipe intenso**. Queremos que o jogador sinta a satisfação de resolver um quebra-cabeça que seria impossível de solucionar sozinho, reforçando laços sociais através da jogabilidade.

---

## 2. Público-Alvo

### 2.1 Determinação do Público-Alvo
O jogo possui dois públicos alvos:

* **Perfil Nostálgico (Adultos 20-30 anos):** Indivíduos que cresceram na era dos jogos em Flash e portais de jogos de navegador e desejam relembrar alguns momentos de sua infancia.
  
* **Perfil Mais Jovem (Crianças e Jovens 8-16 anos):** Jogadores que buscam entretenimento rápido e acessível para dividir com um amigo em momentos de tédio, valorizando o trabalho em equipe.

### 2.2 Que tipo de jogo mais agrada o seu público-alvo?
* **Para os Adultos:** Jogos com mecânicas intuitivas que não exijam um longo aprendizado, mas que apresentem um visual agradavel e sonoro que siga uma estética retrô de forma moderna.
* **Para os Jovens:** Jogos de plataforma com ritmo dinâmico, visual atraente e "estímulo imediato". Eles preferem jogos que permitam a cooperação local, onde a diversão surge tanto do acerto quanto do erro em momentos de desespero na tomada de uma decisão.

### 2.3 Que desejos do público-alvo o seu jogo satisfaz?
* **Nostalgia e Resgate Emocional:** Satisfaz o desejo de reviver a dinâmica de *Fireboy and Watergirl*, trazendo uma sensação de nostalgia.
* **Alívio do Tédio (Passatempo):** Oferece uma estrutura de níveis que pode ser consumida em sessões curtas ou longas preenchendo o tempo vago.
* **Resolução de Problemas:** Proporciona a satisfação intelectual de superar obstáculos através de uma série de decisões tomadas em dupla.

---

## 3. Estética

### 3.1 Personagens

#### Protagonistas: Alexandre e Gabriel
Dois nobres e heróicos heróis que representam a força e a astúcia necessária para enfrentar o exército de Kawan.
* **Alexandre:** Um herói místico que domina o **Poder dos Raios**.
    * **Habilidades:** Pode eletrificar objetos metálicos e mecanismos no mapa para abrir caminhos.
    * **Limitação:** Devido à sua natureza elétrica, não pode entrar em contato com a água (risco de curto-circuito).
* **Gabriel:** Um imponente lenhador mestre das estruturas SegTree, BinaryTree, Trie e FenwickTree, conhecimentos adquiridos em Shangri-La.
    * **Habilidades:** Ataca à distância lançando seus machados precisos e precisiosos.
    * **Limitação:** Pela sua robustez e peso das árvores que carrega, possui mobilidade reduzida e **não consegue dar pulos duplos**, dependendo de Alexandre para alcançar plataformas altas.

#### Antagonista: Kawan, o Rei Come-Come
O vilão ganancioso que governa através da fome e do roubo.
* **Características:** Possui um temperamento hostil e um enorme poder destrutivo.
* **Ataque Especial:** Lança as rodas de seu lendário **Astra Quebrado** contra os heróis.
* **Motivação:** Acumular todos os cookies do reino apenas para si.

#### Exercito: Os Mini Come-Comes
* **Descrição:** Seres burrinhos e melancólicos que formam a linha de frente do vilão.
* **Comportamento:** Devido à má alimentação (apenas sobras de cookies estragados), possuem movimentos limitados e previsíveis, patrulhando apenas da direita para a esquerda e vice-versa.

#### NPC: Jujuca
* **Papel:** Dono da taverna local e o guia moral da jornada.
* **Função:** É quem fornece a missão principal, implorando aos nobres heróis que recuperem o estoque de cookies roubados para salvar sua taverna.

### 3.2 História

#### Premissa
O Reino dos Feiano vivia em paz até que **Kawan, o Rei Come-Come**, decidiu que todos os cookies deveriam pertencer a ele. Ele saqueou a taverna do **Jujuca**, deixando o vilarejo em desespero. Agora, Alexandre e Gabriel precisam unir seus poderes distintos para invadir o castelo azul de Kawan, recuperar os cookies e colocar o Astra do rei definitivamente no guincho.

* **O que deve ser contado antes:** A cena do roubo dos cookies de Jujuca e a apresentação da amizade entre Alexandre e Gabriel.
* **Como o jogo começa:** Com os heróis na entrada da Taverna do Jujuca, recebendo o pedido de ajuda e aprendendo a combinar o raio com o machado.
* **Como o jogo evolui:** Introduzindo quebra-cabeças onde Alexandre eletrifica plataformas para que Gabriel (que não pula alto) possa subir, enquanto Gabriel elimina os Mini Come-Comes à distância para proteger Alexandre da água.
* **Como o jogo termina:** Um confronto épico contra Kawan e seu Astra. Ao vencer, os cookies são devolvidos e Jujuca faz um banquete real para os heróis.

### 3.3 Sentidos
* **Visual:** Estética colorida 2D com estilo "retrô-moderno". Uso de partículas de eletricidade para Alexandre e animações de rotação para os machados e rodas de Astra.
* **Sonoro:** Uma trilha sonora heróica. Efeitos sonoros de "zap" para os raios e um som de motor engasgando toda vez que Kawan aparece com seu Astra.

---

## 4. Dinâmica

### 4.1 Elementos de Atenção e Envolvimento
A dinâmica de jogo é sustentada pelo laço emocional com o NPC Jujuca e pela rivalidade com Kawan.

* **Atenção (Interesse Imediato):** * **Mecânica de Feedback Visual:** O brilho dos raios de Alexandre e o impacto dos machados de Gabriel geram satisfação visual instantânea (o "suco" do jogo).
    * **Urguência Narrativa:** A visão dos Mini Come-Comes carregando sacos de cookies ao fundo do cenário mantém os jogadores focados no objetivo de perseguição.
* **Envolvimento (Interesse de Longo Prazo):**
    * **Progressão da Taverna:** Conforme a dupla recupera os estoques de cookies, a Taverna do Jujuca vai sendo reconstruída e decorada, servindo como um "hub" que mostra o progresso visual da jornada.
    * **Lealdade ao NPC:** O desejo de ver o "lendário" Jujuca feliz novamente cria um investimento emocional que motiva os jogadores a enfrentar fases mais difíceis.

### 4.2 Tipos de Decisões dos Jogadores
O jogo é definido como uma "série de decisões interessantes" tomadas em dupla:

* **Decisões Integradas:** Cada escolha de Alexandre (como eletrificar uma plataforma) afeta diretamente o que Gabriel pode fazer. Eles não jogam paralelamente, mas de forma coperativa.
* **Decisões de Dois Gumes:** Alexandre deve decidir se atravessa uma área perigosa para ativar um botão que facilita o caminho para Gabriel, mesmo correndo o risco de tocar na água.
* **Decisões Ambíguas:** Em puzzles mais avançados, não haverá uma única ordem correta de quem deve passar primeiro. A dupla precisará debater a estratégia, gerando a dinâmica de comunicação verbal.

### 4.3 Guiando o Jogador (Orientação)
* **Orientação Direta:** Jujuca aparece em placas ou balões de fala indicando "Este caminho leva ao estoque de Cookies!". Sinais de raio no cenário apontam onde a eletricidade de Alexandre pode ser aplicada.
* **Orientação Indireta:** * **Design de Nível (Level Design):** Colocação de Mini Come-Comes em plataformas que só podem ser atingidas pelo machado de Gabriel, forçando organicamente os jogadores a entenderem quem deve agir em cada momento.
    * **Pistas Visuais:** Objetos metálicos que brilham levemente indicam que são condutores para o poder de Alexandre.

## 5. Mecânica

Nesta seção, definimos as regras e os limites que transformam a experiência em um "conflito estruturado".

### 5.1 Padrão de Interação
O jogo utiliza o padrão de **Cooperação Local**. Dois jogadores controlam personagens distintos (Alexandre e Gabriel) simultaneamente no mesmo ambiente, onde o progresso de um depende diretamente da ação do outro.

### 5.2 Objetivos e Condições de Vitória/Derrota

* **Objetivo Principal:** Atravessar o cenário superando os puzzles e os Mini Come-Comes para alcançar a saída.
* **Condição de Vitória:** Ambos os jogadores devem atravessar a **Porta de Saída** ao final de cada nível. A vitória só é contabilizada se os dois heróis estiverem presentes na zona de transição.
* **Condição de Derrota:** O jogo é interrompido e o nível reiniciado se:
    * Um dos jogadores for atingido pelo **Exército de Come-Come** (contato direto).
    * Um dos jogadores cair em um **Penhasco** (limite inferior do mapa).
    * **Alexandre** entrar em contato com a **Água** (devido à sua limitação elétrica).
    * Um dos jogadores for atingido pelos projéteis (rodas de Astra) do Rei Kawan.

### 5.3 Regras do Jogo
1.  **Interdependência de Movimentação:** Gabriel não possui pulo duplo; portanto, Alexandre deve ativar mecanismos (plataformas elevatórias) usando seu raio para permitir que Gabriel avance.
2.  **Combate:** Apenas Gabriel pode eliminar inimigos à distância usando seus machados. Alexandre deve focar em desviar e manipular o ambiente.
3.  **Gestão de Recursos:** Os machados de Gabriel podem ser limitados por nível, exigindo que o jogador os use estrategicamente para limpar o caminho para Alexandre.

### 5.4 Procedimentos e Limites do Mapa
* **Procedimentos:** O jogo segue o *Game Loop* tradicional: Processar Inputs (teclado/controle) -> Atualizar Mundo (movimento, colisões, física) -> Gerar Saídas (gráficos e sons de cookies sendo coletados).
* **Limites do Mapa:** * **Paredes Invisíveis/Cenário:** Delimitam a área de jogo.
    * **Zonas de Perigo:** Água e buracos que causam derrota instantânea, reforçando o "obstáculo desnecessário" que define o jogo.

### 5.5 Resultados do Jogo
* **Pós-Vitória:** É exibida uma tela dos herois voltando para o Reino dos Feiano e sendo recebidos pelos habitantes que fizeram uma festa após recuperarem os cookies.
* **Pós-Derrota:** Uma animação cômica de Kawan comendo os cookies roubados é exibida, seguida pela opção de "Tentar Novamente" para incentivar a atitude lúdica.
