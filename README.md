🎮 Tic-Tac-Toe Game

<div align="center">A Classic Two-Player Tic-Tac-Toe Game Built with C# WinForms

""C#" (https://img.shields.io/badge/C%23-.NET%20Framework-blue?style=for-the-badge&logo=csharp&logoColor=white)" (https://dotnet.microsoft.com/)
""Windows Forms" (https://img.shields.io/badge/UI-Windows%20Forms-512BD4?style=for-the-badge)" (https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
"".NET Framework" (https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge)" (https://dotnet.microsoft.com/en-us/download/dotnet-framework)
""Visual Studio" (https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)" (https://visualstudio.microsoft.com/)
""License" (https://img.shields.io/badge/License-MIT-green?style=for-the-badge)" (LICENSE.txt)

<br>A desktop implementation of the classic X-O game, developed to practice C# programming, Windows Forms event handling, game-state management, and conditional logic.

</div>---

📌 Overview

Tic-Tac-Toe Game is a two-player desktop game developed using C# and Windows Forms.

The application provides a simple interactive 3×3 game board where two players take turns placing X and O symbols. After every move, the game checks all possible winning combinations and determines whether a player has won or the game has ended in a draw.

The project focuses on applying fundamental programming concepts to a real interactive application, including:

- Event-driven programming
- Game-state management
- Conditional logic
- Enumerations and structures
- Reusable methods
- Windows Forms controls and events
- Resource management
- Win-condition evaluation

---

✨ Features

- 🎮 Two-Player Local Gameplay
- ❌ Player 1 uses X
- ⭕ Player 2 uses O
- 🔄 Automatic Turn Switching
- 🧠 Real-Time Win Detection
- 🏆 Winning Combination Highlighting
- 🤝 Draw Detection
- 🚫 Prevents Selecting an Occupied Cell
- 🔁 Restart Game Functionality
- 📊 Game Status Display
- 🎨 Custom Dark Game Interface
- 🖼️ Embedded Game Resources

---

📸 Game Interface

<div align="center"><img src="Tic-Tac-Toe%20Game%20Interface.png" alt="Tic-Tac-Toe Game Interface" width="900"></div>---

🕹️ How the Game Works

The game is played on a 3×3 grid.

Player 1 — X

Player 1 starts the game and places an X in an available cell.

Player 2 — O

After Player 1's move, the turn automatically switches to Player 2, who places an O.

Winning Condition

A player wins when they successfully place three identical symbols in:

- ➡️ A horizontal row
- ⬇️ A vertical column
- ↘️ A diagonal
- ↙️ The opposite diagonal

There are 8 possible winning combinations in a 3×3 Tic-Tac-Toe board.

Draw Condition

If all 9 cells are occupied and no player has achieved a winning combination, the game ends in a draw.

---

🧠 Game Logic

The game maintains its state using a small set of dedicated types.

Player State

An enumeration is used to determine whose turn it is:

enum ePlayer
{
    Player1,
    Player2
}

Winner State

Another enumeration represents the current game result:

enum eWinner
{
    Player1,
    Player2,
    Draw,
    GameInProgress
}

Game Status

The current game information is grouped inside a structure:

struct stGamestatus
{
    public eWinner Winner;
    public bool GameOver;
    public short Playcount;
}

This allows the application to keep track of:

- Current winner
- Whether the game has ended
- Number of moves played

---

🔍 Win Detection

After every valid move, the application checks the possible winning combinations.

The game evaluates:

1  2  3    → Horizontal
4  5  6    → Horizontal
7  8  9    → Horizontal

1  4  7    → Vertical
2  5  8    → Vertical
3  6  9    → Vertical

1  5  9    → Diagonal
3  5  7    → Diagonal

The reusable "CheckValues()" method compares three cells at a time.

When a winning combination is found:

1. The three winning cells are highlighted.
2. The winner is identified.
3. The game status changes to Game Over.
4. A result message is displayed.

---

🔄 Game Flow

          ┌─────────────────┐
          │    Start Game   │
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
          │ Check Winner?   │
          └──────┬─────┬────┘
                 │     │
               Yes     No
                 │     │
                 ▼     ▼
            Game Over  Player 2
                        O
                         │
                         ▼
                  ┌─────────────┐
                  │ Check Winner│
                  └──────┬──────┘
                         │
                         ▼
                    Continue...

---

🛠️ Technologies Used

Technology| Purpose
C#| Application and game logic
Windows Forms| Desktop graphical user interface
.NET Framework 4.7.2| Application runtime/framework
Visual Studio| Development environment
GDI+ / System.Drawing| Drawing the game board
Embedded Resources| X, O and game interface assets

The project file confirms that the application targets .NET Framework 4.7.2 and is configured as a Windows executable.

---

📁 Project Structure

Tic-Tac-Toe-Game/
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
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── App.config
│
├── MyProjectGameH.csproj
├── MyProjectGameH.sln
├── LICENSE.txt
├── .gitignore
└── README.md

The repository currently contains the WinForms form files, project/solution files, application configuration, resources, license, and README.

---

🚀 Getting Started

Prerequisites

Before running the project, make sure you have:

- Windows
- Visual Studio 2019 or newer
- .NET Framework 4.7.2 Developer Pack

---

1️⃣ Clone the Repository

git clone https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game.git

2️⃣ Navigate to the Project

cd Tic-Tac-Toe-Game

3️⃣ Open the Solution

Open:

MyProjectGameH.sln

using Visual Studio.

4️⃣ Build the Project

In Visual Studio:

Build → Build Solution

or press:

Ctrl + Shift + B

5️⃣ Run the Game

Press:

F5

or click:

Start

---

🎯 Learning Objectives

This project was developed as a practical exercise to strengthen understanding of:

- C# fundamentals
- Object-oriented programming concepts
- Enumerations
- Structures
- Methods and reusable logic
- Conditional statements
- Event-driven programming
- Windows Forms controls
- Button click events
- Game-state management
- Resource management
- Basic algorithmic thinking
- User interface development

---

🧩 Important Implementation Details

Centralized Button Handling

Instead of creating completely separate logic for every game cell, the project uses a shared click handler:

private void button_Click(object sender, EventArgs e)
{
    ChangeImage((Button)sender);
}

This keeps the interaction logic centralized and reduces duplicated event-handling code.

Cell State

Each button uses its "Tag" property to represent its current state:

? → Empty
x → Player 1
o → Player 2

Board Rendering

The game board itself is drawn using the form's "Paint" event and "System.Drawing", creating the grid lines dynamically.

---

🔮 Possible Future Improvements

The current version focuses on a clean two-player local experience. Possible future improvements include:

- 🏆 Scoreboard for multiple rounds
- 🤖 Single-player mode with AI
- 🎚️ Difficulty levels
- 🔊 Sound effects
- ✨ Win animations
- 🎨 Theme customization
- 🔄 Improved responsive layout
- 💾 Match history
- 🧹 Further separation of UI and game logic
- 🧪 Automated unit tests for game logic

---

📚 What I Learned

Building this project helped reinforce the idea that even a simple game can be a useful software-development exercise.

The project provided practical experience with event-driven programming, state management, reusable methods, UI interaction, and translating a set of game rules into executable logic.

---

👨‍💻 Author

<div align="center">Aiman Ameen Mohammed

C# Developer | .NET | Windows Forms | SQL

<br><a href="https://github.com/aimanameenmohammed">
<img src="https://img.shields.io/badge/GitHub-aimanameenmohammed-181717?style=for-the-badge&logo=github&logoColor=white">
</a><a href="https://www.linkedin.com/in/aiman-ameen-2548673a8/">
<img src="https://img.shields.io/badge/LinkedIn-Aiman%20Ameen%20Mohammed-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white">
</a></div>---

📄 License

This project is licensed under the MIT License.

See the "LICENSE.txt" (LICENSE.txt) file for more information.

---

<div align="center">⭐ If you found this project useful, consider giving it a star!

Learn • Build • Debug • Improve

</div>