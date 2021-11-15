# Devlog
This the devlog I have created as part of the criteria for this assignment. My goal with this project is to create some kind of horror baking simulator, where the player must cook something while constantly in fear of being chased. Ideally the player would think it is a normal 2D cooking sim, and eventually things would start going awry and it would turn into a 3D horror chase game. The first part of this would be ideal if time permits, but the second will be the main goal for this project. Having flexibility in my scope has proved useful in the past, and I want to make sure that this game can handle sudden changes in scope and still provide the desired experience.

## Aesthetic goals
The goals of this game: **(1) Make players feel scared and (2) give them a sense of urgency to complete the outlined objectives**.

Some signs of success for this goal:
- Players are on edge, constantly looking around
- Players are rushing from objective to objective
- Players feel uncomfortable by the audio

Some signs of failure for this goal:
- Players lack urgency or desire to carry out tasks
- Players view the enemy as a non-threat
- Players seem to be bored or annoyed by playing the game

## Core loop
The core gameplay loop of this game will involve finding certain objects, putting them in locations, and running from an enemy. This loop serves the above goals by providing a sense of urgency to the player while leaving them paranoid about being caught.

## Production requirements
- Objects on screen: players move, 3d models move, enemy moves, 2d sprites
- Controls: player controls a first person character, using WASD to move and the mouse to look around
- Object interactions: enemy chases player, player "picks up" objects, enemy gets stopped by obstacles while chasing player, enemy enters a "frenzy mode"
- Sound: sound events for win, lose, enemy approaching, footsteps, objective completion, and ambient music
- Goal and progress: player always has clearly outlined goal and receives feedback that it has been completed
- Playability: instructions are included, player *should* not get stuck anywhere

## Log

### 11/12/2021: Preliminary Design and Layout
- I'm going to use Pol Martin as the chef basing this story, because he's an interesting fella and I also happen to have a model of him from the Socpens game jam. I'm going to start in 3D and do the 2D stuff later if I have time.
- I also found a PSX style shader for URP that I'll be using too. I've been tinkering around with getting it set up.
- I've created a box for this to take place in. The setting was originally going to be a forest, but a kitchen probably makes the most sense given the context.
- Implemented WASD controls and mouse movement, which was surprisingly annoying to do. Also fixed some stuff with colliders not behaving properly depending on the component they were attached to.
- Spent way too much time working with materials and meshes to make sure lighting and transparency is working properly.
- Added a spot light attached to the player camera which will act as a sort of "flashlight" in the dark.

### 11/13/2021: Further Implementation and Code
- I want to organize the game into "phases", and the best way in code would probably be through an enum. But I didn't realize C# enums can't hold fields like Java enums can, so it's a bit more tricky.
- Like I did with the last game, major components of the game are split into different scripts. Audio handlers, game handlers, UI managers, collision handlers, etc.
- Added a bunch more random junk to decorate the scene, such as machines and whatnot. I decided that the ingredients would be 3D models, while everything else would be a 2D sprite. Finding all of those models would be hard and expensive.

### 11/14/2021: Testing and Refinement
- The game is now in a playable state, there are certainly improvements to be made but it is playable.
- I've increased Pol's speed as you progress baking the cake. He needs more work being actually able to catch up without being too hard. 
- Some objects are now animated. Pol has rigged walking and running animations, and other objects will float or spin in space to convey their significance as collectables.
- Currently fixing any inconsistencies as the game moves from state to state (such as certain objects not disappearing)
- There now are many more sounds for many more action. Pol has a heartbeat now on loop so players can hear where he is relative to them and how far away he is. It's also pretty creepy.

### 11/15/ Final Touches and Playtesting
- Fixed a major movement bug (I hope), which leads to more consistent player movement and allows for me to balance Pol's movement better
- Pol has gotten a lot faster after each objective
- Pol also now has a "frenzy mode" he will enter at a couple points in the game. The player receives a warning message and sound, and Pol's speed is greatly increased for the duration of the frenzy.
- Shrinked the playspace slightly to reduce excess space and keep players from getting too lost.
- Audio testing and refinement is also occurring throughout

## Postmortem
My goal was to make a horror-fueled baking "sim" that was at least playable to completion. For what I've been able to do in a couple days, it's alright, and is about in line with what my expectations were. Making the jump to 3D was something that I knew would be intense, but I think it ended well enough. But part of the extra time that implementing 3D took came out of making the game experience itself better. I think the tradeoff was worth it for getting more technical experience, but if I wanted to make a game to publish I would probably refine it a lot more. I wished I knew more about working with materials and textures, but I got a ton of exposure to it this week and have learned a ton. I also wish I started earlier, but this week was way too busy for me to really get a head start on it.