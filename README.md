# BasketVR Toss

## Overview
BasketVR Toss is a casual VR basketball experience designed for relaxation and fun. The player can grab basketballs, aim, and throw them into a hoop in a simple and calming VR environment.

Final project for **AVR500** at Seneca Polytechnic, Fall 2024. **Team project of two.** I was the game designer and developer. My teammate was the game designer and presenter.

| | |
|---|---|
| ![Court overview](screen%20shots/1.jpg) | ![Court with props](screen%20shots/3.jpg) |
| ![Basketball Rigidbody and collider settings](screen%20shots/6.jpg) | ![XR Grab Interactable settings](screen%20shots/7.jpg) |

## Project Goal
The goal of this project was to create an immersive VR experience with simple interaction, realistic throwing physics, and positive feedback for the player.

## My Role
Game designer and developer (team of two)

## Main Features
- VR basketball grabbing interaction
- Physics-based throwing mechanics
- Basketball hoop scoring system
- Audio feedback when scoring
- Visual score display using world-space UI
- Interactive objects such as basketballs and chairs
- Minimal and relaxing basketball court environment

## Gameplay Loop
1. Grab a basketball
2. Aim at the hoop
3. Throw the basketball
4. Score points
5. Receive audio and visual feedback

## Technical Highlights
- Implemented grabbable objects
- Tuned Rigidbody physics for natural throwing
- Used trigger colliders to detect successful shots
- Created a dynamic score UI
- Added sound effects for positive feedback
- Designed a simple environment with props and soft lighting

## Challenges
- Fine-tuning throwing physics for consistent interaction
- Making the hoop trigger detect fast throws reliably
- Placing the UI in a visible but non-distracting position

## Solutions
- Adjusted Rigidbody properties
- Improved trigger zones around the hoop
- Tested multiple UI placements for better user experience

## Skills Demonstrated
- VR development
- Game design
- Physics-based interaction
- UI design
- Audio/visual feedback
- Player experience design
- Problem solving

## What's in this repo

| Path | What it is |
|---|---|
| [`BasketVR-Toss/`](BasketVR-Toss) | The Unity project (Unity 2022.3.11f1, URP, XR Interaction Toolkit 3.0.3, OpenXR) |
| [`BasketVR-Toss/Assets/0_Project-BasketVR Toss/`](BasketVR-Toss/Assets/0_Project-BasketVR%20Toss) | Main scene, gameplay scripts (`HoopTarget.cs`, `gameScore.cs`), score board, audio |
| `BasketVR-Toss/Assets/GameManager1.cs` | Game manager script |
| `BasketVR-Toss/Assets/Prefabs/` | XR Origin (XR Rig) and score UI canvas |
| `screen shots/` | Editor screenshots and gameplay videos |
| `summary.pptx` | The project presentation |

The audio tracks are from free-to-use sources.

## Opening the project

1. Install **Unity 2022.3.11f1** (any 2022.3 LTS should work) and open the `BasketVR-Toss` folder. Unity downloads the packages listed in `Packages/manifest.json`.
2. Open `Assets/0_Project-BasketVR Toss/BasketVR Toss.unity`.

**The third-party 3D models are not included.** They come from asset packs whose licences don't allow re-sharing them, and together they're over 800 MB. Without them, those objects show as missing in the scene. The scripts, XR setup, physics settings and layout all load. To get the full look, import these packs into `Assets/`:

| Folder in the original project | Used for |
|---|---|
| `MarioParadiso` (Basketball Ring) | Hoop and net |
| `Saritasa` (Sport Balls) | Basketball |
| `ModernCartoonCar488` | Car prop |
| `Outdoor bench` | Benches |
| `devotid` (Folding Table and Chair) | Table and grabbable chairs |
| `Gwangju_3D asset` | Trees |
| `Mini Toon Office` | Small props |
| `Abandoned World` (Wood Box Free) | Wood box |
