# Projectile-Motion-Unity
A Unity physics simulation of projectile motion based on the "Monkey and Hunter" experiment, featuring real-time UI controls and multiple camera perspectives. Was made by me for school physics project.


## Features
* **Dynamic Physics:** Calculation of projectile motion using mass, velocity, and gravity.
* **Interactive UI:** Users can input launch speed and angle via TextMeshPro fields.
* **Camera Management:** Toggle between a static side view and a dynamic "follow-ball" perspective.
* **Real-time Trajectory:** Visual feedback using Unity's TrailRenderer.
* **Smooth Navigation:** Custom camera positioning using Scrollbars and linear interpolation (Mathf.Lerp).

## Controls
* **[P]** - Spawn/Despawn the target (The "Monkey").
* **[Space]** - Launch the projectile.
* **[R]** - Reset the simulation to initial state.
* **[C]** - Switch between cameras.
* **Scrollbars** - Adjust main camera position.

## Learning Goals
This project was created to practice:
- C# scripting in Unity.
- Working with Rigidbody physics and vectors.
- UI-to-Code integration (Event listeners and Input parsing).
- Basic 3D math (Trigonometry and Interpolation).

## Technical Details
- **Engine:** Unity 6
- **Language:** C#
- **UI:** TextMeshPro & UGUI
