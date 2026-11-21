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
- `GameManager1.cs`, `HoopTarget.cs`, `gameScore.cs`: the gameplay scripts (scoring, hoop trigger, score display)
- `screen shots/`: editor screenshots and gameplay videos
- `summary.pptx`: the project presentation
- Audio tracks used in the game (free-to-use sources; not covered by the MIT licence)

The full Unity project isn't included because of its size, so the scripts are here to read, not to open as a project.
