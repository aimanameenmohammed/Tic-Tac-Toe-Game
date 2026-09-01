# 🎮 Tic-Tac-Toe Game

<div align="center">

### A Classic Two-Player Tic-Tac-Toe Game Built with C# Windows Forms

<br>

<a href="https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game">
<img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white">
</a>

<img src="https://img.shields.io/badge/C%23-.NET-blue?style=for-the-badge&logo=csharp&logoColor=white">

<img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=.net&logoColor=white">

<img src="https://img.shields.io/badge/Windows%20Forms-Desktop%20Application-0078D4?style=for-the-badge&logo=windows&logoColor=white">

<img src="https://img.shields.io/badge/License-MIT-2ea44f?style=for-the-badge">

</div>

---

## 📌 Table of Contents

- [📖 About The Project](#-about-the-project)
- [✨ Features](#-features)
- [🖼️ Game Interface](#️-game-interface)
- [🎮 How To Play](#-how-to-play)
- [🧠 Game Logic](#-game-logic)
- [📂 Project Structure](#-project-structure)
- [🛠️ Technologies](#️-technologies)
- [📅 Development Timeline](#-development-timeline)
- [🚀 Getting Started](#-getting-started)
- [📚 Concepts Applied](#-concepts-applied)
- [👨‍💻 Author](#-author)
- [📄 License](#-license)

---

## 📖 About The Project

**Tic-Tac-Toe Game** is a simple two-player desktop game developed using **C#** and **Windows Forms**.

The game is played on a 3×3 board where two players take turns placing their symbols:

- ❌ Player 1 → **X**
- ⭕ Player 2 → **O**

After each move, the game checks the board to determine whether a player has won or whether the game has ended in a draw.

The project focuses on implementing the game logic and applying C# programming concepts through a practical Windows Forms application.

---

## ✨ Features

- 🎮 Two-player gameplay
- ❌ X and ⭕ O player symbols
- 🔄 Automatic turn switching
- 🚫 Prevents selecting an occupied cell
- 🏆 Detects winning combinations
- 🤝 Detects draw situations
- 🟩 Highlights the winning cells
- 📊 Displays the current game status
- 🔢 Tracks the number of played moves
- 🔁 Reset Game functionality
- 🎨 Uses graphical resources for the game symbols
- 🖥️ Windows Forms graphical interface

---

## 🖼️ Game Interface

<div align="center">

<img src="Tic-Tac-Toe%20Game%20Interface.png" alt="Tic-Tac-Toe Game Interface" width="850">

<br>

### Tic-Tac-Toe Game Interface

</div>

---

## 🎮 How To Play

1. Start the application.
2. **Player 1** starts with **X**.
3. Select an empty cell on the board.
4. The turn switches automatically to **Player 2**.
5. **Player 2** plays with **O**.
6. Continue taking turns until the game ends.
7. A player wins by placing three matching symbols in:
   - A horizontal row
   - A vertical column
   - A diagonal
8. The winning cells are highlighted.
9. If all nine cells are filled without a winner, the result is a **Draw**.
10. Use **Reset Game** to start a new round.

---

## 🧠 Game Logic

The game maintains its state using dedicated C# types.

### 👥 Player

The current player is represented using an enumeration:

```csharp
enum ePlayer
{
    Player1,
    Player2
}
````

### 🏆 Winner

The game result is represented using:

```csharp
enum eWinner
{
    Player1,
    Player2,
    Draw,
    GameInProgress
}
```

### 📊 Game Status

The current game state is stored using:

```csharp
struct stGamestatus
{
    public eWinner Winner;
    public bool GameOver;
    public short Playcount;
}
```

This keeps track of:

* Current winner
* Whether the game is over
* Number of played moves

### 🏆 Winning Combinations

After every valid move, the application checks the possible winning combinations on the 3×3 board.

The game checks:

* 3 horizontal combinations
* 3 vertical combinations
* 2 diagonal combinations

For a total of:

**8 possible winning combinations.**

### 🚫 Occupied Cells

Before placing a symbol, the application checks whether the selected cell is still available.

If the cell has already been selected, the existing move is preserved and the player is notified.

### 🤝 Draw Detection

The game keeps track of the number of valid moves.

When all **9 cells** have been played without a winner, the game result becomes:

```text
Draw
```

### 🔄 Reset Game

The Reset Game functionality returns the game to its initial state by clearing the board and resetting the game status.

---

## 📂 Project Structure

```text
Tic-Tac-Toe-Game/
│
├── 📄 Program.cs
├── 📄 Form1.cs
├── 📄 Form1.Designer.cs
├── 📄 Form1.resx
├── 📄 App.config
│
├── 📁 Properties/
│   ├── 📄 AssemblyInfo.cs
│   ├── 📄 Resources.resx
│   ├── 📄 Resources.Designer.cs
│   ├── 📄 Settings.settings
│   └── 📄 Settings.Designer.cs
│
├── 📁 Resources/
│   ├── 🖼️ X.png
│   ├── 🖼️ O.png
│   └── 🖼️ question-mark-96.png
│
├── 🖼️ Tic-Tac-Toe Game Interface.png
│
├── 📄 MyProjectGameH.csproj
├── 📄 MyProjectGameH.sln
├── 📄 .gitignore
├── 📄 .gitattributes
├── 📄 LICENSE.txt
└── 📄 README.md
```

---

## 🛠️ Technologies

| Technology               | Usage                                  |
| :----------------------- | :------------------------------------- |
| **C#**                   | Main programming language              |
| **.NET Framework 4.7.2** | Application framework                  |
| **Windows Forms**        | Desktop user interface                 |
| **System.Drawing**       | Drawing and graphical elements         |
| **Visual Studio**        | Development environment                |
| **Git / GitHub**         | Version control and repository hosting |
---



## 📅 Development Timeline


| Milestone | Date |
| :--- | :--- |
| 🚀 **Started** | November 28, 2025 |
| ✅ **Completed** | November 30, 2025 |
| ⏱️ **Development Period** | 2 Days |


> **Note:** These dates represent the actual development period of the project, not the date it was uploaded to GitHub.
---

## 🚀 Getting Started

### Prerequisites

Make sure you have:

* Windows
* Visual Studio
* .NET Framework 4.7.2 Developer Pack

### Clone The Repository

```bash
git clone https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game.git
```

### Open The Project

Open the solution file:

```text
MyProjectGameH.sln
```

in Visual Studio.

### Run The Application

Build the solution and press:

```text
F5
```

to start the game.

---

## 📚 Concepts Applied

This project applies practical C# and Windows Forms concepts, including:

* C# programming fundamentals
* Enumerations
* Structures
* Methods
* Conditional statements
* Event-driven programming
* Windows Forms controls
* Button click events
* Game state management
* Input validation
* Win-condition checking
* Draw detection
* Move counting
* Resetting application state
* Application resources
* `System.Drawing`

---

## 👨‍💻 Author

<div align="center">

### Aiman Ameen Mohammed

**Software Developer | C# | C++ | .NET | Database Development**

<br>

<a href="https://github.com/aimanameenmohammed">
<img src="https://img.shields.io/badge/GitHub-aimanameenmohammed-181717?style=for-the-badge&logo=github&logoColor=white">
</a>

<a href="https://www.linkedin.com/in/aiman-ameen-2548673a8/">
<img src="https://img.shields.io/badge/LinkedIn-Aiman%20Ameen%20Mohammed-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white">
</a>

</div>

---

## 📄 License

This project is licensed under the **MIT License**.

See the [LICENSE.txt](LICENSE.txt) file for the complete license.

---

<div align="center">

<br>

<img src="https://capsule-render.vercel.app/api?type=rounded&color=0:141E30,100:243B55&height=100&section=footer&text=Learn.%20Build.%20Debug.%20Improve.&fontSize=24&fontColor=ffffff&animation=fadeIn" width="100%">

<br><br>

**Aiman Ameen Mohammed**

</div>

