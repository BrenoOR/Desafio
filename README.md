# Desafio
#Observacao:
	As demais atividades do desafio estao neste mesmo repositorio, numa pasta chamada Atividades.

#Primeiro relatorio:
	Neste primeiro relatorio, queria dizer que comecei a fazer o jogo, mas acabei esquecendo de anotar tudo, entao o primeiro commit ja tem uma base do jogo, sem pontuacao, sem boss, e com inimigos que nao atacam, tentei fazer um Space Invaders, que e um dos primeiros jogos que eu joguei e tenho um carinho maior por ele. Como eu nao havia sequer parado para iniciar o relatorio, o projeto esta com um nome default.
	Agora vamos ao processo, primeiro pensei em criar logo o cenario, e por isso baixei uma imagem do espaco em 8 bits, para usar de base, alias, todos os sprites usados foram tirados do google mesmo. Depois de definir o cenario, com uma imagem estatica, busquei pelo sprint do jogador e dos inimigos. Depois de tudo feito, iniciei colocando o jogador na camera, e ajustando os movimentos primeiramente, depois criei um sprite basico que seria o projetil do jogador no paint mesmo, e finalizei todo o script de jogador ja com movimento e tiro. Depois disso, coloquei uma copia dos inimigos na camera e criei um script basico de movimento, sem muitos detalhes, onde ele vai pro lado ate um certo limite, depois volta ate outro certo limite, ele tambem tem um indicador de qual lado que o inimigo comeca a andar. Depois veio a parte mais trabalhosa que foi a de fazer com que o projetil, ao acertar um inimigo, fizesse com que o inimigo perdesse vida, e consequentemente morresse, nao tive tantos problemas em fazer o projetil acertar o alvo, mas o maior problema era o alvo sentir que foi atingido. Depois de uma tarde inteira de trabalho consegui identificar o meu erro. Dai chegamos a situacao onde me encontro, acabei de finalizar uma animacao de explosao, para quando os inimigos forem abatidos, e minha meta agora e finalizar o movimento do chefao, quero que ele seja mais livre, e que tente acertar o jogador. Ainda nao sei como vou fazer isso mas o jeito e tentar. Qualquer avanco irei atualizar aqui.

*Ps.: Esqueci de tirar o sprite do Boss antes de fazer o commit, talves eu inicie criando o sistema de pontuacao antes de terminar o boss