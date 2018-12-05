# AstroShooter

Diogo de Andrade
ULHT + Fun Punch Games
------------------------------

Isto é um jogo (em princípio) feito em 45 minutos para a Workshop "CodeFu - Fazer um jogo em 45 minutos"
O jogo desenhado tinha os seguintes objetivos:

- Top-down space shooter
- Cursors movem a nave
- Rato aponta e dispara
- Inimigos vêm em waves e atacam o jogador

As regras auto-impostas são as seguintes:

- Assets pré-feitos : Texturas, modelos, imagens, sons, efeitos, materiais, fonts. Pode ser necessário fazer algo mais, mas acho que o que   tenho chega!
- Todo o código feito nos 45 minutos: Unity 2018.3 + TextMeshPro + LWRP: Packages já importados, Visual Studio 2015
- Aspecto visual mais ou menos irrelevante
- Design não muito importante, apesar de haver algum cuidado para a mecânica base ser divertida
- Excepção ao pontos anteriores: o Title Screen (para poder creditar correctamente os autores dos assets que estou a usar)

Os primeiros commits (fáceis de identificar) é só a preparação do material para a workshop, o commit a seguir é o jogo no estado em que estava no final da workshop (ao final de cerca de 50 mins).

O que ficou a funcionar:
- Há uma nave do jogador, controlada com WASD ou cursores
- A nave aponta sempre para o cursor do rato e pode disparar carregando no botão esquerdo do rato ou na barra de espaços
- Há naves inimigas que tentam sempre perseguir o jogador e disparam quando estão alinhadas

Sugestões de elementos que podiam ser acrescentados facilmente (bons exercícios):
- Waves: Quando todas as naves inimigas são destruídas, fazer aparecer uma nova wave de inimigos
- Várias arenas: Arenas que são específicadas por nível
- Arenas maiores: Trabalhar a câmara para seguir o jogador e fazer com que o jogo ocupe mais que um ecrã (podem usar o "zoom" para fazer o jogo mais dinâmico)
- Ecrã de game over, e restart do jogo quando o jogador morre
- Powerups: Armas novas, etc
- Suporte para controlador (fazer com que a nave não aponte para o rato, mas sim na direcção do segundo analógico): abre espaço para facilmente temos múltiplos jogadores
- Elementos de UI (energia da nave, etc)
- Charged attack (muito giro para introduzir uma mecânica de risk/reward)
- Naves inimigas fazerem "prediction" da posição do jogador para dispararem com mais precisão