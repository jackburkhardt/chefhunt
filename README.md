# chefhunt
chefhunt was created for another homework assignment as part of Northwestern's CS 376 (Game Design and Devlopment) course. This game was made in roughly 3-4 days; to see a devlog of the progress, check out [devlog.md](https://github.com/jackburkhardt/chefhunt/blob/main/devlog.md).

You'll learn more background about the game itself once you start playing, but it's essentially a "horror" "baking" "simulator" where you must collect ingredients and bake a cake before you get caught by French-Canadian chef Pol Martin (he's...[a character](https://twitter.com/oakeymations/status/1319129464438140928)). Also, it's completely dark and you only have a flashlight.


## Instructions

On screen, you will see tools (2d sprites) and ingredients (3d models). You'll also see a very tall Pol Martin running after you. Follow the tasks on the top left. To complete them, find the mentioned object and "interact" with it by walking into it. You technically have an inventory of stuff you've collected, but it's imaginary right now. If an object disappears, it means you've "picked it up".

You win the game if you follow the instructions to bake the cake and pick it up before Pol Martin catches you. 
If he does run into you, you die. Pol's movement gets slightly faster after you complete each objective.

Oh, one last thing: sometimes during the game Pol will enter a "frenzy" where he temporarily moves much faster. You'll know when it happens.

## Controls
- WASD - Move around (forward, left, right, backwards respectively)
- Mouse - Look around
- Collide/walk into object - Interact with object or pick it up
- Escape - quit game (build versions only)

## Credits
Thanks to the following sources for creating and contributing resources used in this project:

Sound:
- Background loop: JarredGibb via freesound.org
- Win Sound: jobro via freesound.org
- Lose Sound: HorrorAudio via freesound.org
- Heartbeat sound: InspectorJ via freesound.org
- Walking sound: simoneyoh3998 via freesound.org
- Frenzy Sound: old_waveplay via freesound.org

Graphics:
- Butter, Cake, Flour, Sugar 3D models and textures by [a11ce](https://github.com/a11ce)
- Salt: ramiescalante via turbosquid.com
- Milk: vabart via sketchfab.com
- Egg: pepnudl via cgtrader.com
- 2d images sourced from various locations including Adobe Stock image library
- Shaders and some materials by Kodrin (https://github.com/Kodrin/URP-PSX)

Models:
- Pol Martin, wet food models and textures by socpens (twitch.tv/socpens)
- Animation set by Kevin Iglesias via Unity Asset Store

Fonts:
- Scary Light by Yoga Letter

Most sources here fall under Creative Commons, but regardless all sources are property of their 
respective owners and are not to be used in a commercial setting.

## Usage
You're free to do whatever you want with this project, so long as it remains non-commercial and retains proper attribution to me and the others mentioned in the credits. If you're a current CS 376 student, you may not use any of this for your own projects.
