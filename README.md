<h1 align="center">🦖 DinoRun 3D 🎮</h1>
<p align="center">
  Welcome to <strong>DinoRun 3D</strong>, an exciting endless runner inspired by the infamous Chrome dino game.
</p>

<hr>

<h2 align="center">🎥 Game Screenshots</h2>
<p align="center">
  <img src="start_screen.png" width="200" style="margin-right: 10px;" />
  <img src="end_screen.png" width="200" />
</p>

<hr>

<h2 align="center">🚀 Features</h2>
<p align="center">
  ✅ <strong>Fast-paced endless running action</strong><br>
  ✅ <strong>Obstacles that keep you on your toes</strong><br>
  ✅ <strong>Dynamic spawning system for endless fun</strong><br>
  ✅ <strong>Simple, fun, and addictive gameplay</strong><br>
  ✅ <strong>Colorful 3D graphics</strong> 🎨
</p>

<hr>

<h2 align="center">🎮 Controls</h2>
<p align="center">
  🕹️ <strong>Jump:</strong> <code>Spacebar</code> or <code>MB1</code>
</p>

<hr>

<h2 align="center">🛠️ How the Game Works (Under the Hood)</h2>
<p align="center">
  DinoRun 3D follows a structured game logic powered by Unity scripts.
</p>

<h3 align="center">1️⃣ GameManager.cs (Core Game Logic)</h3>
<p align="center">
  - Handles <strong>game state</strong> (start, restart, and game over).<br>
  - Controls <strong>game speed</strong>, increasing difficulty over time.<br>
  - Updates <strong>score</strong> and <strong>high score</strong>.<br>
  - Manages <strong>UI elements</strong> (buttons, score display, animations).
</p>

<h3 align="center">2️⃣ PlayerController.cs (Dino Movement)</h3>
<p align="center">
  - Detects <strong>player inputs</strong> to jump.<br>
  - Ensures <strong>ground detection</strong> to prevent mid-air jumps.<br>
  - <strong>Plays sound effects</strong> for jumping and collisions.<br>
  - Stops the game if the player <strong>hits an obstacle</strong>.
</p>

<h3 align="center">3️⃣ Spawner.cs (Obstacle Generation)</h3>
<p align="center">
  - Spawns <strong>random obstacles</strong> at different intervals.<br>
  - Uses a <strong>weighted probability system</strong> to control spawn rates.<br>
  - Continuously generates obstacles unless the game is over.
</p>

<h3 align="center">4️⃣ Obstacle.cs (Obstacle Behavior)</h3>
<p align="center">
  - Moves obstacles toward the player at the <strong>current game speed</strong>.<br>
  - <strong>Destroys obstacles</strong> once they leave the screen to optimize performance.
</p>

<hr>

<h2 align="center">📥 Installation Instructions</h2>

<h3 align="center">Option 1️⃣: Clone the Entire Repository (Recommended)</h3>
<p align="center">
  <code>git clone https://github.com/S1MS4/DinoRun-3d.git</code>
</p>
<p align="center">
  This will download both the <strong>Game</strong> and <strong>Game Files</strong> folders.
</p>
<p align="center">
  Open the project in <strong>Unity</strong> and/or start playing immediately from the <strong>Game</strong> folder alone! 🎮
</p>

<h3 align="center">Option 2️⃣: Download Game & Game Files Separately</h3>
<p align="center">
  1️⃣ <strong>Download the Game Folder</strong><br>
  - Click on the <strong>Game</strong> folder → Click Download<br><br>
<p align="center">
  2️⃣ <strong>Download the Game Files Folder</strong><br>
  - Click on the <strong>Game Files</strong> folder → Click Download<br><br>
<p align="center">
  3️⃣ <strong>Move the Game Files folder into your Unity project directory</strong><br>
  - Open the project in <strong>Unity</strong> and start playing! 🦖
</p>


<h3 align="center">🔧 How to Start Playing</h3>
<p align="center">
  1️⃣ Open the project in <strong>Unity</strong> or open the .exe in the <strong>Game</strong> folder 🎮<br>
  2️⃣ Click the screen or hit <code>spacebar</code> to start running! 🦖💨
</p>

<hr>

<h2 align="center">🤝 Contributing</h2>
<p align="center">
  Want to help make <strong>DinoRun 3D</strong> even better? Feel free to fork, submit issues, or create pull requests! 🛠️
</p>

<hr>

<h2 align="center">📜 License</h2>
<p align="center">
  This project is <strong>open-source</strong>! Feel free to modify and share. 😊
</p>

<hr>

<h3 align="center">🌟 Don't forget to ⭐ the repo if you found this helpful! 💨</h3>
