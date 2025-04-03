# 🦖 DinoRun 3D 🎮

Welcome to **DinoRun 3D**, an exciting endless runner inspired by the infamous chrome dino game

---

## 🎥 Gameplay Preview
📸 *[Picture to be added]*

---

## 🚀 Features
✅ **Fast-paced endless running action**  
✅ **Obstacles that keep you on your toes**  
✅ **Dynamic spawning system for endless fun**  
✅ **Simple, fun, and addictive gameplay**  
✅ **Colorful 3D graphics** 🎨

---

## 🎮 Controls
🕹️ **Jump:** `Spacebar`  or `MB1`  

---

## 🛠️ How the Game Works (Under the Hood)
DinoRun 3D follows a structured game logic powered by Unity scripts:

### **1️⃣ GameManager.cs** (Core Game Logic)
- Handles **game state** (start, restart, and game over).
- Controls **game speed**, increasing difficulty over time.
- Updates **score** and **high score**.
- Manages **UI elements** (buttons, score display, animations).

### **2️⃣ PlayerController.cs** (Dino Movement)
- Detects **player inputs** to jump.
- Ensures **ground detection** to prevent mid-air jumps.
- **Plays sound effects** for jumping and collisions.
- Stops the game if the player **hits an obstacle**.

### **3️⃣ Spawner.cs** (Obstacle Generation)
- Spawns **random obstacles** at different intervals.
- Uses a **weighted probability system** to control spawn rates.
- Continuously generates obstacles unless the game is over.

### **4️⃣ Obstacle.cs** (Obstacle Behavior)
- Moves obstacles toward the player at the **current game speed**.
- **Destroys obstacles** once they leave the screen to optimize performance.

---

## 📦 Installation & Running the Game
1️⃣ Clone the repository:  
```sh
 git clone https://github.com/S1MS4/DinoRun-3d.git
```
2️⃣ Open the project in **Unity** 🎮  
3️⃣ Press **Click the screen or hit spacebar** and start running! 🦖💨  


## 🤝 Contributing
Want to help make **DinoRun 3D** even better? Feel free to fork, submit issues, or create pull requests! 🛠️  

---

## 📜 License
This project is **open-source**! Feel free to modify and share. 😊

---

### 🌟 Don't forget to ⭐ the repo if you enjoy the game! Happy running! 🦖💨
