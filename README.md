[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

# Breakdown (in-class assignment)
## Objects:
Player
- Attributes
- - Bunny Sprite
- Movement
- - Input - wasd
- - Output - player movement
- Planting seeds:
- - Input - space
- - Output - If the player has at least one seed: 1 seed is planted at the player’s location, seed count decreases, increases plant count
Plant
- Attributes
- - Plant Sprite
UI
- Seeds remaining
- - Attributes: Text
- - Actions: Increases by 1 when a seed is planted
- Seeds planted
- - Attributes: Text
- - Actions: Decreases by 1 when a seed is planted

## Scripts:
- Game Controller
- Player Script
- UI Script

## Variables:
- Seeds remaining (int)
- Plants planted (int)
- Movement Speed (int)

## Prefabs:
- Player
- - Sprite
- - Script
- Plant
- - Sprite
- - Script

## Code Plan: 
- Make player script with movement (make movement speed variable)
- Make player able to instantiate plant prefab ONLY when the seeds remaining is more than 0 in a way that instantiates it at the player's current location
- Subtract 1 from the number of remaining seeds everytime a plant is instantiated
- Add 1 from the number of plants everytime a plant is instantiated
- Make update UI with new int values when a seed is planted

# Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

The code I wrote for the project followed the code breakdown exactly. I started with writing the movement code using “Input.GetKey” so that holding down the keys would continue to move the character in the specified direction. I also included an “if” statement that checks if there are more than 0 seeds after the player presses space to plant a seed. If the player has more than 0 seeds, the “PlantSeed()” function is run. In this function, the integers “_numSeeds” and “_numSeedsPlanted” get one subtracted and one added respectively. The “Instantiate” function is also used, specifying the plant prefab, the player’s position, and rotation. Finally, the UI’s “UpdateSeeds” function is called, with the updated integers. The UI script updates the attached text from the engine with the integers included in the function parameters. The planning stage perfectly outlined the steps I needed to follow and there was little issue implementing the required features.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
