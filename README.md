# 🎮 Tic-Tac-Toe Game

<div align="center">

### 🎯 A Classic Two-Player Game Built with C# & Windows Forms

A simple and interactive desktop Tic-Tac-Toe game focused on clean game-state management, event-driven programming, and practical C# development.

<br>

<a href="https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game">
<img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white">
</a>

<img src="https://img.shields.io/badge/C%23-.NET-blue?style=for-the-badge&logo=csharp&logoColor=white">

<img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=.net&logoColor=white">

<img src="https://img.shields.io/badge/Windows%20Forms-Desktop%20Application-0078D4?style=for-the-badge&logo=windows&logoColor=white">

<img src="https://img.shields.io/badge/License-MIT-2ea44f?style=for-the-badge">

<br><br>

**Learn → Build → Debug → Understand → Improve**

</div>

---

## 📌 Table of Contents

- [📖 Overview](#-overview)
- [✨ Features](#-features)
- [🖼️ Game Interface](#️-game-interface)
- [🎮 How the Game Works](#-how-the-game-works)
- [🧠 Game Logic](#-game-logic)
- [🏗️ Project Structure](#️-project-structure)
- [🛠️ Technologies](#️-technologies)
- [🚀 Getting Started](#-getting-started)
- [🎯 How to Play](#-how-to-play)
- [📚 Concepts Applied](#-concepts-applied)
- [🔮 Future Improvements](#-future-improvements)
- [👨‍💻 Author](#-author)
- [📄 License](#-license)

---

## 📖 Overview

**Tic-Tac-Toe Game** is a two-player desktop application developed using **C#**, **Windows Forms**, and **.NET Framework 4.7.2**.

The application recreates the classic 3×3 Tic-Tac-Toe game where two players take turns placing their symbols on the board:

- ❌ **Player 1** plays with **X**
- ⭕ **Player 2** plays with **O**

After every valid move, the application updates the active player and checks whether the move produced a winning combination.

The game automatically detects:

- 🏆 Player 1 wins
- 🏆 Player 2 wins
- 🤝 Draw
- ⏳ Game still in progress

When a player wins, the three winning cells are highlighted and the game ends. If all nine cells are occupied without a winner, the game is declared a draw.

The project was built as a practical C# application to strengthen understanding of **event-driven programming, enums, structures, methods, conditional logic, state management, Windows Forms controls, and resource handling**.

---

## ✨ Features

### 🎮 Two-Player Gameplay

Supports local gameplay between two players on the same computer.

- Player 1 → ❌ X
- Player 2 → ⭕ O

### 🔄 Automatic Turn Switching

After every valid move, the active player automatically changes.

```text
Player 1
   ↓
Places X
   ↓
Player 2
   ↓
Places O
   ↓
Player 1
````

### 🚫 Invalid Move Detection

A player cannot select a cell that has already been occupied.

When an occupied cell is selected, the application displays an error message instead of changing the existing move.

### 🏆 Win Detection

The application checks all possible winning combinations:

* 3 horizontal rows
* 3 vertical columns
* 2 diagonal combinations

Total:

```text
8 Possible Winning Combinations
```

### 🟩 Winning Cell Highlight

When a winning combination is detected, the three corresponding cells are highlighted to make the winning move visually clear.

### 🤝 Draw Detection

If all nine cells are occupied and no player has won, the game automatically ends as a draw.

### 📊 Game Status

The interface displays:

* Current player's turn
* Winner
* Game status
* Game over state

### 🔁 Reset Game

The **Reset Game** button restores the board to its initial state:

* Clears all moves
* Resets the move counter
* Returns the turn to Player 1
* Clears the winner state
* Restores the game status to `In Progress`

### 🎨 Custom Game Interface

The application uses custom graphical resources for:

* ❌ X
* ⭕ O
* ❓ Empty cell

The board itself is also drawn programmatically using `System.Drawing`.

---

## 🖼️ Game Interface

<div align="center">

<img src="Tic-Tac-Toe%20Game%20Interface.png" alt="Tic-Tac-Toe Game Interface" width="850">

<br><br>

<strong>Tic-Tac-Toe Game Interface</strong>

</div>

---

## 🎮 How the Game Works

The game starts with **Player 1**.

Each player selects an empty cell on the 3×3 board.

```text
                    ┌─────────────────┐
                    │   Start Game    │
                    └────────┬────────┘
                             │
                             ▼
                    ┌─────────────────┐
                    │    Player 1     │
                    │       X         │
                    └────────┬────────┘
                             │
                             ▼
                    ┌─────────────────┐
                    │  Select Empty   │
                    │      Cell       │
                    └────────┬────────┘
                             │
                             ▼
                    ┌─────────────────┐
                    │ Check Winner    │
                    └────────┬────────┘
                             │
                  ┌──────────┴──────────┐
                  │                     │
                Winner                 No Winner
                  │                     │
                  ▼                     ▼
            ┌───────────┐       ┌──────────────┐
            │ Game Over │       │ Switch Turn  │
            └───────────┘       └──────┬───────┘
                                       │
                                       ▼
                                 Next Player
```

After every valid move, the application checks the board before allowing the next player to continue.

---

## 🧠 Game Logic

The game state is managed using dedicated C# types.

### 👥 Player State

The `ePlayer` enum determines whose turn it is:

```csharp
enum ePlayer
{
    Player1,
    Player2
}
```

### 🏆 Winner State

The `eWinner` enum represents the current game result:

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

The `stGamestatus` structure stores the main state of the current game:

```csharp
struct stGamestatus
{
    public eWinner Winner;
    public bool GameOver;
    public short Playcount;
}
```

This allows the application to keep track of:

* Current winner
* Whether the game has ended
* Number of moves played

---

### 🔍 Checking Winning Combinations

After every valid move, the application checks the eight possible winning combinations.

#### Horizontal

```text
[1] [2] [3]
[4] [5] [6]
[7] [8] [9]
```

Checks:

```text
1 ─ 2 ─ 3
4 ─ 5 ─ 6
7 ─ 8 ─ 9
```

#### Vertical

```text
1 │ 2 │ 3
4 │ 5 │ 6
7 │ 8 │ 9
```

Checks:

```text
1 │ 4 │ 7
2 │ 5 │ 8
3 │ 6 │ 9
```

#### Diagonal

Checks:

```text
1 ─── 5 ─── 9
```

and:

```text
3 ─── 5 ─── 7
```

This gives the game its complete **8-combination win detection system**.

---

### 🚫 Preventing Invalid Moves

Every board button starts with the tag:

```text
?
```

When a player selects an empty cell, the application replaces the tag with:

```text
x
```

or:

```text
o
```

If the cell is selected again, the application detects that the tag is no longer `?` and displays an error message.

---

### 🔢 Move Counter

Every valid move increments:

```text
Playcount
```

When:

```text
Playcount == 9
```

and no winner has already been detected, the application declares the result as:

```text
Draw
```

---

## 🏗️ Project Structure

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
│   ├── 🖼️ question-mark-96.png
│   ├── 🖼️ IMG-20260228-WA0089.jpg
│   └── 🖼️ IMG-20260228-WA0090.jpg
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

| Technology               | Purpose                                   |
| :----------------------- | :---------------------------------------- |
| **C#**                   | Main programming language                 |
| **.NET Framework 4.7.2** | Application framework                     |
| **Windows Forms**        | Desktop graphical user interface          |
| **System.Drawing**       | Drawing the game board and visual styling |
| **WinForms Resources**   | X, O, and empty-cell images               |
| **Visual Studio**        | Development environment                   |
| **Git & GitHub**         | Version control and project hosting       |

---

## 🚀 Getting Started

### 📋 Prerequisites

Before running the project, make sure you have:

* Windows
* Visual Studio 2019 or later
* .NET Framework 4.7.2 Developer Pack

---

### 📥 Clone the Repository

```bash
git clone https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game.git
```

Then open the project directory:

```bash
cd Tic-Tac-Toe-Game
```

---

### 🖥️ Open the Project

Open the solution file:

```text
MyProjectGameH.sln
```

using Visual Studio.

---

### ▶️ Run the Application

1. Open `MyProjectGameH.sln`.
2. Build the solution.
3. Set the project as the startup project if required.
4. Press **F5** or select **Start**.
5. The Tic-Tac-Toe game will launch.

---

## 🎯 How to Play

1. Start the application.
2. **Player 1** starts with `X`.
3. Click any empty cell.
4. The turn automatically switches to **Player 2**.
5. **Player 2** plays with `O`.
6. Continue taking turns.
7. The first player to align three symbols horizontally, vertically, or diagonally wins.
8. The winning cells are highlighted.
9. If all nine cells are filled without a winner, the game ends in a draw.
10. Click **Reset Game** to start a new round.

---

## 📚 Concepts Applied

This project provided practical experience with several C# and Windows Forms concepts:

* 🧩 C# Programming Fundamentals
* 🏗️ Object-Oriented Programming
* 🖥️ Windows Forms Development
* 🖱️ Event-Driven Programming
* 🔘 Button Controls and Events
* 🔄 Game State Management
* 🧠 Conditional Logic
* 🔢 Enums
* 📦 Structures
* 🔧 Methods
* 🎯 Parameter Passing
* 🔍 Validation
* 🏆 Win Detection Algorithms
* 🤝 Draw Detection
* 🔁 Resetting Application State
* 🎨 `System.Drawing`
* 🖼️ Application Resources
* 🐛 Debugging and Problem Solving

---

## 🔮 Future Improvements

The current version focuses on the core two-player gameplay.

Possible future improvements include:

* 🤖 **Player vs Computer** mode
* 🧠 **AI Opponent** using the Minimax algorithm
* 🏆 **Score Tracking** across multiple rounds
* 📊 **Game Statistics**
* 🔊 **Sound Effects**
* ✨ **Animations**
* 🎚️ **Difficulty Levels**
* 🎨 **Additional Themes**
* 🕹️ **Game History**
* ⚙️ **Improved User Experience**

These are potential future enhancements and are **not part of the current version**.

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

You can view the complete license here:

**[📄 View LICENSE](LICENSE.txt)**

---

<div align="center">

<br>

<img src="https://capsule-render.vercel.app/api?type=rounded&color=0:141E30,100:243B55&height=100&section=footer&text=Learn.%20Build.%20Debug.%20Improve.&fontSize=24&fontColor=ffffff&animation=fadeIn" width="100%">

<br>

**Aiman Ameen Mohammed**

</div>
