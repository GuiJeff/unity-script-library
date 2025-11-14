# Unity Script Library

Biblioteca pessoal de scripts Unity para referência e reutilização.  
Organizada por função: núcleo do jogo, gameplay, movimento, UI e utilitários.

## Estrutura

### core/
Sistemas fundamentais de fluxo do jogo.
- **AudioPlayer.cs** — gerenciamento simples de efeitos sonoros.
- **EndScreen.cs** — lógica da tela de fim de jogo.
- **GameManager.cs** — coordenação geral do estado do jogo.
- **GameSession.cs** — controle de sessão, pontuação, vidas, persistência.
- **LevelManager.cs** — carregamento de cenas.
- **ScenePersist.cs** — persistência de objetos entre cenas.

### gameplay/
Scripts de lógica de jogo e interação.
- **Bullet.cs** — projétil básico.
- **CoinPickup.cs** — coleta de moeda.
- **CrashDetector.cs** — detecção de colisão/derrota.
- **DamageDealer.cs** — cálculo e entrega de dano.
- **DustTrail.cs** — efeito de poeira no movimento.
- **EnemySpawner.cs** — spawn de inimigos baseado em configuração.
- **FinishLine.cs** — gatilho de final de fase.
- **Health.cs** — sistema de vida.
- **LevelExit.cs** — saída de fase com delay/opções.
- **PathFinder.cs** — lógica de pathing simples.
- **Player.cs** — controlador geral do jogador.
- **QuestionSO.cs** — struct de pergunta (ScriptableObject).
- **Quiz.cs** — gerenciamento do sistema de perguntas.
- **ScoreKeeper.cs** — contador de pontuação.
- **ScoreKeeper1.cs** — variante antiga/alternativa.
- **Shooter.cs** — lógica de disparo.

### movement/
Scripts específicos de movimentação.
- **EnemyMovement.cs** — movimento de inimigos.
- **PlayerController.cs** — leitura de input e controle do jogador.
- **PlayerMovement.cs** — locomotion do jogador.

### ui/
Elementos de interface.
- **UIDisplay.cs** — atualização de UI.
- **UIGameOver.cs** — tela de derrota.

### utilities/
Ferramentas auxiliares.
- **CameraShake.cs** — tremor de câmera.
- **SpriteScroller.cs** — scroll de sprites.
- **Timer.cs** — temporizador genérico.
- **WaveConfigSO.cs** — configuração de ondas (ScriptableObject).

## Como usar
Copie módulos ou trechos conforme necessário.  
Scripts são autocontidos e podem ser reutilizados entre projetos sem dependências adicionais.

## Índice rápido
### Core
- [AudioPlayer](core/AudioPlayer.cs)
- [GameSession](core/GameSession.cs)
- [LevelManager](core/LevelManager.cs)

### Gameplay
- [Player](gameplay/Player.cs)
- [EnemySpawner](gameplay/EnemySpawner.cs)
- [Health](gameplay/Health.cs)
- [Shooter](gameplay/Shooter.cs)

### Movement
- [PlayerMovement](movement/PlayerMovement.cs)
- [EnemyMovement](movement/EnemyMovement.cs)

### UI
- [UIDisplay](ui/UIDisplay.cs)
- [UIGameOver](ui/UIGameOver.cs)

### Utilities
- [CameraShake](utilities/CameraShake.cs)
- [Timer](utilities/Timer.cs)
- [WaveConfigSO](utilities/WaveConfigSO.cs)
