<article class="markdown-body entry-content container-lg" itemprop="text"><h3 tabindex="-1" dir="auto"><a id="user-content-jogar-dados" class="anchor" aria-hidden="true" href="#jogar-dados"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path d="m7.775 3.275 1.25-1.25a3.5 3.5 0 1 1 4.95 4.95l-2.5 2.5a3.5 3.5 0 0 1-4.95 0 .751.751 0 0 1 .018-1.042.751.751 0 0 1 1.042-.018 1.998 1.998 0 0 0 2.83 0l2.5-2.5a2.002 2.002 0 0 0-2.83-2.83l-1.25 1.25a.751.751 0 0 1-1.042-.018.751.751 0 0 1-.018-1.042Zm-4.69 9.64a1.998 1.998 0 0 0 2.83 0l1.25-1.25a.751.751 0 0 1 1.042.018.751.751 0 0 1 .018 1.042l-1.25 1.25a3.5 3.5 0 1 1-4.95-4.95l2.5-2.5a3.5 3.5 0 0 1 4.95 0 .751.751 0 0 1-.018 1.042.751.751 0 0 1-1.042.018 1.998 1.998 0 0 0-2.83 0l-2.5 2.5a1.998 1.998 0 0 0 0 2.83Z"></path></svg></a>Jogar dados</h3>
<p dir="auto"><strong>Objetivo:</strong> usando uma aplicação do tipo console do dotnet, criar um jogo simplificado onde dois jogadores podem jogar dados e a aplicação informa qual dos jogadores tirou o maior número. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.</p>
<h2 tabindex="-1" dir="auto"><a id="user-content-novos-conceitos-ou-funcionalidades-desse-exercício" class="anchor" aria-hidden="true" href="#novos-conceitos-ou-funcionalidades-desse-exercício"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path d="m7.775 3.275 1.25-1.25a3.5 3.5 0 1 1 4.95 4.95l-2.5 2.5a3.5 3.5 0 0 1-4.95 0 .751.751 0 0 1 .018-1.042.751.751 0 0 1 1.042-.018 1.998 1.998 0 0 0 2.83 0l2.5-2.5a2.002 2.002 0 0 0-2.83-2.83l-1.25 1.25a.751.751 0 0 1-1.042-.018.751.751 0 0 1-.018-1.042Zm-4.69 9.64a1.998 1.998 0 0 0 2.83 0l1.25-1.25a.751.751 0 0 1 1.042.018.751.751 0 0 1 .018 1.042l-1.25 1.25a3.5 3.5 0 1 1-4.95-4.95l2.5-2.5a3.5 3.5 0 0 1 4.95 0 .751.751 0 0 1-.018 1.042.751.751 0 0 1-1.042.018 1.998 1.998 0 0 0-2.83 0l-2.5 2.5a1.998 1.998 0 0 0 0 2.83Z"></path></svg></a>Novos conceitos ou funcionalidades desse exercício</h2>
<p dir="auto">Usaremos nesse exercício a classe Random do dotnet para simular uma jogada de dados com 6 lados. O random irá possibilitar que tiremos um número aleatório (de 1 a 6 para nosso exemplo).
Você pode usar loop para esse exercício, estude sobre loops caso não conheça. Poderá também optar por usar <strong>recursão</strong> (o exemplo de consulta usa recursão no método "IniciarRodadas"), recomendo estudar sobre recursão também antes de iniciar o exercício.</p>
<h2 tabindex="-1" dir="auto"><a id="user-content-requisitos-para-desenvolver-a-aplicação" class="anchor" aria-hidden="true" href="#requisitos-para-desenvolver-a-aplicação"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path d="m7.775 3.275 1.25-1.25a3.5 3.5 0 1 1 4.95 4.95l-2.5 2.5a3.5 3.5 0 0 1-4.95 0 .751.751 0 0 1 .018-1.042.751.751 0 0 1 1.042-.018 1.998 1.998 0 0 0 2.83 0l2.5-2.5a2.002 2.002 0 0 0-2.83-2.83l-1.25 1.25a.751.751 0 0 1-1.042-.018.751.751 0 0 1-.018-1.042Zm-4.69 9.64a1.998 1.998 0 0 0 2.83 0l1.25-1.25a.751.751 0 0 1 1.042.018.751.751 0 0 1 .018 1.042l-1.25 1.25a3.5 3.5 0 1 1-4.95-4.95l2.5-2.5a3.5 3.5 0 0 1 4.95 0 .751.751 0 0 1-.018 1.042.751.751 0 0 1-1.042.018 1.998 1.998 0 0 0-2.83 0l-2.5 2.5a1.998 1.998 0 0 0 0 2.83Z"></path></svg></a>Requisitos para desenvolver a aplicação</h2>
<ul dir="auto">
<li>
<p dir="auto">Quando o usuário abrir o jogo deverá ser solicitado o nome do primeiro e do segundo jogador. Não será possível jogar com mais do que dois jogadores.</p>
</li>
<li>
<p dir="auto">O jogo deverá solicitar um nome para cada jogador e os nome não podem ser iguais.</p>
</li>
<li>
<p dir="auto">O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na maioria das jogadas vence a partida.</p>
</li>
<li>
<p dir="auto">Em caso de empate (onde os dois tiram o mesmo número) nenhum jogador pontuará.</p>
</li>
<li>
<p dir="auto">A cada rodada a aplicação deve informar quem foi o jogador vencedor. Exemplos de mensagens:</p>
<ul dir="auto">
<li><strong>João tirou o número 2 e Maria o número 6. Maria venceu a rodada 1.</strong></li>
<li><strong>João tirou o número 1 e Maria o número 1. Empate.</strong></li>
</ul>
</li>
<li>
<p dir="auto">Um placar sempre deve ser exibido até o final do jogo para que os jogadores acompanhem o resultado. Exemplo:
Pontos do jogador Maria: 1
Pontos do jogador João: 0</p>
</li>
<li>
<p dir="auto">Ao final da rodada 3 a aplicação deve informar quem foi o vencedor ou se foi um empate.</p>
</li>
</ul>
<p dir="auto"><strong>Opcional</strong></p>
<ul dir="auto">
<li>Fazer o controle de versionamento da sua aplicação usando git;</li>
<li>Subir a aplicação para um repositório do github.</li>
</ul>
<h1 tabindex="-1" dir="auto"><a id="user-content-desafios" class="anchor" aria-hidden="true" href="#desafios"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path d="m7.775 3.275 1.25-1.25a3.5 3.5 0 1 1 4.95 4.95l-2.5 2.5a3.5 3.5 0 0 1-4.95 0 .751.751 0 0 1 .018-1.042.751.751 0 0 1 1.042-.018 1.998 1.998 0 0 0 2.83 0l2.5-2.5a2.002 2.002 0 0 0-2.83-2.83l-1.25 1.25a.751.751 0 0 1-1.042-.018.751.751 0 0 1-.018-1.042Zm-4.69 9.64a1.998 1.998 0 0 0 2.83 0l1.25-1.25a.751.751 0 0 1 1.042.018.751.751 0 0 1 .018 1.042l-1.25 1.25a3.5 3.5 0 1 1-4.95-4.95l2.5-2.5a3.5 3.5 0 0 1 4.95 0 .751.751 0 0 1-.018 1.042.751.751 0 0 1-1.042.018 1.998 1.998 0 0 0-2.83 0l-2.5 2.5a1.998 1.998 0 0 0 0 2.83Z"></path></svg></a>Desafios</h1>

<li>Se a terceira rodada terminar em empate, faça com que os jogadores continuem jogando dados. O próximo a pontuar ganha o jogo.</li>
<li>Crie uma opção antes de iniciar o jogo que permite que o usuário selecione a quantidade de rodadas. A quantidade deve estar entre 1 e 5.</li>
</ol>
</article>
