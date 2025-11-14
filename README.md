# Unity Script Library

A personal library of reusable Unity scripts, organized by functionality.  
Useful as a reference source and a modular toolkit for future projects.

## Structure

### core/
Fundamental game flow systems.
- **AudioPlayer.cs** — simple sound effects handling.
- **EndScreen.cs** — end-game screen logic.
- **GameManager.cs** — global game state coordination.
- **GameSession.cs** — session tracking, score, lives, persistence.
- **LevelManager.cs** — scene loading utilities.
- **ScenePersist.cs** — object persistence across scenes.

### gameplay/
General gameplay and interaction logic.
- **Bullet.cs** — basic projectile.
- **CoinPickup.cs** — coin collection.
- **CrashDetector.cs** — collision/defeat detection.
- **DamageDealer.cs** — damage calculation and delivery.
- **DustTrail.cs** — dust effect on movement.
- **EnemySpawner.cs** — enemy spawning based on wave configuration.
- **FinishLine.cs** — level-end trigger.
- **Health.cs** — health system.
- **LevelExit.cs** — level exit with delay/options.
- **PathFinder.cs** — simple pathfinding logic.
- **Player.cs** — main player controller.
- **QuestionSO.cs** — question ScriptableObject.
- **Quiz.cs** — quiz system manager.
- **ScoreKeeper.cs** — score counter.
- **ScoreKeeper1.cs** — legacy/alternative version.
- **Shooter.cs** — shooting logic.

### movement/
Movement-specific scripts.
- **EnemyMovement.cs** — enemy movement behaviour.
- **PlayerController.cs** — input reading and control.
- **PlayerMovement.cs** — player locomotion.

### ui/
UI components.
- **UIDisplay.cs** — HUD updates.
- **UIGameOver.cs** — game-over screen.

### utilities/
General-purpose tools and helpers.
- **CameraShake.cs** — camera shake effect.
- **SpriteScroller.cs** — sprite scrolling.
- **Timer.cs** — generic timer.
- **WaveConfigSO.cs** — wave configuration ScriptableObject.

## Usage
Scripts are self-contained and can be copied directly into any Unity project.  
Designed for modular reuse without additional dependencies.

## Quick Index

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
