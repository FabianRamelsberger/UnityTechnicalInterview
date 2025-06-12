# 🦖 UnityTechnicalInterview – Chrome Dino Clone (No Ducking)

This project was created as part of a **1-hour technical interview** for a **Senior Unity Developer** role at a gaming company.  
The task was to recreate the iconic **Chrome Dino Game**, but **without** implementing the ducking mechanic.

---

## 🎮 Overview

**UnityTechnicalInterview** is a minimalist 2D endless runner built in Unity.  
It replicates the basic gameplay of Google Chrome’s offline dinosaur game, focusing on core mechanics like jumping, obstacle spawning, and a simple game loop.

---

## ✅ Requirements

- Unity **2022.3 LTS** or newer
- No external packages required

---

## ✨ Features

- **Jump mechanic** with gravity and basic physics
- **Dynamic obstacle spawning** at randomized intervals
- **Score system** that increments over time
- **Basic game loop**:
  - Start → Run → Game Over → Restart
- **Simple input handling** using `Input.GetKeyDown`
- **Lightweight 2D design** using Unity’s built-in components

---

## ▶️ How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/FabianRamelsberger/UnityTechnicalInterview.git

---

## Project Structure
Assets/
├── Scripts/             # Core gameplay logic
│   ├── DinoController.cs
│   ├── ObstacleSpawner.cs
│   └── GameManager.cs
├── Prefabs/             # Dino and obstacles
├── Scenes/
│   └── MainScene.unity
└── Art/                 # Placeholder 2D assets
