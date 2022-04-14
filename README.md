# CIS_410---P2_HauntedJaunt
CIS_410 - P2_HauntedJaunt

Colaboration:
Jonathan Starlord
Meghan Riehl


Idea: 
    use dot product to judge distance and use linear interpolation to adjust color either changing the color directly or to shift between two materials of the same type but different color (red blue)

Dot product: 
    takes the angle between character and NPC returning a value between -1 and 1 
    where 1 is represented as paralelle to eachother (plaer in front of NPC), 0 is perpendicualr, and -1 is Not paralell (ie. the player is behind the NPC)

Linear Interpolation: 
    taking two color inputs or material inputs for Lerp to shift between.


Thus far this has not been able to be implimented, 

Struggles:
    were that we were trying to use the Gargoyle flashlight thing as a proximity color element but I realized late that how the Gargoyle is colored, my method only replaced the stone material layer and made the whole thing blue, and never changed the color of the light.

Currently I am trying to see if I can have the directional light change color based on anything, with mixed success. 

Particle effect: 
    has been added to the fireplace near exit of level. Imported from Unity Standard Particle Effects. slightly modified in values to work better in the application desired.