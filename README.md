<div align="center">

# 🎮 Tic-Tac-Toe Game (X-O)

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-.NET%20Framework-purple.svg?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Game Logic](https://img.shields.io/badge/Logic-Automated%20Win%20Detection-red.svg?style=for-the-badge)](https://github.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)

<p align="center">
  <b>A polished, feature-complete implementation of the classic Tic-Tac-Toe game built with C# WinForms, featuring real-time state tracking, win-condition algorithms, and a refined modern UI.</b>
</p>

[📌 Overview](#-overview) •
[✨ Key Features](#-key-features) •
[📸 Game Interface](#-game-interface) •
[🛠️ Architecture & Logic](#️-architecture--logic) •
[🕹️ How To Play](#️-how-to-play) •
[🚀 Getting Started](#-getting-started) •
[🙏 Acknowledgments](#-acknowledgments) •
[📞 Connect With Me](#-connect-with-me)

---

</div>

## 📌 Overview

The **Tic-Tac-Toe Game** is a desktop application focused on game logic architecture, turn-based state management, and custom WinForms event handling. Designed with a modern dark theme and custom graphics, it tracks gameplay flow from turn progression to automated win/draw evaluations and instant board resets.

---

## ✨ Key Features

* 🧠 **Automated Game Engine:** Evaluates horizontal, vertical, and diagonal win conditions in real-time.
* 🎨 **Refined Visual Design:** Custom color palettes, iconography, and clear visual indicators for turn progression.
* 🔄 **Turn & Score Tracking:** Displays current player turns (Player X / Player O) and tracks active status seamlessly.
* ⚡ **One-Click Game Reset:** Re-initializes the board array, clear control states, and resets the interface smoothly.
* 🧩 **Efficient Event Subscription:** Centralized control handlers reduce redundant code while maintaining high performance.

---

## 📸 Game Interface

<div align="center">

| Active Game Workspace |
| :---: |
| <img src="Tic-Tac-Toe%20Game%20Interface.png" alt="Tic Tac Toe UI" width="650"> |

</div>

---

## 🛠️ Architecture & Logic

* **Matrix Win Evaluation:** Implements matrix algorithms to check all 8 winning combinations after each move.
* **Control Event Optimization:** Grouped button handler architecture that standardizes move registration.
* **State Machine Pattern:** Controls turn switches (`Turn.X` vs `Turn.O`) and locks board components once a game-ending condition is met.

---

## 🕹️ How To Play

1. **Start Match:** Player X makes the first move on any available grid tile.
2. **Alternate Turns:** The system switches turns automatically after each valid selection.
3. **Win Condition:** Align 3 matching symbols horizontally, vertically, or diagonally to trigger the win screen.
4. **Restart:** Click the **Restart Game** button to reset the board for a new round.

---

## 🚀 Getting Started

### Prerequisites
* **Visual Studio 2019** or newer.
* **.NET Framework**.

### Installation
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/aimanameenmohammed/Tic-Tac-Toe-Game.git]
