# Test the Controls - Kill the Dummy

<img width="800" height="447" alt="KillTheDummy" src="https://github.com/user-attachments/assets/2f7e20e8-cd0b-4014-9e5c-e3fc7ff8deba" />

## Status of the project

Finished

## Goal

The goal of this project was to learn how to implement character movement and basic combat controls in Unity. I wanted to use these controls as a foundation for my next game.

I wanted to learn how to:

- Move a character using WASD
- Aim with the mouse
- Shoot in the direction of the mouse cursor
- Create a simple gameplay loop

## What does the game do?

In this small game, you control a pixel character named Anna, who trains by attacking dummies.

Each dummy has its own health pool and takes damage when hit by an attack.

The character can be moved using WASD. While moving or standing still, the player can attack by clicking the left mouse button. Attacks are directed towards the mouse cursor.

After a dummy is defeated, a new one spawns on the field, creating a continuous gameplay loop.

## Challenges

The biggest challenge in this project was getting familiar with Unity's new Input System.

Many of the tutorials I watched still used the old input system, which made learning the new one a bit more difficult.

However, once I understood how it worked, I really started to like it! I especially liked how different controls could be assigned to the same action.

Another challenge was implementing the aiming system. First, I had to figure out how to get the correct mouse position in the game world. Then I needed to calculate how to rotate objects towards that position.

This took some experimenting, but eventually worked as intended.

### Keeping things simple

While developing the game, I wanted to create a cone to test collision detection.

The cone was supposed to be yellow and turn green whenever a dummy entered its range.

At first, I started looking into meshes, but quickly realized how complicated this was for me at that point.

Then I came across a comment suggesting a much simpler approach: Just draw a cone and rotate it around the player.

How genius!

This reminded me of something I learned early in programming: **Make it work first.**

Especially for a simple testing tool during development, this solution was much more useful than creating a mesh.

## What did I learn?

This was the first project where I really started programming in Unity, after mainly working with objects in the editor in my first project.

I learned how to:

- Write my first scripts for GameObjects
- Create prefabs with their own scripts
- Give each prefab instance its own health value
- Work with Unity's new Input System
- Implement mouse-based aiming
- Rotate objects towards the mouse cursor
- Find solutions through tutorials and documentation

Most importantly, I learned that I don't always need a complicated solution to solve a problem. Sometimes keeping things simple is the better approach.

## Use of AI

I intentionally developed this project without using AI.

For personal projects and learning purposes, I want to preserve the magic of programming and figure things out myself.

## My other Unity Projects

- [Speedy](https://github.com/Annymea/Speedy)
- [Mini Azeroth](https://github.com/Annymea/Mini-Azeroth)
