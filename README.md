<div align="center">🎮 Tic-Tac-Toe Game

A clean two-player Tic-Tac-Toe desktop game built with C# and Windows Forms.

<p>
  <a href="https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game">
    <img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github" alt="GitHub Repository">
  </a>
  <img src="https://img.shields.io/badge/C%23-Programming%20Language-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt=".NET Framework 4.7.2">
  <img src="https://img.shields.io/badge/Windows%20Forms-Desktop%20Application-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms">
  <img src="https://img.shields.io/badge/License-MIT-2ea44f?style=for-the-badge" alt="MIT License">
</p><p>
  <strong>A practical C# project focused on event-driven programming, game-state management, conditional logic, and Windows Forms UI development.</strong>
</p></div>---

📌 Overview

Tic-Tac-Toe Game is a two-player desktop application developed using C# and Windows Forms on .NET Framework 4.7.2.

The project implements the complete gameplay cycle of a classic 3×3 Tic-Tac-Toe game: players take alternating turns, the application validates moves, detects winning combinations, identifies draws, highlights the winning cells, and allows the board to be reset for a new game.

The project was built as a practical exercise to strengthen understanding of C# fundamentals, event-driven programming, enums, structs, methods, control events, resource management, and game-state logic.

---

✨ Features

- 🎮 Two-Player Local Gameplay — Player 1 uses X and Player 2 uses O.
- 🔄 Automatic Turn Switching — The active player changes after every valid move.
- 🚫 Invalid Move Detection — Prevents selecting an already occupied cell and displays an error message.
- 🧠 Win Detection — Checks all possible horizontal, vertical, and diagonal winning combinations.
- 🏆 Winner Identification — Determines whether Player 1 or Player 2 won.
- 🟩 Winning Combination Highlight — Winning cells are visually highlighted when a player wins.
- 🤝 Draw Detection — Detects when all nine cells are occupied without a winner.
- 📊 Game Status Display — Shows the current turn and final game result.
- 🔁 Reset Game — Clears the board and restores the game to its initial state.
- 🎨 Custom UI — Dark-themed interface with custom X, O, and empty-cell resources.
- 🖱️ Event-Driven Interaction — Board buttons share a centralized click handler for move processing.

---

🖼️ Game Interface

<div align="center"><img src="Tic-Tac-Toe%20Game%20Interface.png" alt="Tic-Tac-Toe Game Interface" width="850"></div>---

🛠️ Technologies Used

Technology| Purpose
C#| Application and game logic
.NET Framework 4.7.2| Runtime and application framework
Windows Forms| Desktop graphical user interface
Visual Studio| Development environment
System.Drawing| Custom board drawing and visual styling
WinForms Resources| X, O, and empty-cell images

---

🧠 Game Logic

The game keeps track of its current state through a small set of dedicated types.

Player State

An "ePlayer" enum identifies whose turn it is:

- "Player1"
- "Player2"

Game Result

An "eWinner" enum represents the current result:

- "Player1"
- "Player2"
- "Draw"
- "GameInProgress"

Game Status

The "stGamestatus" structure stores the main runtime state:

- "Winner"
- "GameOver"
- "Playcount"

Winning Conditions

After every valid move, the application checks the eight possible winning combinations:

- 3 horizontal rows
- 3 vertical columns
- 2 diagonals

When a winning combination is found, the corresponding cells are highlighted and the game ends.

If all 9 moves are completed without a winner, the game is declared a draw.

---

🏗️ Project Structure

Tic-Tac-Toe-Game/
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── App.config
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   ├── Settings.settings
│   └── Settings.Designer.cs
│
├── Resources/
│   ├── X.png
│   ├── O.png
│   └── question-mark-96.png
│
├── Tic-Tac-Toe Game Interface.png
├── LICENSE.txt
└── README.md

---

🔍 Important Implementation Details

Centralized Button Handling

All nine board buttons use the same click event:

private void button_Click(object sender, EventArgs e)
{
    ChangeImage((Button)sender);
}

This keeps move handling centralized instead of creating separate logic for every cell.

Turn Management

The application starts with Player 1 and switches the active player after every valid move.

Player 1 (X)
     ↓
Valid Move
     ↓
Player 2 (O)
     ↓
Valid Move
     ↓
Player 1 (X)

Game Reset

The reset operation restores:

- All nine cells to the empty state
- Move counter to "0"
- Player turn to Player 1
- Winner state to "GameInProgress"
- Game status to active
- UI labels to their initial values

---

🎮 How to Play

1. Launch the application.
2. Player 1 starts with "X".
3. Click any empty cell.
4. The turn automatically switches to Player 2, who plays with "O".
5. Continue alternating turns.
6. The first player to align three symbols horizontally, vertically, or diagonally wins.
7. If all nine cells are filled without a winner, the game ends in a draw.
8. Press Reset Game to start a new round.

---

🚀 Getting Started

Prerequisites

- Windows
- Visual Studio 2019 or later
- .NET Framework 4.7.2

Clone the Repository

git clone https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game.git

Open the Project

Open:

MyProjectGameH.sln

in Visual Studio.

Run

1. Build the solution.
2. Set the project as the startup project.
3. Press F5 or click Start.
4. Start playing.

---

📚 What This Project Demonstrates

This project provides practical experience with:

- C# programming fundamentals
- Object-oriented programming concepts
- Windows Forms development
- Event-driven programming
- Enums and structures
- Methods and parameter passing
- Conditional logic
- State management
- Button/control interaction
- Resource handling
- Basic game algorithms
- UI feedback and validation
- Debugging and iterative development

---

🔮 Possible Future Improvements

The current version focuses on the core two-player gameplay. Possible future enhancements include:

- 🧮 Score tracking across multiple rounds
- 🤖 Player vs. Computer mode
- 🧠 AI opponent using the Minimax algorithm
- 🔊 Sound effects
- ✨ Additional animations and UI feedback
- ⚙️ Difficulty levels
- 🏁 Match history and statistics
- 🎨 Additional themes and visual customization

---

📄 License

This project is licensed under the MIT License.

See the ""LICENSE.txt"" (LICENSE.txt) file for the complete license text.

---

👨‍💻 Author

<div align="center">Aiman Ameen Mohammed

C# .NET & C++ Developer | OOP & Database (SQL, ADO.NET) | Computer Science Student

<p>
  <a href="https://github.com/aimanameenmohammed">GitHub</a> •
  <a href="https://www.linkedin.com/in/aiman-ameen-2548673a8/">LinkedIn</a> •
  <a href="https://t.me/AimanAmeenMohammed">Telegram</a> •
  <a href="https://wa.me/967730062999">WhatsApp</a>
</p></div>---

<div align="center">⭐ If you found this project useful, consider giving the repository a star.

Learn → Build → Debug → Understand → Improve

</div>